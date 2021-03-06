// ConsoleApplication13.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
//

#include "pch.h"
#include <iostream>
#include <fstream>
#include <random>
#include <time.h>
#include <iomanip>
#include <iterator>
#include <list>
#include <string>
#include <iterator>

using namespace std;

list<double> li;



int get_random(int max, int min) {
	return int((double(rand()) / RAND_MAX)*(max - min)) + min;
}

ofstream fill(string name, int n, int m)
{
	ofstream file;
	file.open(name, ios::out);
	srand(time(0));

	for (int i = 0; i < n; i++)
		file << setw(5) << get_random(m, -m) << " ";
	return file;
}



ofstream fill_generate(string name, int n, int m)
{
	ofstream file;
	file.open(name, ios::out);

	list<double> li(n);
	generate(li.begin(), li.end(), [m]()
	{
		return  get_random(m, -m);
	}
	);
	for (double i : li)
		file << i << "  ";
	
	return file;
}

list<double> read(ifstream file)
{
	if (!file)
		cout << "Файл не найден";
	list<double> res;
	int tmp;
	while (!file.eof() && file >> tmp) //cout << tmp << std::endl;
		res.push_back(tmp);
	return res;
}

double sum(list<double> li)
{
	double sum = 0;
	for (double i : li)
		sum += i;
	return sum;
}

double average(list<double> li)
{
	return (double)sum(li) / (double)li.size();
}

double get_last_negative(list<double> li)
{
	double x;
	double first_negative = 0;
	list<double> ::reverse_iterator it;
	for (it = li.rbegin(); it != li.rend() && (first_negative == 0); it++)
	{
		x = *it;
		if (x < 0)
			first_negative = x;
	}
	return first_negative;
}

double modify_el(double &value)
{
	double modifer = get_last_negative(li);
	return value = value + (modifer / 2);
}

list<double> modify(list<double> li)
{
	double modifer = get_last_negative(li);
	cout << "\n" << "Последнее отрицательное = " << modifer << endl;
	list<double> res;
	for (double i : li)
		res.push_back(modify_el(i));
	return res;
}

list<double> modify(list<double>::iterator begin, list<double>::iterator end)
{
	
	double neg = 0.0;
	list<double>::iterator curr = begin;
	for (int i = 0; curr != end; i++)
	{
		if (*curr < 0)
			neg = *curr;
		curr++;
	}

	list<double> res;
	for (curr = begin; curr != end; curr++)
	{
		res.push_back(modify_el(*curr));
	}
	return res;
}

list<double> modify_transform(list<double> li)
{
	list<double> res;
	res = li;
	list<double>::iterator p = res.begin();
	p = transform(res.begin(), res.end(), res.begin(), modify_el);
	return res;
}

list<double> modify_foreach(list<double> &li)
{
	list<double> res;
	res = li;
	for_each(res.begin(), res.end(), modify_el);
	return res;
}

void Print_List(list<double> li)
{
	for (double i : li)
		cout << i << "\t";
	cout << endl;

}

bool NotIsEmpty(list<double> li)
{
	bool res = false;
	if (li.empty())
		cout << "Сформируйте список !!!" << endl;
	else
		res = true;
	return res;
}

int InputSize(string txt, int min, int max)
{
	int ArrSize;
	cout << txt << endl; //вывод вопроса на экран
	cin >> ArrSize;
	while ((ArrSize < min) || (ArrSize > max)) //пока число num не попадает в диапозон [min..max] 
	{
		cout << "Недопустимое значение, введите еще раз:" << endl;
		cin >> ArrSize;
	}
	return ArrSize;
}

int SelectMenuItem(void)
{
	cout << "Выберите один из пунктов меню:" << endl;
	cout << "1 - Заполнение файла случайными числами" << endl;
	cout << "2 - Получить контейнер list с числами из файла" << endl;
	cout << "3 - Модифицировать" << endl;
	cout << "4 - Модифицировать от n до m" << endl;
	cout << "5 - std::transform" << endl;
	cout << "6 - std::for_each" << endl;
	cout << "7 - Сумма, ср.арифметическое" << endl;
	cout << "8 - Вывод информации" << endl;
	return InputSize("0 - выйти из программы", 0, 8);
}

int SelectSubMenuItem(void)
{
	cout << "Выберите один из пунктов меню:" << endl;
	cout << "1 - Вывести на экран" << endl;
	cout << "2 - Вывести в файл" << endl;
	return InputSize("0 - выйти из подменю", 0, 2);
}

int SelectSubFileMenuItem(void)
{
	cout << "Выберите один из пунктов меню:" << endl;
	cout << "1 - С помощью цикла" << endl;
	cout << "2 - С помощью std::random" << endl;
	return InputSize("0 - выйти из подменю", 0, 2);
}

int main()
{
	setlocale(LC_ALL, "Russian");
	cout << "Начата работа" << endl;
	//try
	//{
	int MenuItem = -1;
	int PodMenu ;
	list<double>::iterator in = li.begin();
	list<double>::iterator im = li.begin();
	while (MenuItem != 0)
	{
		MenuItem = SelectMenuItem();
		switch (MenuItem)
		{
			case 1:PodMenu = SelectSubFileMenuItem();
				int n, m;
				cout << "Введите количество элементов в списке" << endl;
				cin >> n;
				cout << "Введите диапозон значений в списке" << endl;
				cin >> m;
				switch (PodMenu)
				{
				case 1: fill("aaa.txt", n, m).close();
					break;
				case 2: fill_generate("aaa.txt", n, m).close();
					break;
				}
				break;
			case 2: li = read(ifstream("aaa.txt"));
				cout << "Список: ";
				Print_List(li);
				break;

			case 3:if (NotIsEmpty(li))
			{
				cout << "Модифицированный список: ";
				li = modify(li);
				Print_List(li);
				cout << endl;
			}
				   break;

			case 4:
				if (NotIsEmpty(li))
				{
					li = modify(li.begin(), li.end());
					Print_List(li);
					cout << endl;
				}
				break;

			case 5:
				if (NotIsEmpty(li))
				{
					cout << "Модифицированный список: " << endl;
					li = modify_transform(li);
					Print_List(li);
					cout << endl;
				}
				break;
			case 6:if (NotIsEmpty(li))
			{
				cout << "Модифицированный список: " << endl;
				li = modify_foreach(li);
				Print_List(li);
				cout << endl;
			}
				   break;
			case 7:if (NotIsEmpty(li))
			{
				cout << "Список: ";
				Print_List(li);
				cout << "Сумма = " << sum(li) << "   Среднее арифметическое = " << average(li) << endl;
			}
				   break;
			case 8:if (NotIsEmpty(li))
			{
				PodMenu = SelectSubMenuItem();
				while (PodMenu != 0)
				{
					switch (PodMenu)
					{
					case 1:
						cout << "Список: ";
						Print_List(li);
						cout << "Отрицательное = " << get_last_negative(li) << endl << endl;

						break;
					case 2:

						ofstream f;
						f.open("out.txt", ios::out);
						for (double i : li)
							f << i << "\t";
						cout << "\n";
						f.close();

						break;
					}
					PodMenu = SelectSubMenuItem();
				}
			}
		}
	}
}


// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.
