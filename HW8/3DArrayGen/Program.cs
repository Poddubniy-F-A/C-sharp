const int NUMS_LENGTH = 2;
int MIN_NUM = (int) Math.Pow(10, NUMS_LENGTH - 1);

int[,,] GenUniqueArray(int size) {
    int[] list = new int[9 * MIN_NUM];
    for (int i = 0; i < list.Length; i++) {
        list[i] = MIN_NUM + i;
    }

    int[,,] array = new int[size, size, size];

    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                while (true) {
                    int index = random.Next(1, list.Length) - 1;
                    if (list[index] != 0) {
                        array[i,j,k] = list[index];
                        list[index] = 0;
                        break;
                    }
                }
            }
        }
    }

    return array;
}

void PrintArray(int[,,] array) {
    for (int i = 0; i < array.GetLength(0); i++) {
        for (int j = 0; j < array.GetLength(1); j++) {
            for (int k = 0; k < array.GetLength(2); k++) {
                Console.Write($"{array[i,j,k]}({i},{j},{k})\t");
            }
            Console.WriteLine();
        }
    }
}

Console.Write("Введите желаемый размер массива (1 число, не больше 4) ");
int[,,] array = GenUniqueArray(int.Parse(Console.ReadLine()));

Console.WriteLine("Сгенерированный массив:");
PrintArray(array);