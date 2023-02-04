/*Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным 
элементов массива.

[3 7 22 2 78] -> 76*/

int n = new Random().Next(1,10);
int [] mass = new int[n];

void NewMass (int [] mass)
{
        for (int i = 0; i < mass.Length; i++)
    {
        mass [i] = new Random().Next(0,100);
        Console.Write("{0} ", mass [i]);
    }
}
NewMass(mass);
Console.WriteLine();

int MaxDifference(int [] mass)
{
    int result = 0;
    int max = mass [0];
    int min = mass [0];
        
    for (int i = 0; i < mass.Length; i++)
    { 
        if (mass [i] > max)
        {
            max = mass [i];
        }
        if (mass [i] < min)
        {
            min = mass [i];
        }
        result = max - min;
    }
    return result;
}

Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {MaxDifference(mass)}");