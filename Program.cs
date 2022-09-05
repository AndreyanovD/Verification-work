//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. 

void NewArray()
{
    Console.Write("Введите размер массива: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i] = Console.ReadLine();
    }

    /*Это метод ввода массива не через консоль.
    string[] array = { "sdaesdfgh", "a4", "hello", "3", "computer", "Moscow", "-1", ":-)" };
    int size = array.Length;*/

    string[] newArray = new string[size];
    int newArraySize = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i].Length < 4)
        {
            newArray[newArraySize] = array[i];
            newArraySize++;
        }
    }
    if (newArraySize == 0)
    {
        Console.WriteLine("В введённом массиве все строки содержат больше трёх символов.");
    }
    else
    {
        Console.WriteLine("Новый массив: ");
        for (int i = 0; i < newArraySize; i++)
        {
            Console.WriteLine(newArray[i]);
        }
    }
}

NewArray();