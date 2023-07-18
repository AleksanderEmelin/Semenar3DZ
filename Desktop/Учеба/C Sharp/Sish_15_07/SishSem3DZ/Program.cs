

 void Task19()
    {
        //Напишите программу, которая принимает на вход пятизнаяное число и проверяет, является ли оно палиндромом.

        int number = 15651;
        string numberStr = Convert.ToString(number);
        if (numberStr[0] == numberStr[4] && numberStr[1] == numberStr[3])
        {
           Console.WriteLine($"Число {number} палиндром");
        }
        else
        {
            Console.WriteLine($"Число {number} НЕ палиндром");
        }  
    }
 void Task21()
    {
        //Напишите программу, которая принимает на вход координаты двух точек и находит между ними растояние в 3D.
        int x1 = 1;
        int y1 = 2;
        int z1 = 3;

        int x2 = 5;
        int y2 = 6;
        int z2 = 7;

        double rezult = Math.Sqrt( Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2 - z1, 2)); 
        rezult = Math.Round(rezult, 3);
        Console.WriteLine(rezult);
    }
    void Task23()
    {
        //Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N.

        int number = 10;

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine($"{i} * {i} * {i} = {Math.Pow(i, 3)}");
        }
    }
    


