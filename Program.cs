/*Итоговая проверочная работа.
Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения
на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.
Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1.Создать репозиторий на GitHub
2.Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3.Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4.Написать программу, решающую поставленную задачу
5.Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как 
минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)
Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется 
пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
['hello", "2", "world", ":-)"] -> ["2", "-)"]
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []*/

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

int SizeModifiedArray(string[] array, int lengthLines)
{
int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthLines)
            count++;
    }
    return count;
}

string[] ModifiedArray(string[] array, int lengthArrayTwo, int size)
{
    string[] newArray = new string[size];
    int i = 0;
    int j = 0;
    while (j < array.Length)
        if (array[j].Length <= lengthArrayTwo)
        {
            newArray[i] = array[j];
            i++;
            j++;
        }
        else
        {
            j++;
        }
    return newArray;
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
string[] array = new string[arrayLength];
for (int i = 0; i < arrayLength; i++)
{
    Console.Write($"Введите значение {i} элемента: ");
    string element = Console.ReadLine()!;
    array[i] = element;
}
int lengthArrayTwo = 3;
int sizeModifiedArray = SizeModifiedArray(array, lengthArrayTwo);
string[] ArrayTwo = ModifiedArray(array, lengthArrayTwo, sizeModifiedArray);
PrintArray(array);
Console.Write(" -> ");
PrintArray(ArrayTwo);