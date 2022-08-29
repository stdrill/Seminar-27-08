// Сумма чисел от 1 до А

Console.WriteLine("Введите число А: ");
int a = Convert.ToInt32(Console.ReadLine() ?? "0");
while (a < 0){
    Console.WriteLine("Введите положительное число А");
    a = Convert.ToInt32(Console.ReadLine() ?? "0");
}
int i = 1;
int sum = 0;
while (i <= a){
    sum += i;
    i += 1;
}
Console.WriteLine($"{sum}");