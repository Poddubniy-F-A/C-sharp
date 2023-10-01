int[] ConvertStringToIntArray(string str) {
    string[] strArray = str.Split(" ");
    int length = strArray.Length;

    int[] intArray = new int[length];
    for (int i = 0; i < length; i++) {
        intArray[i] = int.Parse(strArray[i]);
    }
    return intArray;
}

void PrintInterval(int m, int n) {
    if (m <= n) {
        Console.Write($" {m}");
        PrintInterval(m + 1, n);
    }
}

Console.Write("Введите границы промежутка (2 числа) ");
int[] borders = ConvertStringToIntArray(Console.ReadLine());

Console.Write($"Числа на промежутке [{borders[0]}, {borders[1]}]:");
PrintInterval(borders[0], borders[1]);