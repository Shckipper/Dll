using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLibrary;


namespace Dll
{
        class Program
        {
            static void Main(string[] args)
            {
                SimpleFunctions simpleFunctions = new SimpleFunctions();

                // Метод 1: Приветствие
                simpleFunctions.PrintGreeting();

                // Метод 2: Текст в рамке
                simpleFunctions.PrintBox("Hello, Simple Library!");

                // Метод 3: Счётчик слов 
                simpleFunctions.CountWordsFromUser();

                // Метод 4: Генерация случайной строки
                simpleFunctions.GenerateRandomString(10);

                // Метод 5: Переворот строки 
                simpleFunctions.ReverseUserString();
                Console.ReadKey();

            }
        }
}


