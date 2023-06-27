// See https://aka.ms/new-console-template for more information
using ConsoleApp18;
using System;
using System.Numerics;
using Complex = ConsoleApp18.Complex;
//Миньков Владимир 22исп21 75 задание

Complex complex1 = new Complex(9, 3);
Complex complex2 = new Complex(4, -4);
Complex complex3 = (Complex)complex1.Add(complex2);
Console.WriteLine(complex3.ToString());
Complex complex4 = (Complex)complex1.Sub(complex2);
Console.WriteLine(complex4.ToString());
Complex complex5 = (Complex)complex1.Mult(complex2);
Console.WriteLine(complex5.ToString());
Complex complex6 = (Complex)complex1.Div(complex2);
Console.WriteLine(complex6.ToString());
Console.WriteLine(complex1.Equ(complex2));
Complex complex7 = (Complex)complex1.Conj();
Console.WriteLine(complex7.ToString());



Money money1 = new Money(100, 50); 
Money money2 = new Money(50, 80); 

pair_money result = money1.Add_money(money2); 
Console.WriteLine(result);

result = money1.Subtract(money2); 
Console.WriteLine(result);

result = money1.Multiply(1.5); 
Console.WriteLine(result);

result = money1.Divide(3); 
Console.WriteLine(result);

int comparisonResult = money1.CompareTo(money2);
Console.WriteLine(comparisonResult);
