Console.Write("Введите порядковый номер дня недели (1-7) ");
int day_num = int.Parse(Console.ReadLine());

if (day_num < 1 || day_num > 7) {
    Console.WriteLine("Ошибка ввода");
} else if (day_num <= 5) {
    Console.WriteLine("Это будний день");
} else {
    Console.WriteLine("Это выходной");
}