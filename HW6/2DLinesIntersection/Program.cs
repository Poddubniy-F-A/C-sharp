int LINES_NUM = 2;
int DIMENSION = 2;

double[] ConvertStringToDoubleArray(string str) {
    string[] strArray = str.Split(" ");
    int length = strArray.Length;

    double[] doubleArray = new double[length];
    for (int i = 0; i < length; i++) {
        doubleArray[i] = double.Parse(strArray[i]);
    }
    return doubleArray;
}

void Print2DLineEquation(double[] lineEquation) {
    Console.Write("y = {0, 0:0.###}x + {1, 0:0.###}", lineEquation[0], lineEquation[1]);
}

void Print2DLinesIntersection(double[] lineEquation1, double[] lineEquation2) {
    Console.Write("Прямые ");
    Print2DLineEquation(lineEquation1);
    Console.Write(" и ");
    Print2DLineEquation(lineEquation2);

    if (lineEquation1[0] == lineEquation2[0]) {
        if (lineEquation1[1] == lineEquation2[1]) {
            Console.Write(" совпадают");
        } else {
            Console.Write(" параллельны");
        }
    } else {
        double x = (lineEquation2[1] - lineEquation1[1]) / (lineEquation1[0] - lineEquation2[0]);
        Console.Write(" пересекаются в точке ({0, 0:0.###}, {1, 0:0.###})", x, lineEquation1[0] * x + lineEquation1[1]);
    }
}

Console.Write($"Введите {LINES_NUM * DIMENSION} числа ");
double[] values = ConvertStringToDoubleArray(Console.ReadLine());
double[][] lineEquations = new double[LINES_NUM][];
for (int i = 0; i < LINES_NUM; i++) {
    lineEquations[i] = new double[DIMENSION];
    Array.Copy(values, DIMENSION * i, lineEquations[i], 0, DIMENSION);
}

Print2DLinesIntersection(lineEquations[0], lineEquations[1]);