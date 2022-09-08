// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Random rnd = new Random();

//неясен требуемый размер массива в задании. Задаю рандомом в диапазоне 4 - 15
int arr_leng = rnd.Next(4, 15);

int[] arr = new int[arr_leng];

for (int i = 0; i < arr.Length; i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(-100,100);
    }

Array.Sort(arr, (x, y) => x.CompareTo(y)); 

int diff = arr[arr.Length-1] - arr[0];

Console.WriteLine($"разница между минимальным ({arr[0]}) и максимальным ({arr[arr.Length-1]}) элементами массива равна {diff}");



