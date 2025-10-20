#include "money.h"
#include <iostream>
#include <sstream>
using namespace std;

void Money::normalize() {
    if (kopecks >= 100) {
        hryvnias += kopecks / 100;
        kopecks = kopecks % 100;
    }
}

// 🔸 1. Конструктор за замовчуванням
Money::Money() {
    hryvnias = 0;
    kopecks = 0;
}

// 🔸 2. Конструктор із параметрами
Money::Money(long h, unsigned char k) {
    Init(h, k);
}

// 🔸 3. Конструктор копіювання
Money::Money(const Money& other) {
    hryvnias = other.hryvnias;
    kopecks = other.kopecks;
}

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
    cout << "Введіть копійки (0-99): ";
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

// арифметичні оператори
Money Money::operator+(const Money& other) const {
    return Money(hryvnias + other.hryvnias, kopecks + other.kopecks);
}

Money Money::operator-(const Money& other) const {
    long total1 = hryvnias * 100 + kopecks;
    long total2 = other.hryvnias * 100 + other.kopecks;
    long diff = total1 - total2;
    return Money(diff / 100, diff % 100);
}

Money Money::operator*(double value) const {
    long total = (hryvnias * 100 + kopecks) * value;
    return Money(total / 100, total % 100);
}

Money Money::operator/(double value) const {
    long total = (hryvnias * 100 + kopecks) / value;
    return Money(total / 100, total % 100);
}

double Money::operator/(const Money& other) const {
    double total1 = hryvnias * 100 + kopecks;
    double total2 = other.hryvnias * 100 + other.kopecks;
    return total1 / total2;
}

// оператори порівняння
bool Money::operator==(const Money& other) const { return Summa() == other.Summa(); }
bool Money::operator!=(const Money& other) const { return !(*this == other); }
bool Money::operator<(const Money& other) const { return Summa() < other.Summa(); }
bool Money::operator>(const Money& other) const { return Summa() > other.Summa(); }
bool Money::operator<=(const Money& other) const { return !(*this > other); }
bool Money::operator>=(const Money& other) const { return !(*this < other); }
