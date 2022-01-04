//Zadanie1();
//DopZadanie();
Calculate();

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