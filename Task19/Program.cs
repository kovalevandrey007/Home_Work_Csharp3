/* Напишите программу, которая принимает на 
вход пятизначное число и проверяет, является ли оно 
палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
/*
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
{
    int result = 0;
    bool isCorrect = false;


    while(!isCorrect)
    {
        Console.WriteLine("number");
              for (int i=0; i<10; i++)
              for (int j=10; j<10; j--)
        if(int.TryParse(Console.ReadLine(), out result) && i=j)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("нет");
        }
    }

    return result;
}*/
//int number = GetNumber("введите число: " );
/*int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
/*
double sum1 = Math.Pow((x2 - x1), 2);
double sum2 = Math.Pow((y2 - y1), 2);
double sum3 = Math.Pow((z2 - z1), 2);

double result = Math.Sqrt(sum1 + sum2 + sum3);*/

//Console.WriteLine(result);

int n = int.Parse(Console.ReadLine());
            string str;
            bool result = true;
            for (int i >=0; i <= j; i++)
            {
                if (i < j)
                {
                    result = true;
                    str = Convert.ToString(i);
                    for (int j = 0; j < str.Length / 2; j++) 
                         if (str[j] != str[str.Length - 1 - j] && result) result = false; 
                         if (result) Console.WriteLine($"да {i}");
                        else
                         {
                        Console.WriteLine("нет");
                        }
                 }
            }