Console.WriteLine("Введите верхнюю границу промежутка");

int N = int.Parse(Console.ReadLine());

Console.WriteLine("Чётные числа из промежутка 1-{0}:", N);
for (int num = 2; num <= N; num += 2) {
    Console.WriteLine(num);
}