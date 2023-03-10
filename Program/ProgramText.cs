// Задача: Написать программу, которая из имеющегося массива строк формирует массив строк, 
// длина которых меньше либо равнa 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// ___________ Тело программы ______________

int countChar = 3;                               // Количество символов, допустимых в строке нового массива
PrintData("Введите массив строк (через пробел):");
string str = ReadData();
string[] array = SelectiveExtraction(str.Split(' '));       // Формирование нового массива с ограничением по кол-ву символов через пробел
PrintData("Mассив строк, длина которых меньше либо равнa 3 символа:");
PrintArray(array);

// ___________ Группа методов ______________

// Метод читает данные от пользователя
string ReadData()
{
    return Console.ReadLine() ?? "0";
}

// Метод выводит данные на печать
void PrintData(string res)
{
    Console.WriteLine(res);
}

// Метод печатает массив
void PrintArray(string[] arr)
{
    Console.Write("[");
    if (arr.Any())
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.Write(arr[arr.Length - 1]);
    }
    Console.WriteLine("]");
}

// Метод добавляет строку в массив

//Метод AddToArray на вход получает массив и элемент, который необходимо добавить в этот массив, возвращает массив.

string[] AddToArray(string[] arr, string item)   //Метод AddToArray на вход получает массив и элемент, который необходимо добавить в этот массив, возвращает массив.
{
    if (arr.Length == 0) // Если исходный массив пуст, то создаем новый массив длиной 1, добавляем заданный элемент
    {
        return new string[] { item };
    }
    string[] arrResult = new string[arr.Length + 1]; //Создаем новый массив длиной на 1 больше, чем исходный
    arr.CopyTo(arrResult, 0); //Копируем в новый массив все элементы исходного массива
    arrResult[arr.Length] = item; //На последнюю позицию в новом массиве добавляем необходимый элемент
    return arrResult; //Возвращаем полученный массив
}

// Метод из имеющегося массива строк формирует массив строк, длина которых меньше либо равнa 3 символа.
string[] SelectiveExtraction(string[] arr)
{
    string[] arrNew = new string[0];

    for (int i = 0; i < arr.Length; i++)
    {
        if (string.IsNullOrEmpty(arr[i])) // Проверка, является ли значение нулевой или пустой
            continue;
        if (arr[i].Length - 1 < countChar) arrNew = AddToArray(arrNew, arr[i]); //Если длина подстроки < 3, добавляем данную подстроку в новый массив

    }
    return arrNew;
}

