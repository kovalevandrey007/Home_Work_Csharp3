/* Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/


Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
char[] revtext = NumberText.ToCharArray();
Array.Reverse(revtext);
string finaltext = new string(revtext);
            if (NumberText == finaltext)
            {
                Console.WriteLine("да");
            }
            else
            {
                Console.WriteLine("нет");
            }