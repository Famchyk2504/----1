#include "money.h"

void money::Init(int f, int s)
{
	first = f;
	second = s;
}

void money::Read()
{
	cout << " Введіть номінал купюри:";
	cin >> first;
	cout << " Введіть кількість купюр: ";
	cin >> second;
}

void money::Display()
{
	cout << " Номінал: " << first << ", Кількість: " << second << endl;
}

int money::Summa()
{
	return first * second;
}
