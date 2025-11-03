#pragma once
#include <string>
using namespace std;

class Money {
private:
    long hryvnias;          // гривні
    unsigned char kopecks;  // копійки

    void normalize();    // нормалізація (копійки < 100)

public:
    // 🔸 1. Конструктор за замовчуванням
    Money();

    // 🔸 2. Конструктор із параметрами
    Money(long h, unsigned char k);

    // 🔸 3. Конструктор копіювання
    Money(const Money& other);

    // ініціалізація
    void Init(long h, unsigned char k);

    // загальна сума у грн
    double Summa() const;

    // методи
    void Read();          // введення
    void Display() const; // виведення
    string toString() const;

    // арифметичні операції
    Money operator+(const Money& other) const;
    Money operator-(const Money& other) const;
    Money operator*(double value) const;
    Money operator/(double value) const;
    double operator/(const Money& other) const;

    // операції порівняння
    bool operator==(const Money& other) const;
    bool operator!=(const Money& other) const;
    bool operator<(const Money& other) const;
    bool operator>(const Money& other) const;
    bool operator<=(const Money& other) const;
    bool operator>=(const Money& other) const;
};
