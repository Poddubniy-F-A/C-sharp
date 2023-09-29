int numbers_amount(int number) {
    int amount = 0;
    while(number > 0) {
        amount += number % 10;
        number /= 10;
    }

    return amount;
}

Console.Write("Введите число ");
int num = Math.Abs(int.Parse(Console.ReadLine()));

Console.WriteLine($"Сумма цифр: {numbers_amount(num)}");