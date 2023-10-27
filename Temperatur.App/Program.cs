
using Temperatur.Core.Models;

Console.WriteLine("Input degree in kelvins");
double.TryParse(Console.ReadLine(), out double degree);
Kelvin kelvin = new Kelvin(degree);
Celsius celsius = kelvin;
Console.WriteLine(celsius.Degree+"C");