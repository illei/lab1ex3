﻿using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care va afisa ultima cifra a unui numar intreg citit de la
            tastaura*/
            int i;
            i = int.Parse(Console.ReadLine());
            int lastdigit = i % 10;
            Console.WriteLine(lastdigit);
        }
    }
}
