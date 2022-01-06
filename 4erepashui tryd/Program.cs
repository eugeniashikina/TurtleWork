//Zadanie1();
//DopZadanie();
//Calculate();
//Cycles();
Stroka();

/// <summary>
/// Проверка на совпадение типов данных
/// </summary>
void Zadanie1()
{
    var a = Console.ReadLine();
    var b = Console.ReadLine();

    object result = "";
    object result2 = "";

    /// <summary>
    /// Определение типа первой переменной (а)
    /// </summary>
    if (bool.TryParse(a, out bool r))
    {
        result = r;
        Console.WriteLine("Тип данных: bool");
    }

    else if (int.TryParse(a, out int e))
    {
        result = e;
        Console.WriteLine("Тип данных: int");
    }
    else if (double.TryParse(a.Replace('.', ','), out double c))
    {
        result = c;
        Console.WriteLine("Тип данных: double");
    }
    else if (Char.TryParse(a, out char k))
    {
        result = k;
        Console.WriteLine("Тип данных: char");
    }
    else if (a is string)
    {
        result = Convert.ToString(a);
        Console.WriteLine("Тип данных: string");
    }

    /// <summary>
    /// Определение типа второй переменной (b)
    /// </summary>
    if (bool.TryParse(b, out bool q))
    {
        result2 = q;
        Console.WriteLine("Тип данных: bool");
    }

    else if (int.TryParse(b, out int w))
    {
        result2 = w;
        Console.WriteLine("Тип данных: int");
    }
    else if (double.TryParse(b.Replace('.', ','), out double t))
    {
        result2 = t;
        Console.WriteLine("Тип данных: double");
    }
    else if (Char.TryParse(b, out char p))
    {
        result2 = p;
        Console.WriteLine("Тип данных: char");
    }
    else if (b is string)
    {
        result2 = Convert.ToString(b);
        Console.WriteLine("Тип данных: string");
    }

    /// <summary>
    /// Сверяет типы данных переменных (a и b)
    /// </summary>
    if (result.GetType() == result2.GetType())
    {
        Console.WriteLine("Типы данных совпадают");
    }
    else Console.WriteLine("Типы данных разные");
}


/// <summary>
/// Конвертирование данных по типам
/// </summary>
void DopZadanie()
{
    Console.WriteLine("Возможные типы конвертации данных:");
    var type = new List<string> { "1. ToBoolen", "2. ToDouble", "3. ToString", "4. ToInt", "5. ToChar" };
    foreach (var type2 in type)
    {
        Console.WriteLine(type2);
    }
    Console.WriteLine("Введите переменную");
    var b = Console.ReadLine();
    int[] a = new int[5];
    a[0] = 1;
    a[1] = 2;
    a[2] = 3;
    a[3] = 4;
    a[4] = 5;
    if (a[0] == 1)
    {
        try
        {
            Convert.ToBoolean(b);
            Console.WriteLine("Успешно конвертировано");
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
    if (a[1] == 2)
    {
        try
        {
            Convert.ToDouble(b.Replace('.', ','));
            Console.WriteLine("Успешно конвертировано");
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
    if (a[2] == 3)
    {
        try
        {
            Convert.ToString(b);
            Console.WriteLine("Успешно конвертировано");
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
    if (a[3] == 4)
    {
        try
        {
            Convert.ToInt32(b);
            Console.WriteLine("Успешно конвертировано");
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
    if (a[4] == 5)
    {
        try
        {
            Convert.ToChar(b);
            Console.WriteLine("Успешно конвертировано");
        }
        catch
        {
            Console.WriteLine("Ошибка");
        }
    }
    Console.ReadKey();
}


/// <summary>
/// Калькулятор
/// </summary>
void Calculate()
{
    var choose = new List<string> { "1. Вычислить пример", "2. Возвести в степень", "3. Вычислить корень" };
    foreach (var type in choose)
        Console.WriteLine(type);
    Console.WriteLine("Выберите действие");
    int h = int.Parse(Console.ReadLine());
    if (h == 1)
    {
        Console.WriteLine("Введите первое число");
        var a = Console.ReadLine();
        Convert.ToDouble(a.Replace('.', ','));
        Console.WriteLine("Введите оператор");
        char znak = Convert.ToChar(Console.ReadLine());
        if (znak == '+' ^ znak == '-' ^ znak == '*' ^ znak == '/')
        {
            Console.WriteLine("Введите второе число");
            var b = Console.ReadLine();
            Convert.ToDouble(b.Replace('.', ','));
            Console.WriteLine("Результат вычислений:");

            if (znak == '+')
            {
                double c = Convert.ToDouble(a) + Convert.ToDouble(b);
                Console.WriteLine(c);
            }
            else if (znak == '-')
            {
                double с = Convert.ToDouble(a) - Convert.ToDouble(b);
                Console.Write(с);
            }
            else if (znak == '*')
            {
                double c = Convert.ToDouble(a) * Convert.ToDouble(b);
                Console.WriteLine(c);
            }
            else if (znak == '/')
            {
                double c = Convert.ToDouble(a) / Convert.ToDouble(b);
                Console.WriteLine(c);
            }
        }
        else
        {
            Console.WriteLine("Ошибка!");
        }
    }
    else if (h == 2)
    {
        Console.WriteLine("Введите переменную");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите степень");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Результат вычислений:");
        double c = Math.Pow(a, b);
        Console.WriteLine(c);
    }
    else if (h == 3)
    {
        Console.WriteLine("Введите переменную");
        double a = double.Parse(Console.ReadLine());
        double b = Math.Sqrt(a);
        Console.WriteLine(b);
    }
    Console.ReadKey();
}

/// <summary>
/// Работа с циклами
/// </summary>
void Cycles()
{
    int[] mas = new int[11] { 2, 3, 4, 7, 12, -8, 0, 1, -3, 10, 6 };
    for (int i = 0; i < mas.Length; i++)
        Console.Write(mas[i] + " ");
    int index = int.MinValue;
    foreach (var item in mas)
    {
        if (item > index)
        {
            index = item;
        }
        else continue;
    }
    Console.WriteLine("\n\r1. Самый большой элемент массива: " + index);

    Array.Reverse(mas);
    int k = 0;
    do
    {
        k++;
    }
    while (mas[k] != 0);
    Console.WriteLine("2. Найден ноль. Индекс элемента в массиве: " + (mas.Length - 1 - k));

    int sum = 0;
    int m = 0;
    while (m < mas.Length)
    {
        if (mas[m] > 0)
        {
            sum += mas[m];
        }
        m++;
    }
    Console.WriteLine("3. Сумма всех положительных чисел: " + sum);

    double count = 0;
    double summary = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i] % 2 == 0)
        {
            summary += mas[i];
            count++;
        }
    }
    double average = summary / count;
    Console.WriteLine("4. Среднее арифметическое всех четных чисел " + average);
    Console.ReadKey();
}

/// <summary>
/// Работа со строкой
/// </summary>
void Stroka()
{
    string s1 = "Привет, бобрёнок. Как твои дела?";
    Console.WriteLine(s1);

    Console.Write("\n\r" + "1. Метод Contains: ");
    string s2 = "бобрёнок";
    if (s1.Contains(s2))
        Console.WriteLine("<3 бобрёнка");
    else Console.WriteLine("Где бобрёнок?");

    Console.Write("2. Метод Indexof: ");
    string str = "бобрёнок";
    int Indexofstr = s1.IndexOf(str);
    Console.WriteLine(Indexofstr);

    Console.Write("3. Метод Concat: ");
    string s3 = "Расскажи, что у тебя нового?";
    string s4 = s1 + " " + s3;
    Console.WriteLine(s4);

    Console.Write("4. Метод Join: ");
    string question = "А ты знал, что";
    string ch = "черепашка";
    string t = "тебя";
    string l = "любит?";
    string[] value = new string[] { s1, question, ch, t, l };
    string str2 = string.Join(" ", value);
    Console.WriteLine(str2);

    Console.Write("5. Метод Split: ");
    string[] words = s1.Split(new char[] { '.' });
    foreach (string s in words)
    Console.Write(s);

    Console.Write("\n\r" + "6. Метод Trim: ");
    string text = "   Бобёр, обними черепашку!   ";
    text = text.Trim();
    Console.WriteLine(text);

    Console.Write("7. Метод Substring: ");
    string text1 = "не Я люблю бобра";
    text1 = text1.Substring(3);
    Console.WriteLine(text1);

    Console.Write("8. Метод Insert: ");
    string text3 = "А она тебя поцелует.";
    text = text.Insert(text.Length, " " + text3);
    Console.WriteLine(text);

    Console.Write("9. Метод Remove: ");
    string str9 = "Бобер, как дела?";
    int index = str9.Length-11;
    text = str9.Remove(index);
    Console.WriteLine(text);

    Console.Write("10. Метод Replace: ");
    string str10 = "Бобер любит черепашку.";
    string str11 = "Черепашка любит бобра <3";
    str10 = str10.Replace(str10, str11);
    Console.WriteLine(str10);
    Console.ReadKey();

}