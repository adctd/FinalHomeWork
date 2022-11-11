// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

using static System.Console;
Clear();
WriteLine("Введите любые данные через пробел: ");
string[] array=ReadLine().Split(" ");
string[] newArray=new string[SizeFinalArray(array, 3)];
FindNewArray(array, newArray, 3);
WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", newArray)}]");

//Функция, вычисляющая размер нового массива
int SizeFinalArray(string[] array, int n)
{
    int size = 0;
    for(int i = 0; i < array.Length; i++) 
    {
        if(array[i].Length <= n) 
        {
            size++;
        }
    }
    return size;
}

//Функция, задающая новый массив из старого с выборкой нужных по размеру элементов
void FindNewArray(string[] array1, string[] array2, int n)
{
    int j = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= n)
        {
        array2[j] = array1[i];
        j++;
        }
    }
}


