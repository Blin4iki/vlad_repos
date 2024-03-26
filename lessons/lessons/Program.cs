//Домашняя работа


// Задание №1
//int operand1 = 1;
//int operand2 = 2;
//string sign;

//Console.Write("Введите знак арифметической операции (+, -, *, /): ");
//sign = Console.ReadLine();

//switch (sign)
//{
//    case "+":
//       Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 + operand2}");
//       break;
//    case "-":
//       Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 - operand2}");
//       break;
//    case "*":
//       Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 * operand2}");
//       break;
//    case "/":
//    if (operand2 == 0)
//    {
//       Console.WriteLine("Ошибка: деление на ноль недопустимо");
//    }
//    else
//    {
//       Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 / operand2}");
//    }
//       break;
//    default:
//       Console.WriteLine("Неверный знак арифметической операции");
//       break;
//}


//// Задание №2
//Console.WriteLine("Введите целое число от 0 до 100");
//int number = int.Parse(Console.ReadLine());

//if (number >= 0 && number <= 14)
//{
//   Console.WriteLine("Ваше число попадает в промежуток [0-14]");
//}
//if (number >= 15 && number <=35)
//{
//   Console.WriteLine("Ваше число попадает в промежуток [15-35]");
//}
//if (number >= 36 && number <= 50)
//{
//   Console.WriteLine("Ваше число попадает в промежуток [36-50]");
//}
//if (number >= 51 && number <= 100)
//{
//   Console.WriteLine("Ваше число попадает в промежуток [50-100]");
//}
//else
//{
//   Console.WriteLine("Вы ввели не верное число");
//}
// во втором задании почему то всегда выводит то что в else. Хотел задать вопрос почему?
// можноконечно сделать if (number >= 101 || number <= -1), но надо понять почему так с else


// Задание №3
//Console.WriteLine("В нашем словаре присутсвует 10 слов о погоде: снежно,солнечно,ветренно,облачно,туманно,дождливо,жарко,сухо,холодно,тепло");
//Console.WriteLine("Введите слово, которое хотите перевести");
//string weather = Console.ReadLine();

//if (weather == "снежно")
//{
//    Console.WriteLine("snowy");
//}
//if (weather == "солнечно")
//{
//    Console.WriteLine("sunny");
//}
//if (weather == "ветренно")
//{
//    Console.WriteLine("windy");
//}
//if (weather == "облачно")
//{
//    Console.WriteLine("cloudy");
//}
//if (weather == "туманно")
//{
//    Console.WriteLine("foggy");
//}
//if (weather == "дождливо")
//{
//    Console.WriteLine("rainy");
//}
//if (weather == "жарко")
//{
//    Console.WriteLine("hot");
//}
//if (weather == "сухо")
//{
//    Console.WriteLine("dry");
//}
//if (weather == "холодно")
//{
//    Console.WriteLine("cold");
//}
//if (weather == "тепло")
//{
//    Console.WriteLine("warm");
//}
//else
//{
//    Console.WriteLine("такого слова нет в переводчике");
//}


// Здание№4
// Решение 1
//Console.Write("Введите число: ");
//int number1 = int.Parse(Console.ReadLine());

//if (number1 % 2 == 0)
//        {
//            Console.WriteLine("Число является четным");
//        }
//else
//        {
//            Console.WriteLine("Число не является четным");
//        }

// Решение 2
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());

//switch (number % 2)
//{
//    case 0:
//          Console.WriteLine("Число является четным");
//          break;
//    case 1:
//          Console.WriteLine("Число не является четным");
//          break; 
//}
