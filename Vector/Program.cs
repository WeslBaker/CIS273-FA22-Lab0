// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Vector.Vector v1 = new Vector.Vector();
v1.X = 4;
v1.Y = 3;

Vector.Vector v2 = new Vector.Vector();
v2.X = 2;
v2.Y = 5;

Vector.Vector result = v1.Add(v2);

result = v1 + v2;
Console.WriteLine(result);