int[] array_gen(int size) {
    int[] array = new int[size];

    Random random = new Random();
    for (int i = 0; i < size; i++) {
        array[i] = random.Next(int.MinValue, int.MaxValue);
    }

    return array;
}

void array_print(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        Console.Write($"{array[i]} ");
    }
}

array_print(array_gen(8));