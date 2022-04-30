// задача 3
// заданы 2 массива. массив data и массив info.
// в массиве info хранятся двоичные представления нескольких чисел (без разделителя)
// в массиве data хранится информация о количестве бит, которые занимают числа из массива info.
// напишите программу, которая составит массив десятичных представлении чисел массива data
// с учетом информации из массива info
/*
Пример:

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }

выходные данные:
1, 7, 0, 1
*/


int[] dataArray = {0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] infoArray = {2, 3, 3, 1 };

int[] ResultArrayFunction (int[] data, int[] info)
{
    int [] resultArray = new int [info.Length];
    int dataIndex = 0;
    for (int infoIndex = 0; infoIndex < info.Length; infoIndex++)
    {
        int result = 0;
        int count = 0;
        for (int i = info[infoIndex]-1; i >= 0; i--)
        {
            result = result + data[dataIndex + i] * (int)Math.Pow(2, count);
            count++;
        }
        dataIndex = dataIndex + info[infoIndex];
        resultArray[infoIndex] = result;
    }
    return resultArray;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

PrintArray(ResultArrayFunction(dataArray, infoArray));
