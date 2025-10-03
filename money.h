#pragma once
#include <string>
using namespace std;

class Money {
private:
    long hryvnias;          // гривні
    unsigned char kopecks;  // копійки

    void normalize();    // нормалізація (копійки < 100)

public:
    // конструктор
    Money(long h = 0, unsigned char k = 0);

    // ініціалізація
    void Init(long h, unsigned char k);

    // загальна сума у грн
    double Summa() const;

    // методи
    void Read();        // введення
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
