// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void FillStringArray(int n)
{
    string[] array1 = new string[n];

    for (int i = 0; i < n; i++)
    {
        array1[i] = Console.ReadLine();
    }

    int c1 = 0;

    for (int i = 0; i < n; i++)
    {
        int s = array1[i].Length;
        if (s <= 3)
        {
            c1++;
        }
    }

    string[] array2 = new string[c1];
    int c2 = 0;
    for (int i = 0; i < n; i++)
    {


        if (array1[i].Length <= 3)
        {
            array2[c2] = array1[i];
            c2++;
        }

    }

    Console.WriteLine();

    if (c2 != 1)
    {
        Console.Write("[" + array2[0] + ", ");

        for (int i = 1; i < c2 - 1; i++)
        {
            Console.Write(array2[i] + ", ");
        }


        Console.Write(array2[c2 - 1] + "]");
        Console.WriteLine();
    }

    else
    {
        Console.Write("[" + array2[0] + "]");
        Console.WriteLine();
    }

}


FillStringArray(5);
