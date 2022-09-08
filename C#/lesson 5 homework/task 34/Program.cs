// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Random rnd = new Random();

//неясен требуемый размер массива в задании. Задаю рандомом в диапазоне 4 - 15
int arr_leng = rnd.Next(4, 15);

int[] arr = new int[arr_leng];

for (int i = 0; i < arr.Length; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(100,999);
    }

int count = 0;

for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        count++;
    }
Console.WriteLine($"количество четных числе равно {count}");


