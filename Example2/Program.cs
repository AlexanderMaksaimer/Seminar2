// See https://aka.ms/new-console-template for more information
int number = new Random ().Next(100,1000);
string strr = number.ToString();

Console.WriteLine($"{number} -> {strr[0]}{strr[2]}");
