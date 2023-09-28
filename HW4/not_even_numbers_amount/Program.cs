int MAX = (int) Math.Pow(10, 2);

int[] array_gen(int size) {
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = random.Next(0, MAX);
    }

    return array;
}

void array_print(int[] array) {
    Console.Write($"Массив:");
    for (int i = 0; i < array.Length; i++) {
        Console.Write($" {array[i]}");
    }
}

int not_even_numbers_amount(int[] array) {
    int result = 0;
    for (int i = 1; i < array.Length; i += 2) {
        result += array[i];
    }
    return result;
}

Console.Write("Введите желаемую длину массива ");
int[] array = array_gen(int.Parse(Console.ReadLine()));

array_print(array);
Console.Write($"\nСумма чисел на нечётных позициях: {not_even_numbers_amount(array)}");