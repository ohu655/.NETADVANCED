﻿using System;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var list = new RandomList();
            list.Add("1");
            list.Add("2");
            list.Add("3");
            list.Add("4");
            list.Add("5");
            list.Add("6");
            list.Add("7");
            list.Add("8");
            list.Add("9");

            Console.WriteLine(list.RandomString());

        }
    }
}
