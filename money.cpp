#include "money.h"
#include <iostream>
#include <sstream>
using namespace std;

void Money::normalize() {
    if (kopecks >= 100) {
        hryvnias += kopecks / 100;
        kopecks %= 100;
    }
}

// 🔹 Конструктори
Money::Money() : hryvnias(0), kopecks(0) {}

Money::Money(long h, unsigned char k) {
    Init(h, k);
}

Money::Money(const Money& other) {
    hryvnias = other.hryvnias;
    kopecks = other.kopecks;
}

// 🔹 Методи
void Money::Init(long h, unsigned char k) {
    hryvnias = h;
    kopecks = k;
    normalize();
}

double Money::Summa() const {
    return hryvnias + (kopecks / 100.0);
}

void Money::Read() {
    cout << "Введіть гривні: ";
    cin >> hryvnias;
    cout << "Введіть копійки (0–99): ";
    int k; cin >> k;
    kopecks = k;
    normalize();
}

void Money::Display() const {
    cout << hryvnias << "," << (kopecks < 10 ? "0" : "") << (int)kopecks << " грн" << endl;
}

string Money::toString() const {
    ostringstream oss;
    oss << hryvnias << "," << (kopecks < 10 ? "0" : "") << (int)kopecks << " грн";
    return oss.str();
}

//
// 🔸 Перевантаження арифметичних операторів
//

// 1. Додавання
Money Money::operator+(const Money& other) const {
    long total1 = hryvnias * 100 + kopecks;
    long total2 = other.hryvnias * 100 + other.kopecks;
    long sum = total1 + total2;
    return Money(sum / 100, sum % 100);
}

// 2. Віднімання
Money Money::operator-(const Money& other) const {
    long total1 = hryvnias * 100 + kopecks;
    long total2 = other.hryvnias * 100 + other.kopecks;
    long diff = total1 - total2;
    return Money(diff / 100, abs(diff % 100));
}

// 3. Множення на число
Money Money::operator*(double value) const {
    long total = static_cast<long>((hryvnias * 100 + kopecks) * value);
    return Money(total / 100, total % 100);
}

// 4. Ділення на число
Money Money::operator/(double value) const {
    long total = static_cast<long>((hryvnias * 100 + kopecks) / value);
    return Money(total / 100, total % 100);
}

// Ділення суми на суму (результат — відношення)
double Money::operator/(const Money& other) const {
    double total1 = hryvnias * 100 + kopecks;
    double total2 = other.hryvnias * 100 + other.kopecks;
    return total1 / total2;
}

//
// 🔸 Операції порівняння
//
bool Money::operator==(const Money& other) const { return Summa() == other.Summa(); }
bool Money::operator!=(const Money& other) const { return !(*this == other); }
bool Money::operator<(const Money& other) const { return Summa() < other.Summa(); }
bool Money::operator>(const Money& other) const { return Summa() > other.Summa(); }
bool Money::operator<=(const Money& other) const { return !(*this > other); }
bool Money::operator>=(const Money& other) const { return !(*this < other); }
