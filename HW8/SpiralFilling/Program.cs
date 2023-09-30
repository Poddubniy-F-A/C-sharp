const int SIZE = 4;
const int LAST_INDEX = SIZE - 1;

void FillSpirally(int[,] array) {
    int value = 1;

    for (int shift = 0; shift < SIZE / 2; shift++) {
        for (int i = shift; i < LAST_INDEX - shift; i++) {
            array[shift, i] = value++;
        }
        for (int i = shift; i < LAST_INDEX - shift; i++) {
            array[i, LAST_INDEX - shift] = value++;
        }
        for (int i = LAST_INDEX - shift; i > shift; i--) {
            array[LAST_INDEX - shift, i] = value++;
        }
        for (int i = LAST_INDEX - shift; i > shift; i--) {
            array[i, shift] = value++;
        }
    }

    if (SIZE % 2 == 1) {
        array[SIZE / 2, SIZE / 2] = value;
    }
}

void PrintArray(int[,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            Console.Write($"{array[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] array = new int[SIZE,SIZE];
FillSpirally(array);
Console.WriteLine("Сгенерированный массив:");
PrintArray(array);