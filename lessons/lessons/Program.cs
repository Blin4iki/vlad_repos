// ДЗ №3
//Задание 1
//int[] numbers = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

//Console.Write("Введите число для поиска: ");
//int numberToSearch = int.Parse(Console.ReadLine());

//bool isFound = false;
//foreach (int number in numbers)
//{
//    if (number == numberToSearch)
//    {
//        isFound = true;
//        break;
//    }
//}

//if (isFound)
//{
//    Console.WriteLine("Число найдено в массиве.");
//}
//else
//{
//    Console.WriteLine("Число не найдено в массиве.");
//}


//Задание 2
// единственное, я здесь почему то не смог перенести на след строку сообщение о том какое число удалить
//int[] numbers = { 2, 5, 8, 5, 7, 9, 12, 5, 15, 18 };
//Console.Write("Наш массив: ");
//foreach (int number in numbers)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine("Введите число для удаления: ");
//int numberToDelete = int.Parse(Console.ReadLine());

//int count = 0;
//foreach (int number in numbers)
//{
//    if (number == numberToDelete)
//    {
//        count++;
//    }
//}

//if (count == 0)
//{
//    Console.WriteLine("Число не найдено в массиве.");
//}
//else
//{
//    int[] result = new int[numbers.Length - count];
//    int index = 0;
//    foreach (int number in numbers)
//    {
//        if (number != numberToDelete)
//        {
//            result[index] = number;
//            index++;
//        }
//    }

//    Console.WriteLine("Новый массив после удаления числа:");
//    foreach (int number in result)
//    {
//        Console.Write(number + " ");
//    }
//}


//Задание 3
//Снова проблема с переносом строки, ситуация такая же как и в прошлом задании
//Console.Write("Введите размер массива: ");
//int size = int.Parse(Console.ReadLine());

//int[] array = new int[size];
//Random random = new Random();

//for (int i = 0; i < size; i++)
//{
//    array[i] = random.Next(1, 1000); 
//}

//int max = array[0];
//int min = array[0];
//double sum = 0;

//foreach (int num in array)
//{
//    if (num > max)
//        max = num;

//    if (num < min)
//        min = num;

//    sum += num;
//}

//double average = sum / size;

//Console.WriteLine("Массив случайных чисел:");
//foreach (int num in array)
//{
//    Console.Write(num + " ");
//}

//Console.WriteLine("Максимальное значение в массиве: " + max);
//Console.WriteLine("Минимальное значение в массиве: " + min);
//Console.WriteLine("Среднее значение в массиве: " + average);


//Задание 4
//int[] array1 = { 100, 200, 300, 400, 500 };
//int[] array2 = { 10, 20, 30, 40, 50 };
//foreach (int number in array1)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine(); // Знаю не красиво, но как лучше сделать,не придумал))
//foreach (int number in array2)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine(); //чтобы след. строка перенеслась
//double sum1 = 0;
//double sum2 = 0;
//foreach (int num in array1)
//{
//    sum1 += num;
//}
//foreach (int num in array2)
//{
//    sum2 += num;
//}
//int size1 = array1.Length;
//int size2 = array2.Length;
//double average1 = sum1 / size1;
//double average2 = sum2 / size2;

//if (average1 > average2)
//{
//    Console.WriteLine("В массиве 1 среднее арифетическое больше чем в массиве 2");
//}
//else if (average1 < average2)
//{
//    Console.WriteLine("В массиве 2 среднее арифетическое больше чем в массиве 1");
//}
//else
//{
//    Console.WriteLine("Среднее арифметическое массива 1 равно среднему арифметическому массива 2");
//}