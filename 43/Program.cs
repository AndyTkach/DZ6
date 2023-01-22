// Задача 43

Console.Write("Введите b1: ");
var k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k1: ");
var b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите b2: ");
var k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите k2: ");
var b2 = Convert.ToDouble(Console.ReadLine());
 
 
var x = -(k1 - k2) / (b1 - b2);
var y = b1 * x + k1;
 
x = Math.Round(x, 3);
y = Math.Round(y, 3);
 
Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> ({x};{y})");

