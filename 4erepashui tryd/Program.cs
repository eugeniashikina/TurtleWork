namespace TurtleWork
{
    public class Program
    {
        public static string count;  // переменная для вывода последовательности, в которой были вызваны методы
        public static string count1; // переменные count (1-5) предназначены для запоминания номера метода
        public static string count2;
        public static string count3;
        public static string count4;
        public static string count5;

        public static decimal result1; // переменные result (1-5) предназначены для запоминания результатов вызванных и выоплненных пользователем методов
        public static string result2;
        public static double result3;
        public static string result4;
        public static string result5;


        public static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Вызывает меню выбора методов
        /// </summary>
        public static void Menu()
        {
            Console.WriteLine("Методы:");
            List<string> list = new List<string>() { "1. Рассчет прибыли (за год и менее) от вклада в банк ", "2. Показать таблицу умножения",
                                                        "3. Рассчитать площадь прямоугольника", "4. Шифрование текста через азбуку Морзе", "5. Проверка числа на палиндром",
                                                        "6. Показать статистику", "7. Сыграть в игру <Угадай слово>" };
            foreach (string item in list)
                Console.WriteLine(item);

            Console.WriteLine("\n\rВведите цифру метода, который хотите выбрать.");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i == 1)
                ProfitForDepozit();
            else if (i == 2)
                MultiplicationTable();
            else if (i == 3)
                GetSquare();
            else if (i == 4)
                Decoder();
            else if (i == 5)
                GetPalindrome();
            else if (i == 6)
                GetStatus();
            else if (i == 7)
                Game();
            else
            {
                Console.WriteLine("Ошибка! Выберите один из методов");
                Console.WriteLine("\n\r");
                Menu();
            }
        }

        /// <summary>
        /// Рассчитывает прибыль за указанный срок (до 1 года) от соответствующего вклада в банк с фиксированной процентной ставкой
        /// </summary>
        public static void ProfitForDepozit()
        {
            Console.WriteLine("\n\rВведите сумму вклада");
            var a = Console.ReadLine();
            double a1;
            if (Double.TryParse(a, out a1))
            {
                Console.WriteLine("\n\rВведите процентную ставку");
                var b = Console.ReadLine();
                double b1;
                if (Double.TryParse(b, out b1))
                {
                    Convert.ToDouble(b.Replace('.', ','));
                    System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); // нужно для перевода ниже
                    double d1 = double.Parse(b); // перевод процентной ставки из string в double

                    Console.WriteLine("\n\rВведите срок (в месяцах), длительностью до 1 года, за который хотите сделать рассчет");
                    var time = Console.ReadLine();
                    int time1;
                    if (Int32.TryParse(time, out time1))
                    {
                        Convert.ToInt32(time);
                        int k = 0;
                        switch (time1)
                        {
                            case 1:
                                k = 30;
                                break;
                            case 2:
                                k = 60;
                                break;
                            case 3:
                                k = 91;
                                break;
                            case 4:
                                k = 121;
                                break;
                            case 5:
                                k = 152;
                                break;
                            case 6:
                                k = 182;
                                break;
                            case 7:
                                k = 213;
                                break;
                            case 8:
                                k = 243;
                                break;
                            case 9:
                                k = 274;
                                break;
                            case 10:
                                k = 304;
                                break;
                            case 11:
                                k = 335;
                                break;
                            case 12:
                                k = 365;
                                break;
                            default:
                                Console.WriteLine("Ошибка!Вы ввели некорректное число, попробуйте еще раз.");
                                break;
                        }
                        if (time1 > 12)
                            ProfitForDepozit();

                        else
                        {
                            int year = 365;
                            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US"); // нужно для перевода ниже
                            double d = double.Parse(b); // перевод процентной ставки из string в double
                            double day = Convert.ToDouble(k) / Convert.ToDouble(year);
                            decimal finance = Convert.ToDecimal(a) * Convert.ToDecimal(d) * (Convert.ToDecimal(day) / Convert.ToDecimal(100));
                            decimal profit = Convert.ToDecimal(a) + Convert.ToDecimal(finance);
                            Console.WriteLine("\n\rВаша прибыль за " + time + "месяцa(ев) составила: " + profit);
                            string q = "1.";
                            count1 += q;
                            count += q;
                            result1 = profit;
                            Console.WriteLine("\n\r");
                            Menu();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка. Срок должен быть выражен в числовом формате. Попробуйте заново.");
                        ProfitForDepozit();
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка. % ставка должна быть выражена в числовом формате. Попробуйте заново.");
                    ProfitForDepozit();
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Сумма вклада должна быть выражена в числовом формате. Попробуйте заново.");
                ProfitForDepozit();
            }
        }


        /// <summary>
        /// Вывод в консоль таблицу умножения
        /// </summary>
        public static void MultiplicationTable()
        {
            string q = "2.";
            count2 += q;
            count += q;
            result2 += "Вы посмотрели таблицу умножения";
            Console.WriteLine("\n\r" + "              " + "Таблица умножения");
            Console.WriteLine(" " + "2x1=2" + "      " + "3x1=3" + "       " + "4x1=4" + "       " + "5x1=5");
            Console.WriteLine(" " + "2x2=4" + "      " + "3x2=6" + "       " + "4x2=8" + "       " + "5x2=10");
            Console.WriteLine(" " + "2x3=6" + "      " + "3x3=9" + "       " + "4x3=12" + "      " + "5x3=15");
            Console.WriteLine(" " + "2x4=8" + "      " + "3x4=12" + "      " + "4x4=16" + "      " + "5x4=20");
            Console.WriteLine(" " + "2x5=10" + "     " + "3x5=15" + "      " + "4x5=20" + "      " + "5x5=25");
            Console.WriteLine(" " + "2x6=12" + "     " + "3x6=18" + "      " + "4x6=24" + "      " + "5x6=30");
            Console.WriteLine(" " + "2x7=14" + "     " + "3x7=21" + "      " + "4x7=28" + "      " + "5x7=35");
            Console.WriteLine(" " + "2x8=16" + "     " + "3x8=24" + "      " + "4x8=32" + "      " + "5x8=40");
            Console.WriteLine(" " + "2x9=18" + "     " + "3x9=27" + "      " + "4x9=36" + "      " + "5x9=45");
            Console.WriteLine(" " + "2x10=20" + "    " + "3x10=30" + "     " + "4x10=40" + "     " + "5x10=50");
            Console.WriteLine("\n\r");
            Console.WriteLine(" " + "6x1=6" + "      " + "7x1=7" + "       " + "8x1=8" + "       " + "9x1=9");
            Console.WriteLine(" " + "6x2=12" + "     " + "7x2=14" + "      " + "8x2=16" + "      " + "9x2=18");
            Console.WriteLine(" " + "6x3=18" + "     " + "7x3=21" + "      " + "8x3=24" + "      " + "9x3=27");
            Console.WriteLine(" " + "6x4=24" + "     " + "7x4=28" + "      " + "8x4=32" + "      " + "9x4=36");
            Console.WriteLine(" " + "6x5=30" + "     " + "7x5=35" + "      " + "8x5=40" + "      " + "9x5=45");
            Console.WriteLine(" " + "6x6=36" + "     " + "7x6=42" + "      " + "8x6=48" + "      " + "9x6=54");
            Console.WriteLine(" " + "6x7=42" + "     " + "7x7=49" + "      " + "8x7=56" + "      " + "9x7=63");
            Console.WriteLine(" " + "6x8=48" + "     " + "7x8=56" + "      " + "8x8=64" + "      " + "9x8=72");
            Console.WriteLine(" " + "6x9=54" + "     " + "7x9=63" + "      " + "8x9=72" + "      " + "9x9=81");
            Console.WriteLine(" " + "6x1=60" + "     " + "7x10=70" + "     " + "8x10=80" + "     " + "9x10=90");
            Console.WriteLine("\n\r");
            Menu();
        }

        /// <summary>
        /// Рассчитывает площадь прямоугольника по введенным данным (длине и ширине)
        /// </summary>
        public static void GetSquare()
        {
            string q = "3.";
            count3 += q;
            count += q;
            Console.WriteLine("\n\rВведите длину прямоугольника");
            var a = Console.ReadLine();
            double a1;

            Console.WriteLine("\n\rВведите ширину прямоугольника");
            var b = Console.ReadLine();
            double b1;

            if (Double.TryParse(a, out a1) && Double.TryParse(b, out b1))
            {
                Convert.ToDouble(a.Replace('.', ','));
                Convert.ToDouble(b.Replace('.', ','));
                double length = double.Parse(a.Replace('.', ',')); // чтоб работало и с '.' и с ',' ==>
                double width = double.Parse(b.Replace('.', ',')); // ==> даже если взять значения с разными знаками
                double square = length * width;
                Console.WriteLine("\n\rПлощадь прямоугольника с введенными параметрами сторон равна: " + square);
                result3 += square;
                Console.WriteLine("\n\r");
                Menu();
            }
            else
            {
                Console.WriteLine("Ошибка. Ширина и длина должны быть числами.");
                GetSquare();
            }
        }

        /// <summary>
        /// Зашировывает и расшифровывает текст через азбуку Морзе
        /// </summary>
        public static void Decoder()
        {
            Console.WriteLine("\n\r" + "      " + "Азбука Морзе");
            Console.WriteLine("A *-" + "    " + "Л *-**" + "  " + "Ц -*-*");
            Console.WriteLine("Б -***" + "  " + "М --" + "    " + "Ч ---*");
            Console.WriteLine("В *--" + "   " + "Н -*" + "    " + "Ш ----");
            Console.WriteLine("Г --*" + "   " + "О ---" + "   " + "Щ --*-");
            Console.WriteLine("Д -**" + "   " + "П *--*" + "  " + "Ъ *--*-*");
            Console.WriteLine("Е *" + "     " + "Р *-*" + "   " + "Ы -*--");
            Console.WriteLine("Ж ***-" + "  " + "С ***" + "   " + "Ь -**-");
            Console.WriteLine("З --**" + "  " + "Т -" + "     " + "Э **-**");
            Console.WriteLine("И **" + "    " + "У **-" + "   " + "Ю **--");
            Console.WriteLine("Й *---" + "  " + "Ф **-*" + "  " + "Я *-*-");
            Console.WriteLine("К -*-" + "   " + "Х ****");

            Console.WriteLine("\n\rНапишите текст (между словами должен быть пробел)");
            string s1 = Console.ReadLine();

            char[] letter = new char[32] { 'а', 'б', 'в', 'г', 'д', 'е', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т',
                                                    'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };
            string[] symbols = new string[32] { "*-", "-***", "*--", "--*", "-**", "*", "***-", "--**", "**", "*---", "-*-", "*-**", "--", "-*",
                                                    "---", "*--*", "*-*", "***", "-", "**-", "**-*", "****", "-*-*", "---*", "----", "--*-", "*--*-*",
                                                    "-*--", "-**-", "**-**", "**--", "*-*-"};
            string s2 = "";
            foreach (char c in s1)
            {
                switch (c)
                {
                    case 'а': s2 += symbols[0]; break;
                    case 'б': s2 += symbols[1]; break;
                    case 'в': s2 += symbols[2]; break;
                    case 'г': s2 += symbols[3]; break;
                    case 'д': s2 += symbols[4]; break;
                    case 'е': s2 += symbols[5]; break;
                    case 'ж': s2 += symbols[6]; break;
                    case 'з': s2 += symbols[7]; break;
                    case 'и': s2 += symbols[8]; break;
                    case 'й': s2 += symbols[9]; break;
                    case 'к': s2 += symbols[10]; break;
                    case 'л': s2 += symbols[11]; break;
                    case 'м': s2 += symbols[12]; break;
                    case 'н': s2 += symbols[13]; break;
                    case 'о': s2 += symbols[14]; break;
                    case 'п': s2 += symbols[15]; break;
                    case 'р': s2 += symbols[16]; break;
                    case 'с': s2 += symbols[17]; break;
                    case 'т': s2 += symbols[18]; break;
                    case 'у': s2 += symbols[19]; break;
                    case 'ф': s2 += symbols[20]; break;
                    case 'х': s2 += symbols[21]; break;
                    case 'ц': s2 += symbols[22]; break;
                    case 'ч': s2 += symbols[23]; break;
                    case 'ш': s2 += symbols[24]; break;
                    case 'щ': s2 += symbols[25]; break;
                    case 'ъ': s2 += symbols[26]; break;
                    case 'ы': s2 += symbols[27]; break;
                    case 'ь': s2 += symbols[28]; break;
                    case 'э': s2 += symbols[29]; break;
                    case 'ю': s2 += symbols[30]; break;
                    case 'я': s2 += symbols[31]; break;
                    case ' ': s2 += " "; break;
                    default: s2 = null; break;
                }
            }
            if (s2 == null)
            {
                Console.WriteLine("Ошибка. Попробуйте еще раз");
                Decoder();
            }
            else
            {
                result4 += s2;
                Console.WriteLine(s2);
                string q = "4.";
                count4 += q;
                count += q;
                Console.WriteLine("\n\r");
                Menu();
            }
        }

        /// <summary>
        /// Исследует число на палиндром
        /// </summary>
        public static void GetPalindrome()
        {
            string q = "5.";
            count5 += q;
            count += q;
            Console.WriteLine("\n\rВведите число, которое хотите проверить на палиндром");
            string number = Console.ReadLine();
            int a;
            if (Int32.TryParse(number, out a))
            {
                string number2 = "";
                if (number.Length > 1)
                {
                    for (int i = number.Length - 1; i >= 0; i--)
                        number2 += number[i];
                    if (number == number2)
                    {
                        Console.WriteLine("\n\r" + "Число " + number + " является палиндромом");
                        result5 = "Введенное вами число является палиндромом";
                    }
                    else
                    {
                        Console.WriteLine("\n\r" + "Число " + number + " не является палиндромом");
                        result5 = "Введенное вами число не является палиндромом";
                    }
                }
                else
                {
                    result5 = "Введенное вами число не является палиндромом";
                    Console.WriteLine("\n\r" + "Число " + number + " не является палиндромом");
                }
                Console.WriteLine("\n\r");
                Menu();
            }
            else
            {
                Console.WriteLine("Ошибка! Введите пожалуйста число");
                GetPalindrome();
            }
        }

        /// <summary>
        /// Отображает статистику пользователя
        /// </summary>
        public static void GetStatus()
        {
            Console.WriteLine("\n\rПорядок команд,вызванных Вами:");
            if (count1 == null && count2 == null && count3 == null && count4 == null && count5 == null)
                Console.WriteLine("Вы не вызвали ни одного метода");

            else Console.WriteLine(count);

            Console.WriteLine("\n\rНазвание методa(ов) и результат(ы) его(их) выполнения: ");

            if (count1 == null && count2 == null && count3 == null && count4 == null && count5 == null)
                Console.WriteLine("Так как Вы не вызвали ни одного метода, результатов тоже нет =)");

            if (count1 != null)
                Console.WriteLine("1. Рассчет прибыли (за год и менее) от вклада в банк " + "==> " + "Результат: " + result1);

            if (count2 != null)
                Console.WriteLine("2. Показать таблицу умножения " + "==> " + "Результат: " + result2);

            if (count3 != null)
                Console.WriteLine("3. Рассчитать площадь прямоугольника " + "==> " + "Результат: " + result3);

            if (count4 != null)
                Console.WriteLine("4. Шифрование текста через азбуку Морзе " + "==> " + "Результат: " + result4);

            if (count5 != null)
                Console.WriteLine("5. Проверка числа на палиндром " + "==> " + "Результат: " + result5);

            Console.WriteLine("\n\rЕсли хотите сыграть в игру, нажмите 7; если не хотите - нажмите любую другую кнопку.");
            string y = "7";

            if (Console.ReadLine() == y)
                Game();
            else Console.Clear();
        }

        /// <summary>
        /// Игра, где нужно угадать слово
        /// </summary>
        public static void Game()
        {
            string[] question = new string[] { "Какое животное можно увидеть на логотипе Porsche?", "Какая планета ближе всех расположена к Солнцу?",
                                                "Что носит дьявол в известном фильме?", "Какой танец считается самым страстным?", "Главное орудие хоккеиста – это …",
                                                "Какой фрукт является объектом раздора?", "Как называют состояние, если мужчина/женщина всю жизнь любят одного человека?",
                                                "Эта фигура на шахматной доске делает только диагональный ход. Какая?", "Евреи не едят это мясо. Какое?",
                                                "Назовите зубного врача другим словом.", "Стержень спортивной штанги именуют …", "Кто всем ребятам пример в советском выражении?"};
            string[] answer = new string[] { "лошадь", "меркурий", "прада", "танго", "клюшка", "яблоко", "моногамия", "слон", "свинина", "дантист", "гриф", "пионер",
            "Лошадь", "ЛОШАДЬ", "Меркурий", "МЕРКУРИЙ", "Прада" , "ПРАДА", "Танго", "ТАНГО", "Клюшка", "КЛЮШКА", "Яблоко", "ЯБЛОКО", "Моногамия", "МОНОГАМИЯ", "Слон", "СЛОН",
            "Свинина", "СВИНИНА", "Дантист", "ДАНТИСТ", "Гриф", "ГРИФ", "Пионер", "ПИОНЕР"};

            answer[0] = answer[13] = answer[14];
            answer[1] = answer[14] = answer[15];
            answer[2] = answer[16] = answer[17];
            answer[3] = answer[18] = answer[19];
            answer[4] = answer[20] = answer[21];
            answer[5] = answer[22] = answer[23];
            answer[6] = answer[24] = answer[25];
            answer[7] = answer[26] = answer[27];
            answer[8] = answer[28] = answer[29];
            answer[9] = answer[30] = answer[31];
            answer[10] = answer[32] = answer[33];
            answer[11] = answer[34] = answer[35];

            Random random = new Random();
            int k = random.Next(0, 12);
            Console.WriteLine("\n\rВаш вопрос: " + question[k]);
            Console.WriteLine("У вас есть 3 попытки дать правильный ответ");
            Console.WriteLine("Ваш ответ: ");

            for (int item = 3; item > 0; item--)
            {
                if (Console.ReadLine() == answer[k])
                {
                    Console.WriteLine("Правильно");
                    Console.WriteLine("\n\r");
                    Menu();
                }
                else Console.WriteLine("Неправильно. У Вас осталось " + (item - 1) + "попытки(а)");
            }

            Console.WriteLine("Попытки закончились, Вы не угадали. Если хотите попробовать еще раз,- напишите <да>. Если не хотите, напишите <нет>");
            string yes = "да";

            if (Console.ReadLine() == yes)
                Game();
            else
            {
                Console.WriteLine("\n\r");
                Menu();
            }
        }
    }
}