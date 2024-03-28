//Домашняя работа


////Задание №1
//int operand1 = 1;
//int operand2 = 2;
//string sign;

//Console.Write("Введите знак арифметической операции (+, -, *, /): ");
//sign = Console.ReadLine();

//switch (sign)
//{
//    case "+":
//        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 + operand2}");
//        break;
//    case "-":
//        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 - operand2}");
//        break;
//    case "*":
//        Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 * operand2}");
//        break;
//    case "/":
//        if (operand2 == 0)
//        {
//            Console.WriteLine("Ошибка: деление на ноль недопустимо");
//        }
//        else
//        {
//            Console.WriteLine($"{operand1} {sign} {operand2} = {operand1 / operand2}");
//        }
//        break;
//    default:
//        Console.WriteLine("Неверный знак арифметической операции");
//        break;
//}


//Задание №2
//Console.WriteLine("Введите целое число от 0 до 100");
//int number = int.Parse(Console.ReadLine());

//if (number >= 0 && number <= 14)
//{
//    Console.WriteLine("Ваше число попадает в промежуток [0-14]");
//}
//if (number >= 15 && number <= 35)
//{
//    Console.WriteLine("Ваше число попадает в промежуток [15-35]");
//}
//if (number >= 36 && number <= 50)
//{
//    Console.WriteLine("Ваше число попадает в промежуток [36-50]");
//}
//if (number >= 51 && number <= 100)
//{
//    Console.WriteLine("Ваше число попадает в промежуток [50-100]");
//}
//else
//{
//    Console.WriteLine("Вы ввели не верное число");
//}
//во втором задании почему то всегда выводит то что в else. Хотел задать вопрос почему?
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


//Здание№4
// Решение 1
//Console.Write("Введите число: ");
//int number1 = int.Parse(Console.ReadLine());

//if (number1 % 2 == 0)
//{
//    Console.WriteLine("Число является четным");
//}
//else
//{
//    Console.WriteLine("Число не является четным");
//}

//Решение 2
//Console.Write("Введите число: ");
//int number = int.Parse(Console.ReadLine());

//switch (number % 2)
//{
//    case 0:
//        Console.WriteLine("Число является четным");
//        break;
//    case 1:
//        Console.WriteLine("Число не является четным");
//        break;
//}

//  занятие 4

//for (int i =1; i<10 ; i++) //i+=10
//{
//Console.WriteLine( i );
//}

//for (int i = 50; i >0; i--) //i+=10
//{
//    Console.WriteLine(i);
//}

//for (int i = 0; i < 50; i++) //i+=10
//{
//    Console.WriteLine(i);
//}

//int number3 = 0;
//while(number3 < 10)
//{
//    Console.WriteLine(number3);
//    number3++;
//}

//do
//{
//    // сначала выполняется действие, потом проверка
//}
//while(number3 != 10);

//for (int i = 50; i > 0; i--) 
//{
//    Console.WriteLine(i);
//    if (i == 10)
//    {
//        break;
//    }
//    if (i == 2)
//    {
//        continue; // пропуск этого шага в цикле
//    }
//}

//for (int i = 0; i <= 50; i++) 
//{

//    if (i % 2 ==0)
//    { 
//    continue;
//    }
//}

// массив
//int[] array = [1,2,3,23,25];

//индексы
//char[] massive = new char[] {'a','=','я'};

//Console.WriteLine(massive[2]); // вывести 3 идекс  массива
//for (int i = 0; i < massive.Length; i++)
//{
//    Console.WriteLine(massive[i]); // перебрать все элементы массива
//}

//char[] array = new char[] { '*', '=', '%' };

//for (int i = array.Length - 1; i >= 0; i--) //перебор массива в обратном порядке
//{
//    Console.WriteLine(array[i]);
//}

//int[] array = new int[5]; // пустой массив на 5 ячеек
//// вкладываем в массивзначения
//array[0] = 3123;
//array[1] = 132;
//array[2] = 14;
//array[3] = 51;
//array[4] = 15;

//for (int i = 0; i < array.Length; i++)
//{
//    Console.WriteLine(array[i]); // выводим все значения массива
//}

//int[] array = new int[5] { 1, 5, 5347, 3568, 35};
//foreach (int item in array)
//{
//    Console.WriteLine(item);
//}

// первое задание [1,2, 32113, -324, 0 ,4] - найти все четные элементы массива и вывести их на экран
//int[] array = new int[] {1,2,32113,-324,0,4};
//for(int i = 0; i < array.Length; i++)
//{
//    if (array[i] % 2 == 0)
//    {
//        Console.WriteLine(array[i]);
//    }
//}

//второе задание [1,2, 32113, -324, 0 ,4] - найти все элементы больше нуля элементы массива и вывести их на экран
//int[] array = new int[] { 1, 2, 32113, -324, 0, 4 };
//for (int i = 0; i < array.Length; i++)
//{
//    if (array[i]>0)
//    {
//        Console.WriteLine(array[i]);
//    }
//}

//int[] array = new int[] { 1, 2, 32113, -324, 0, 4 };
//int sum = 0;

//for (int i = 0; i < array.Length; i++)
//{
//    sum += array[i];
//}
//Console.WriteLine(sum);


//выводим все значения таблицы
//int[,] array = new int[3,3] { {1,2,3 },{1,2,3 },{1,2,3 } };
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); i++)
//    {
//        Console.WriteLine(array[i, j]);
//        Console.WriteLine(" ");
//    }
//}

//int[,] array = new int[3, 3] { { 1, 2, 3 }, { 5, 7, 2 }, { 9, 8, 4 } };
////i- строки, j- стоблцы
//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++) 
//    {
//        Console.Write($"({i}, {j})");
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}

//for (int i = 0; i < array.GetLength(0); i++)
//{
//    for (int j = 0; j < array.GetLength(1); j++)
//    {
//        Console.Write(array[i, j]);
//        Console.Write(" ");
//    }
//    Console.WriteLine();
//}

// зубчатый массив
//int[][] array = { [1, 2, 3], [3, 4, 5, 4, 56,] };

//for (int i = 0; i < array.Length; i++)
//{
//    for (int j = 0; j < array[i].Length; j++)
//    {
//        Console.WriteLine(array[i][j]);
//    }
//}

//создание и ввод данных массива
//Console.WriteLine("Введите кол-во строк массива");
//int lengthN = int.Parse(Console.ReadLine());
//Console.WriteLine("Введите кол-во столбцов массива");
//int lengthM = int.Parse(Console.ReadLine());
//int[,] array = new int[lengthN, lengthM];

//for (int i = 0; i < lengthN; i++)
//{
//    for (int j = 0; j < lengthM; j++)
//    {
//        Console.WriteLine($"[i,j] {i},{j}");
//        array[i, j] = int.Parse(Console.ReadLine());
//    }
//}

//for (int i = 0; i < lengthN; i++)
//{
//    for (int j = 0; j < lengthM; j++)
//    {
//        Console.Write($"{array[i, j]} ");

//    }
//    Console.WriteLine();
//}
//// ГЕНЕРАЦИЯ РАНДОМ ЧИСЕЛ ОТ 1 ДО 3, НЕ ВКЛЮЧАЯ 3
//Random.Shared.Next(1, 3)


//НАЙТИ  МАКСИМАЛЬНОЕ И МИНИМАЛЬНОЕ ЗНАЧЕНИЕ В МАССИВЕ
//int[] array = [1, -1, 3, 4, 423, -432];

//int max = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (max < array[i])
//    {
//        max = array[i];
//    }
//}

//int min = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (min > array[i])
//    {
//        min = array[i];
//    }
//}

//Console.WriteLine(max);
//Console.WriteLine(min);


// 
//int[] array = [1, -1, 3, 4, 423, -432];

//int max = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (max < array[i])
//    {
//        max = array[i];
//    }
//}

//int min = array[0];

//for (int i = 1; i < array.Length; i++)
//{
//    if (min > array[i])
//    {
//        min = array[i];
//    }
//}



// СУММА ПО ГЛАВНОЙ ДИАГОНАЛИ
//int summ = 0;
//for (int i = 0; i < array.GetLength(0); i++)
//{


//    summ += array[i, i];



//}
//Console.WriteLine(summ);



//Урок 5
//сложение строчек

//string s1 = "123";
//string s2="!!!";
//string s= s1 + s2 +"qwe"+"rty";

//Console.WriteLine(s);


//Сравнение
//string s1 = "123";
//string s2 = "!!!";

//bool b2 = s1 == s2;
////или
//int result = string.Compare(s1, s2);

//Console.WriteLine(result);


//Задача 1
//string name = "Влад";
//string surname = "Богданов";
////string fullName = name + " " + surname;
////или
////string fullName2 = string.Concat(name," ",surname);
////или
////Console.WriteLine($"{name} {surname}");
////или
//Console.WriteLine(string.Format(surname, name));


//Задача 2
//string firstName = "Влад";
//string lastName = "Богданов";
//string fullname = "";
//if (firstName.Length > 3)
//{
//    fullname = firstName.Remove(3);
//    fullname= string.Concat(fullname,"***");
//}
//else
//{
//    fullname = string.Concat(firstName, "***");
//}
//Console.WriteLine(fullname);


//Задача 3
//string firstName = "Влад";
//string lastName = "Богданов";

//Console.WriteLine($"{firstName[0]}. {lastName[0]}.");

//Задача 4
string line = "";

while (true)
{
    Console.WriteLine("Введите слово");
    line+=Console.ReadLine();
    Console.WriteLine(line);
}