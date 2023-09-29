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

int even_numbers_num(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            result++;
        }
    }
    return result;
}

Console.Write("Введите желаемую длину массива ");
int[] array = array_gen(int.Parse(Console.ReadLine()));

array_print(array);
Console.Write($"\nКоличество чётных чисел в массиве: {even_numbers_num(array)}");