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