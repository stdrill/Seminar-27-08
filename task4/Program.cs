// Задать и вывести массив из 8 элементов

void PrintArray(int[] array){
    foreach(var element in array)
        Console.Write($"{element} ");
}
Console.WriteLine("Enter array ");
string[] strings = Console.ReadLine()?.Split(' ');
int[] array = new int[strings.Length];
for(int i=0;i<array.Length;i++){
    array[i] = int.Parse(strings[i]);
}
Console.Write("Your array ");
PrintArray(array);