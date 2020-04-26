﻿using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> numbers = new Dictionary<string, int>(){
				{ "ноль", 0 }, { "один", 1 }, { "одна", 1 }, { "два", 2 }, { "две", 2 }, { "три", 3 }, { "четыре", 4 }, { "пять", 5 }, { "шесть", 6 }, { "семь", 7 }, { "восемь", 8 }, { "девять", 9 },
				{ "десять", 10 }, { "одинадцать", 11 }, { "двенадцать", 12 }, { "тринадцать", 13 }, { "четырнадцать", 14 }, { "пятнадцать", 15 },{ "шестнадцать", 16 }, { "семнадцать", 17 },
				{ "восемнадцать", 18 }, { "девятнадцать", 19 }, { "двадцать", 20 }, { "тридцать", 30 }, { "сорок", 40 }, { "пятьдесят", 50 }, { "шестьдесят", 60 }, { "семдесят", 70 },
				{ "восемьдесят", 80 },{ "девяносто", 90 }, { "сто", 100 }, { "двесте", 200 }, { "триста", 300 }, { "четыреста", 400 }, { "пятьсот", 500 },{ "шесть сот", 600 }, { "семьсот", 700 },
				{ "восемьсот", 800 }, { "девятьсот", 900 }, { "тысяч", 1000 }, { "тысяча", 1000 }, { "тысячи", 1000 }, { "миллион", 1000000 }, { "миллиона", 1000000 }, { "миллионов", 1000000 },
				{ "миллиард", 1000000000 }, { "миллиарда", 1000000000 }, { "миллиардов", 1000000000 }
			};

			long getNumber(string str)
			{
				string[] strlist = str.Split(' ');
				List<string> arr = new List<string>();
				long sum = 0;
				long sum1 = 0;

				for (int i = 0; i < strlist.Length; i++)
				{
					arr.Add(strlist[i]);
					if (!(arr[i].Contains("милли") || arr[i].Contains("тысяч")))
					{
						sum += numbers[arr[i]];
					}
					else
					{
						sum *= numbers[arr[i]];
						sum1 += sum;
						sum = 0;
					}
				}
				sum1 += sum;
				return sum1;
			}
			string b = "пять миллиардов сто двадцать один миллион четыреста пятьдесят одна тысяча два";
			Console.WriteLine(getNumber(b));
		}
	}
}