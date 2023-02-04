/*Задача 34: Задайте массив заполненный случайными 
положительными трёхзначными числами. Напишите программу, 
которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

int n = new Random().Next(1,10);
int [] mass = new int[n];

void NewMass (int [] mass)
{
        for (int i = 0; i < mass.Length; i++)
    {
        mass [i] = new Random().Next(100,1000);
        Console.Write("{0} ", mass [i]);
    }
}
NewMass(mass);
Console.WriteLine();

int EvenNumbs(int [] mass)
{
    int result = 0;
    
    foreach (int i in mass)
    { 
        if (i % 2 == 0) 
        result++;;
    }
    return result;
}

Console.WriteLine($"Количество чётных чисел в массиве: {EvenNumbs(mass)}");