// See https://aka.ms/new-console-template for more information
using LiskovSubstution;


Console.WriteLine("Hello, World!");
/*
 * Bir base class ile derived class; birbirleriyle (herhangi bir özel kod yazmadan) yer değiştirebilir olmalı.
 * 
 * Derived class, base class'ın davranışlarını değiştiremez!
 * 
 * Bu prensip; doğru inheritance ilişkisi kurmanız içindir.
 */

Rectangle rectangle = new Rectangle() { Width = 5, Height = 10 };
//Square square = new Square { Width = 10 };

//var rect = GeometryFactory.CreateRectangle();
//rect.Width = 10;
//rect.Height = 6;
//Console.WriteLine(rect.GetArea());

var square = GeometryFactory.CreateRectangle(30);
Console.WriteLine(square.GetArea());


