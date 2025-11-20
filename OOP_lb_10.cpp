#include <iostream>
#include <cmath>
#include <windows.h>
using namespace std;

class Triangle {
public:
    // Поліморфізм
    virtual double getA() = 0;
    virtual double getB() = 0;
    virtual double getC() = 0;

    // Площа по Герону
    double Area() {
        double a = getA(), b = getB(), c = getC();
        double p = (a + b + c) / 2;
        return sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Медіана 
    double Median(char s) {
        double a = getA(), b = getB(), c = getC();
        if (s == 'a') return 0.5 * sqrt(2 * b * b + 2 * c * c - a * a);
        if (s == 'b') return 0.5 * sqrt(2 * a * a + 2 * c * c - b * b);
        return 0.5 * sqrt(2 * a * a + 2 * b * b - c * c);
    }

    // Середня лінія 
    double Midline(char s) {
        if (s == 'a') return getA() / 2.0;
        if (s == 'b') return getB() / 2.0;
        return getC() / 2.0;
    }

    virtual ~Triangle() {}
};

// Трикутник за трьома сторонами 
class TriangleSides : public Triangle {
private:
    double a, b, c;
public:
    TriangleSides(double aa, double bb, double cc) {
        a = aa;
        b = bb;
        c = cc;
    }

    double getA() override { return a; }
    double getB() override { return b; }
    double getC() override { return c; }
};

// Трикутник за координатами 
class TrianglePoints : public Triangle {
private:
    double x1, y1, x2, y2, x3, y3;

    double dist(double x1, double y1, double x2, double y2) {
        return sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
    }

public:
    TrianglePoints(double X1, double Y1,
        double X2, double Y2,
        double X3, double Y3) {
        x1 = X1; y1 = Y1;
        x2 = X2; y2 = Y2;
        x3 = X3; y3 = Y3;
    }

    double getA() override { return dist(x2, y2, x3, y3); }
    double getB() override { return dist(x1, y1, x3, y3); }
    double getC() override { return dist(x1, y1, x2, y2); }
};

// Трикутник за медіанами 
class TriangleMedians : public Triangle {
private:
    double a, b, c;

public:
    TriangleMedians(double mA, double mB, double mC) {
        // Формули
        a = sqrt(2.0 / 3 * (mB * mB + mC * mC) - mA * mA / 3);
        b = sqrt(2.0 / 3 * (mA * mA + mC * mC) - mB * mB / 3);
        c = sqrt(2.0 / 3 * (mA * mA + mB * mB) - mC * mC / 3);
    }

    double getA() override { return a; }
    double getB() override { return b; }
    double getC() override { return c; }
};

// Прямокутний трикутник
class RightTriangle : public TriangleSides {
public:
    // Катети
    RightTriangle(double a, double b)
        : TriangleSides(a, b, sqrt(a* a + b * b)) {
    }

    // Радіус вписаного кола
    double inR() {
        double a = getA(), b = getB(), c = getC();
        return (a + b - c) / 2;
    }

    // Радіус описаного
    double outR() {
        return getC() / 2;
    }
};

int main() {
    SetConsoleOutputCP(1251); 
    SetConsoleCP(1251);

    cout << " Трикутник за сторонами \n";
    Triangle* t = new TriangleSides(3, 4, 5);

    cout << "Площа = " << t->Area() << endl;
    cout << "Медіана до a = " << t->Median('a') << endl;
    cout << "Середня лінія до c = " << t->Midline('c') << endl;

    delete t;

    cout << "\n Прямокутний трикутник \n";
    RightTriangle rt(3, 4);

    cout << "Площа = " << rt.Area() << endl;
    cout << "r (вписане) = " << rt.inR() << endl;
    cout << "R (описане) = " << rt.outR() << endl;

    return 0;
}
