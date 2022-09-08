// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Random rnd = new Random();

//неясен требуемый размер массива в задании. Задаю рандомом в диапазоне 4 - 15
int arr_leng = rnd.Next(4, 15);

int[] arr = new int[arr_leng];

for (int i = 0; i < arr.Length; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(-100,100);
    }

int sum = 0;

for (int i = 1; i < arr.Length; i = (i + 2))
    {
        sum = sum + arr[i];
    }

Console.WriteLine($"сумма элементов на нечетных позициях равна {sum}");