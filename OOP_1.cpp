#include <iostream>
#include "money.h"
#include <windows.h>
using namespace std;

int main()
{
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    money m1;  // створюємо об’єкт типу money
    m1.Read();  // вводимо дані
    m1.Display();  // показуємо дані
    cout << " Загальна сума: " << m1.Summa() << endl;
    return 0;
} 