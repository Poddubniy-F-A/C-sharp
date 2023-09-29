int exponentiation(int number, int degree) {
    if (degree < 0) {
        Console.WriteLine("Ошибка ввода");
        return -1;
    } else {
        int result = 1;
        while (degree > 0) {
            result *= number;
            degree--;
        }

        return result;
    }
}

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите неотрицальный показатель степени ");
int degree = int.Parse(Console.ReadLine());

Console.WriteLine($"Результат возведения в степень: {exponentiation(num, degree)}");