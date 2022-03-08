using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationRegex
{
    internal class Pattern
    {
        public string Email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public void validate(string email)
        {
            bool correct = Regex.IsMatch(email, Email);
            if (correct)
                Console.WriteLine("Email is correct");
            else
                Console.WriteLine("Email is not correct");
        }
    }
}