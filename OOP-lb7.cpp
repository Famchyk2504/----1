#include <iostream>
#include <stdexcept>
#include <exception>
#include <sstream>
#include <string>
#include <locale>
#include <windows.h>

struct EmptyTimeErr {};

// Клас з полями
class TimeFieldError {
public:
    int hours;
    int minutes;
    std::string description;

    TimeFieldError(int h, int m, const std::string& desc)
        : hours(h), minutes(m), description(desc) {
    }
};

//Наслідник std::exception з полями
class TimeExceptionStd : public std::exception {
    int h_val;
    int m_val;
    std::string msg;
    std::string full_msg;
public:
    TimeExceptionStd(int h, int m, const std::string& text)
        : h_val(h), m_val(m), msg(text)
    {
        std::ostringstream oss;
        oss << "помилка часу: " << msg
            << " (год: " << h_val << ", хв: " << m_val << ")";
        full_msg = oss.str();
    }

    const char* what() const noexcept override {
        return full_msg.c_str();
    }
};

// Функції 

// Без специфікації
long convertNoSpec(int h, int m)
{
    if (h < 0 || m < 0 || m > 59)
        throw std::invalid_argument("Невірний формат часу");
    return h * 3600 + m * 60;
}

// throw()
long convertThrow(int h, int m) throw()
{
    if (h < 0 || m < 0 || m > 59)
        throw EmptyTimeErr();
    return h * 3600 + m * 60;
}

//Стандартний вийняток
long convertStd(int h, int m) throw(std::invalid_argument)
{
    if (h < 0 || m < 0 || m > 59)
        throw std::invalid_argument("Неприпустимий формат часу");
    return h * 3600 + m * 60;
}

//Власний вийняток
long convertCustom(int h, int m) throw(TimeFieldError, TimeExceptionStd)
{
    if (h < 0)
        throw TimeFieldError(h, m, "Години менше нуля");

    if (m < 0 || m > 59)
        throw TimeExceptionStd(h, m, "Хвилини поза діапазоном");

    return h * 3600 + m * 60;
}

// Головна програма 
int main()
{
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);
    int h_input, m_input;
    std::cout << "Переведення часу в секунди\n";

    // Ввід користувача з перевіркою
    try {
        std::cout << "Введіть години: ";
        std::cin >> h_input;
        if (!std::cin) throw std::runtime_error("Потрібно число.");

        std::cout << "Введіть хвилини: ";
        std::cin >> m_input;
        if (!std::cin) throw std::runtime_error("Потрібно число.");
    }
    catch (const std::runtime_error& e) {
        std::cerr << e.what() << "\n";
        return 1; 
    }

    std::cout << "\n Демонстрація функцій \n";

    // Без специфікації
    try {
        long sec1 = convertNoSpec(h_input, m_input);
        std::cout << "Без специфікації: " << sec1 << " секунд\n";
    }
    catch (const std::exception& e) {
        std::cerr << "Без специфікації: " << e.what() << "\n";
    }

    // З специфікацією throw()
    try {
        long sec2 = convertThrow(h_input, m_input);
        std::cout << "З специфікацією Throw(): " << sec2 << " секунд\n";
    }
    catch (const EmptyTimeErr&) {
        std::cerr << "З специфікацією Throw(): Порожнє власне виключення\n";
    }

    // Стандартний вийняток
    try {
        long sec3 = convertStd(h_input, m_input);
        std::cout << "Стандартний вийняток: " << sec3 << " секунд\n";
    }
    catch (const std::invalid_argument& e) {
        std::cerr << "Стандартний вийняток: " << e.what() << "\n";
    }

    // Власний вийняток
    try {
        long sec4 = convertCustom(h_input, m_input);
        std::cout << "Власний вийняток: " << sec4 << " секунд\n";
    }
    catch (const TimeFieldError& e) {
        std::cerr << "Власний вийняток: " << e.description
            << " [год: " << e.hours << ", хв: " << e.minutes << "]\n";
    }
    catch (const TimeExceptionStd& e) {
        std::cerr << "Власний вийняток " << e.what() << "\n";
    }
    return 0;
}
