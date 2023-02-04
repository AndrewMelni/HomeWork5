/*Задача 36: Задайте одномерный массив, заполненный 
случайными числами. Найдите сумму элементов, стоящих 
на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0*/


int n = new Random().Next(1,10);
int [] mass = new int[n];

void NewMass (int [] mass)
{
        for (int i = 0; i < mass.Length; i++)
    {
        mass [i] = new Random().Next(0,1000);
        Console.Write("{0} ", mass [i]);
    }
}
NewMass(mass);
Console.WriteLine();

int SumOddPos(int [] mass)
{
    int result = 0;
        
    for (int i = 1; i < mass.Length; i = i + 2)
    { 
        result = result + mass [i];
    }
    return result;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {SumOddPos(mass)}");