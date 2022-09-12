// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("введите последовательность чисел через пробел");

string[] str = Console.ReadLine().Split(' ');

int[] arr = new int[str.Length];

for (int i = 0; i < str.Length; i++)
    {
        arr[i] = Int32.Parse(str[i]);        
    }

int count = 0;

for (int i = 0; i < str.Length; i++)
    {
        if (arr[i] > 0)
            {
                count = count + 1;
            }
    
    }

Console.WriteLine($"количество чисел больше 0 равно {count}");
