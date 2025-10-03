#pragma once
#include<iostream>
using namespace std;

struct money
{
private:
	int first;  // номінал купюри
	int second; // кількість купюр
public:
	void Init(int f, int s); // метод ініціалізації
	void Read();  // метод вводу даних
	void Display();  // метод виводу даних
	int Summa();   // метод підрахунку суми
};

