int[] ConvertStringToIntArray(string str) {
    string[] strArray = str.Split(" ");
    int length = strArray.Length;

    int[] intArray = new int[length];
    for (int i = 0; i < length; i++) {
        intArray[i] = int.Parse(strArray[i]);
    }
    return intArray;
}

int GetIntervalSum(int curSum, int m, int n) {
    if (m <= n) {
        return GetIntervalSum(curSum + m, m + 1, n);
    } else {
        return curSum;
    }
}

Console.Write("Введите границы промежутка (2 числа) ");
int[] borders = ConvertStringToIntArray(Console.ReadLine());

Console.Write($"Сумма чисел на промежутке [{borders[0]}, {borders[1]}]: {GetIntervalSum(0, borders[0], borders[1])}");