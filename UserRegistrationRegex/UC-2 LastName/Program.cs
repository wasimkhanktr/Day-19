﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pattern = new Pattern();
            Console.WriteLine("Enter the LastName");
            string lastName = Console.ReadLine();
            pattern.validate(lastName);
        }
    }
}