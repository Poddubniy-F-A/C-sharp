int[] ConvertStringToIntArray(string str) {
    string[] strArray = str.Split(" ");
    int length = strArray.Length;

    int[] intArray = new int[length];
    for (int i = 0; i < length; i++) {
        intArray[i] = int.Parse(strArray[i]);
    }
    return intArray;
}

int AckermanFunc(int m, int n) {
    if (m == 0) {
        return n + 1;
    } else if (n == 0) {
        return AckermanFunc(m - 1, 1);
    } else {
        return AckermanFunc(m - 1, AckermanFunc(m, n - 1));
    }
}

Console.Write("Введите аргументы функции Аккермана (2 числа) ");
int[] arguments = ConvertStringToIntArray(Console.ReadLine());

Console.Write($"A({arguments[0]}, {arguments[1]}) = {AckermanFunc(arguments[0], arguments[1])}");