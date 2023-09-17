Console.Write("Введите число ");
int num_abs = Math.abs(int.Parse(Console.ReadLine()));

if (num_abs < 100) {
    Console.WriteLine("У числа отсутствует третий разряд");
} else {
    while (num_abs >= 1000) {
        num_abs /= 10;
    }
    Console.WriteLine("Цифра в третьем разряде: {0}", num_abs % 10);
}
