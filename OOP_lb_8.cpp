#include <iostream>
#include <clocale>  // для setlocale

// Базовий клас: пара чисел
class Pair {
protected:
    double first;
    double second;

public:
    // Конструктор
    Pair(double a = 0.0, double b = 0.0) : first(a), second(b) {}

    // Методи для зміни полів
    void setFirst(double a) { first = a; }
    void setSecond(double b) { second = b; }

    // Метод для обчислення добутку
    virtual double product() const {
        return first * second;
    }

    // Віртуальний метод для демонстрації підстановки
    virtual void print() const {
        std::cout << "Пара чисел: first = " << first << ", second = " << second << "\n";
    }
};

// Похідний клас: прямокутник
class Rectangle : public Pair {
public:
    // Конструктор
    Rectangle(double w = 0.0, double h = 0.0) : Pair(w, h) {}

    // Метод для площі
    double area() const {
        return first * second;
    }

    // Метод для периметра
    double perimeter() const {
        return 2 * (first + second);
    }

    // Перевизначений метод print
    void print() const override {
        std::cout << "Прямокутник: ширина = " << first << ", висота = " << second << "\n";
    }
};

// Функція, що демонструє принцип підстановки
Pair demonstrateSubstitution(const Pair& p) {
    std::cout << "=== Демонстрація принципу підстановки ===\n";
    p.print();
    std::cout << "Добуток чисел = " << p.product() << "\n";
    return p; // повертаємо об'єкт базового класу
}

int main() {
    // Встановлюємо українську локаль для консолі
    setlocale(LC_ALL, "uk-UA"); // на Windows можна "Ukrainian", на Linux "uk_UA.UTF-8"

    // Робота з базовим класом
    Pair pair1(4, 5);
    std::cout << "=== Робота з класом Pair ===\n";
    pair1.print();
    std::cout << "Добуток чисел = " << pair1.product() << "\n\n";

    // Робота з похідним класом
    Rectangle rect1(5, 10);
    std::cout << "=== Робота з класом Rectangle ===\n";
    rect1.print();
    std::cout << "Площа прямокутника = " << rect1.area() << "\n";
    std::cout << "Периметр прямокутника = " << rect1.perimeter() << "\n\n";

    // Демонстрація принципу підстановки
    Rectangle rect2(2, 3);
    Pair result = demonstrateSubstitution(rect2); // Rectangle передається як Pair

    return 0;
}
