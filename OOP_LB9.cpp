#include <iostream>
#include <cmath>
#include <clocale>
using namespace std;

#ifndef M_PI
#define M_PI 3.14159265358979323846
#endif

class GeometricFigure {
protected:
    double x, y, angle, scale;
public:
    GeometricFigure(double x_center = 0, double y_center = 0, double ang = 0, double sc = 1)
        : x(x_center), y(y_center), angle(ang), scale(sc) {
    }
    virtual void show() const = 0;
    virtual void hide() const = 0;
    virtual void rotate(double new_angle) { angle += new_angle; }
    virtual void move(double dx, double dy) { x += dx; y += dy; }
};

class Circle : public GeometricFigure {
private:
    double radius;
public:
    Circle(double x_center = 0, double y_center = 0, double r = 1, double ang = 0, double sc = 1)
        : GeometricFigure(x_center, y_center, ang, sc), radius(r) {
    }

    void show() const override {
        cout << "Круг з центром (" << x << ", " << y << "), радіусом " << radius
            << ", кут: " << angle << " градусів, масштаб: " << scale << endl;
    }

    void show(bool detailed) const {
        if (detailed) {
            cout << "Деталі круга:" << endl;
            cout << "Центр: (" << x << ", " << y << ")" << endl;
            cout << "Радіус: " << radius << endl;
            cout << "Кут повороту: " << angle << " градусів" << endl;
            cout << "Масштабний фактор: " << scale << endl;
            cout << "Площа: " << M_PI * radius * radius << endl;
            cout << "Довжина кола: " << 2 * M_PI * radius << endl;
        }
        else show();
    }

    void hide() const override {
        cout << "Круг з центром (" << x << ", " << y << ") прихований." << endl;
    }
    void setRadius(double r) { radius = r; }
    double getRadius() const { return radius; }
};

int main() {
    // Для правильної роботи кирилиці у Windows
    system("chcp 1251"); // встановлюємо кодування Windows-1251 для консолі

    Circle c1(5, 5, 3);
    c1.show();
    c1.move(2, 3);
    c1.rotate(45);
    c1.show(true);
    c1.hide();

    return 0;
}