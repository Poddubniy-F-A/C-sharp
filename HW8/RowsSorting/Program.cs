const int MAX = 100;

int[,] GenArray(int size) {
    int[,] array = new int[size, size];

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

void SortRows(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1) - 1; j++) {
            for (int k = j + 1; k < array.GetLength(1); k++) {
                if (array[i,j] < array[i,k]) {
                    array[i,j] += array[i,k];
                    array[i,k] = array[i,j] - array[i,k];
                    array[i,j] -= array[i,k];
                }
            }
        }
    }
}

Console.Write("Введите желаемый размер массива (1 число) ");
int[,] array = GenArray(int.Parse(Console.ReadLine()));

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);

SortRows(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(array);