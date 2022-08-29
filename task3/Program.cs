// Определить количество цифр в числе

int Quantity(int number)
{
    int i = 0;
    while (number > 0){
        number = number / 10;
        i++;
    }
    return i;
}
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Quantity(a)}");
