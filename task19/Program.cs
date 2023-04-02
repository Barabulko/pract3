// See https://aka.ms/new-console-template for more information
Console.WriteLine("task19");

/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да*/

bool checkPalindrome(int number)
{
    string tmp = (number.ToString());
    for (int i=0; i<tmp.Length; i++)
        {
            if (tmp[i]!=tmp[tmp.Length-i-1]) return false;
        }
    return true; 
}

Console.Write("input a number: ");
string input = Console.ReadLine();

int N = int.Parse(input);
Console.WriteLine($"result = {checkPalindrome(N)}");