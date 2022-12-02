// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] CreatNewArray(string[] array)
{
    string[] newarray = new string[array.Length];
    int s = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) newarray[s] = array[i];
        s++;
    }
    return newarray;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}