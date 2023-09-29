int[] ConvertStringToIntArray(string str) {
    string[] strArray = str.Split(", ");
    int length = strArray.Length;

    int[] intArray = new int[length];
    for (int i = 0; i < length; i++) {
        intArray[i] = int.Parse(strArray[i]);
    }
    return intArray;
}

int PositiveNumbersNum(int[] array) {
    int result = 0;
    for (int i = 0; i < array.Length; i++) {
        if (array[i] > 0) {
            result++;
        }
    }
    return result;
}

Console.Write("Введите несколько чисел через запятую ");
int[] array = ConvertStringToIntArray(Console.ReadLine());

Console.Write($"Количество положительных чисел: {PositiveNumbersNum(array)}");