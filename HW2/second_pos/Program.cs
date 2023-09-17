Console.Write("Введите трёхзначное число ");
int num_abs = Math.Abs(int.Parse(Console.ReadLine()));

if (num_abs >= 1000 || num_abs < 100) {
    Console.WriteLine("Ошибка ввода");
} else {
    Console.WriteLine("Вторая цифра числа: {0}", (num_abs / 10) % 10);
}