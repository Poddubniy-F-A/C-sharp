Console.WriteLine("Введите пару чисел");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a == b) {
    Console.WriteLine("Числа равны");
} else {
    Console.WriteLine("{0} - больше, {1} - меньше", Math.Max(a, b), Math.Min(a, b));
}
