#include <iostream>
#include "money.h"
#include <windows.h>
using namespace std;

int main() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);

    Money m1, m2;

    cout << "Введіть першу суму m1:" << endl;
    m1.Read();
    cout << "Введіть другу суму m2:" << endl;
    m2.Read();

    cout << "m1 = "; m1.Display();
    cout << "m2 = "; m2.Display();

    // додавання
    Money sum = m1 + m2;
    cout << "m1 + m2 = "; sum.Display();

    // віднімання
    Money diff = m1 - m2;
    cout << "m1 - m2 = "; diff.Display();

    // множення на число
    double k = 2.5;
    Money mul = m1 * k;
    cout << "m1 * " << k << " = "; mul.Display();

    // ділення на число
    double d = 2.0;
    Money div = m1 / d;
    cout << "m1 / " << d << " = "; div.Display();

    // ділення суми на суму
    double ratio = m1 / m2;
    cout << "m1 / m2 = " << ratio << endl;

    // порівняння
    if (m1 > m2) cout << "m1 > m2" << endl;
    else if (m1 < m2) cout << "m1 < m2" << endl;
    else cout << "m1 == m2" << endl;

    return 0;
}
