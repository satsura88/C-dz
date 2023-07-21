﻿/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

int Prompt(string message)
{
	System.Console.Write(message); 
	string value = Console.ReadLine(); 
	int result= Convert.ToInt32(value); 
	return result;
}

int number = Prompt("Введите трехзначное число > "); 
if (number < 100 || number >= 1000)
{
	Console.WriteLine("Вы ввели не трехзначное число, пожалуйста повторите ввод") ;
	return;
}

Console.WriteLine($"Введенное число '{number}'"); 
int secondRank = number / 10 % 10;
Console.WriteLine($"Вторая цифра '{secondRank}'");

/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int Prompt(string message)
{
	Console.Write(message); 
	string value = Console.ReadLine(); 
	int result = Convert.ToInt32(value); 
	return result;
}

int GetThirdRank(int number)
{
	while (number > 999)
{
	number /= 10;
}
	return number % 10;
}

bool ValidateNumber(int number)
{
	if (number < 100)
	{
		Console.WriteLine("Третьей цифры нет"); return false;
	}	
		return true;
}

int number = Prompt("Введите число > "); 
if (ValidateNumber(number))
{
	Console.WriteLine(GetThirdRank(number));
}

/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Prompt(string message)
{
	Console.Write(message); 
	string value = Console.ReadLine(); 
	int result = Convert.ToInt32(value); 
	return result;
}

bool IsWeekend(int weekDay)
{
	if (weekDay > 5)
{
	return true;
}
	return false;
}

bool ValidateWeekday(int number)
{
	if (number > 0 && number <= 7)
	{
		return true;
	}
	Console.WriteLine("Это не день недели!");
	return false;
}

int weekDay = Prompt("Введите день недели >"); 
if (ValidateWeekday(weekDay))
{
	if (IsWeekend(weekDay))
	{
		Console.WriteLine("Наконец-то выходной");
	}
	else
	{
		Console.WriteLine("Придется поработать");
	}
}    


