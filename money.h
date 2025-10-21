#pragma once
#include <string>
using namespace std;

class Money {
private:
    long hryvnias;          // гривні
    unsigned char kopecks;  // копійки

    void normalize();        // нормалізація (копійки < 100)

public:
    // 🔹 Конструктори
    Money();                                // за замовчуванням
    Money(long h, unsigned char k);         // із параметрами
    Money(const Money& other);              // копіювання

    // 🔹 Основні методи
    void Init(long h, unsigned char k);
    void Read();
    void Display() const;
    string toString() const;
    double Summa() const;

    // 🔹 Арифметичні оператори (перевантаження)
    Money operator+(const Money& other) const;   // додавання
    Money operator-(const Money& other) const;   // віднімання
    Money operator*(double value) const;         // множення на число
    Money operator/(double value) const;         // ділення на число
    double operator/(const Money& other) const;  // відношення сум

    // 🔹 Операції порівняння
    bool operator==(const Money& other) const;
    bool operator!=(const Money& other) const;
    bool operator<(const Money& other) const;
    bool operator>(const Money& other) const;
    bool operator<=(const Money& other) const;
    bool operator>=(const Money& other) const;
};
