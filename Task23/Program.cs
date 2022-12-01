/*Напишите программу, которая принимает на вход 
число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125*/
int number = 
string Recursion(int number)
{
    if(number == 1)
       return number.ToString();
return Recursion(number - 1) + number; 
}
Console.WriteLine(Recursion());


