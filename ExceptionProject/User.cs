using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionProject
{
    public class FractionException : Exception
    {
        public int Code { get; }
        public FractionException(string message, int code) : base(message) 
        {
            Code = code;
        }
    }
    public class Fraction
    {
        public int Numerator { set; get; }
        
        int denominator;
        public int Denominator
        {
            set
            {
                if (value != 0)
                    denominator = value;
                else
                    throw new FractionException("Denominator not null!", 200);
            }
            get => denominator;
        }
            
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            if (denominator != 0)
                Denominator = denominator;
            else
                throw new FractionException("Denominator not null!", 100);
        }
    }

    public class User
    {
        int age;
        public int Age { 
            set
            {
                if (value < 0 || value > 100)
                    throw new Exception("Age bad value");
                else
                    age = value;
            }
            get => age;
        }
    }
}
