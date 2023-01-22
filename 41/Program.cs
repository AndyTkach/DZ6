// Задание 41

Console.Write("Введите элементы: ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > 0)
    {
        count++;
    }
}

string mas= String.Concat<int>(arr);
 
Console.WriteLine($"{mas} -> {count}");