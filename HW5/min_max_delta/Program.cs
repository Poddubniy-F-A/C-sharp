double MAX = Math.Pow(10, 2);

double[] array_gen(int size) {
    double[] array = new double[size];

    Random random = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = random.NextDouble() * MAX;
    }

    return array;
}

void array_print(double[] array) {
    Console.Write($"Массив:");
    for (int i = 0; i < array.Length; i++) {
        Console.Write(" {0:0.###}", array[i]);
    }
}

double min_max_delta(double[] array) {
    double min = array[0], max = array[0];
    for (int i = 1; i < array.Length; i++) {
        min = Math.Min(min, array[i]);
        max = Math.Max(max, array[i]);
    }
    return max - min;
}

Console.Write("Введите желаемую длину массива ");
double[] array = array_gen(int.Parse(Console.ReadLine()));

array_print(array);
Console.Write($"\nРазница между максимальным и минимальным элементом: {min_max_delta(array)}");