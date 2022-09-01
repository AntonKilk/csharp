/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */
Console.WriteLine("Find maximum function");
Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Maximum is:");
Console.WriteLine(num1 > num2 ? num1 : num2);

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */

Console.WriteLine("Find maximum from 3");
Console.WriteLine("Enter first number");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Maximum is:");
int max = a;
if (a < b)
{
	max = b;
	if (b < c)
		max = c;
}
else if (a < c)
{
	max = c;
}
Console.WriteLine(max);

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

Console.WriteLine("Check if even");
Console.WriteLine("Enter number");
int even = Convert.ToInt32(Console.ReadLine());
if (even % 2 == 0)
{
	Console.WriteLine("YES");
}
else
	Console.WriteLine("NO");

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. */

Console.WriteLine("Write all even numbers till given");
Console.WriteLine("Enter number");
int given = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Answer is:");
for (int i = 1; i <= given; i++)
{
	if (i % 2 == 0)
		Console.WriteLine(i);
}
