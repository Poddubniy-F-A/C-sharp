const int MAX = 10;

int[] ConvertStringToIntArray(string str) {
    string[] strArray = str.Split(" ");
    int length = strArray.Length;

    int[] intArray = new int[length];
    for (int i = 0; i < length; i++) {
        intArray[i] = int.Parse(strArray[i]);
    }
    return intArray;
}

int[,] GenArray(int[] size) {
    int[,] array = new int[size[0], size[1]];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            array[i,j] = random.Next(0, MAX);
        }
    }

    return array;
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int FindMinRow(int[,] array) {
    int maxAmount = array.GetLength(1) * MAX;
    int index = 0;

    for (int i = 0; i < array.GetLength(0); i++) {
        int amount = 0;

        for (int j = 0; j < array.GetLength(1); j++) {
            amount += array[i,j];
        }

        if (amount < maxAmount) {
            maxAmount = amount;
            index = i;
        }
    }

    return index;
}

Console.Write("Введите желаемый размер массива (2 числа) ");
int[,] array = GenArray(ConvertStringToIntArray(Console.ReadLine()));

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {FindMinRow(array) + 1}");