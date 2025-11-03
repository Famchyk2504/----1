#include <iostream>
#include <windows.h>
#include "money.h"
using namespace std;

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    cout << "Демонстрація роботи трьох конструкторів класу Money:\n\n";

    // 🔹 1. Конструктор за замовчуванням
    Money m1;
    cout << "Конструктор за замовчуванням: ";
    m1.Display();

    // 🔹 2. Конструктор із параметрами
    Money m2(123, 45);
    cout << "Конструктор із параметрами (123 грн 45 коп): ";
    m2.Display();

    // 🔹 3. Конструктор копіювання
    Money m3(m2);
    cout << "Конструктор копіювання (копія m2): ";
    m3.Display();

    cout << "\nТепер виконаємо операції над грошима:\n";

    Money a, b;
    cout << "\nВведіть першу суму a:\n";
    a.Read();
    cout << "Введіть другу суму b:\n";
    b.Read();

    cout << "\na = "; a.Display();
    cout << "b = "; b.Display();

    // додавання
    Money sum = a + b;
    cout << "\na + b = "; sum.Display();

    // віднімання
    Money diff = a - b;
    cout << "a - b = "; diff.Display();

    // множення на число
    double k = 2.5;
    Money mul = a * k;
    cout << "a * " << k << " = "; mul.Display();

    // ділення на число
    double d = 2.0;
    Money div = a / d;
    cout << "a / " << d << " = "; div.Display();

    // ділення суми на суму
    double ratio = a / b;
    cout << "a / b = " << ratio << endl;

    // порівняння
    if (a > b) cout << "a > b" << endl;
    else if (a < b) cout << "a < b" << endl;
    else cout << "a == b" << endl;

    return 0;
}