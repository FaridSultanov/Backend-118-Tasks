using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculator with else id
            //double v1, v2;
            //char oprtr;
            //Console.Write("Enter first number: ");
            //v1=Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter second number :");
            //v2= Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter operator :");
            //oprtr=char.Parse(Console.ReadLine());
            //if(oprtr=='+')
            //{
            //    Console.WriteLine(v1+v2);
            //}
            //else if(oprtr=='-')
            //{
            //    Console.WriteLine(v1-v2);
            //}
            //else if(oprtr=='*')
            //{
            //    Console.WriteLine(v1*v2);
            //}
            //else if(oprtr=='/')
            //{
            //    Console.WriteLine(v1/v2);
            //}
            //else
            //{
            //    Console.WriteLine("Enter correct operator");
            //}

            #endregion

            #region Calculator with switch case
            //double a, b;
            //char val;
            //Console.Write("Enter first number :");
            //a=double.Parse(Console.ReadLine());
            //Console.Write("Enter second number : ");
            //b=double.Parse(Console.ReadLine());
            //Console.Write("Enter operator : ");
            //val=char.Parse(Console.ReadLine());
            //switch (val)
            //{
            //    case '+':
            //        Console.WriteLine(a+b);
            //        break;
            //    case '-':
            //        Console.WriteLine(a-b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a*b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a/b);
            //        break;

            //    default:
            //        Console.WriteLine("Enter true operator !");
            //        break;
            //}
            #endregion

            #region Grade Calculator
            //double grade;
            //Console.Write("Enter your exam grade: ");
            //grade= Convert.ToDouble(Console.ReadLine());
            //if(grade >=0 && grade<=100)
            //{
            //    switch (grade)
            //    {
            //        case double ele when (ele > 90.5 && ele <= 100):
            //            Console.WriteLine("A");
            //            break;
            //        case double ele when ele > 80.5 && ele <= 90:
            //            Console.WriteLine("B");
            //            break;
            //        case double ele when ele > 70.5 && ele <= 80:
            //            Console.WriteLine("C");
            //            break;
            //        case double ele when ele > 60.5 && ele <= 70:
            //            Console.WriteLine("D");
            //            break;
            //        case double ele when ele > 50.5 && ele <= 60:
            //            Console.WriteLine("E");
            //            break;

            //        default:
            //            Console.WriteLine("F ( You are failed ! )");
            //            break;
            //    }
                
            //}

            //else
            //{
            //    Console.WriteLine("Enter true grade.This is wrong !");
            //}


            #endregion
        }
    }
}
