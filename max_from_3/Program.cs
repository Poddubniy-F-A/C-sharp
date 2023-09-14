Console.WriteLine("Введите три числа");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a == b && b == c) {
    Console.WriteLine("Все три числа равны");
} else {
    Console.WriteLine("Наибольшее число - {0}", Math.Max(Math.Max(a, b), c));
}
