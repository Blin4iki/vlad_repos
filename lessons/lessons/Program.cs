﻿// ДЗ №3
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
////Console.WriteLine("[{0}]", string.Join(", ", numbers)); // или можно так
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
//var random = new Random();

//int max = 0;
//int min = 1000;
//double sum = 0;

//for (int i = 0; i < size; i++)
//{
//    array[i] = random.Next(1, 1000);
//}

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
//Console.WriteLine("\nМаксимальное значение в массиве: " + max);
//Console.WriteLine("Минимальное значение в массиве: " + min);
//Console.WriteLine("Среднее значение в массиве: " + average);


//Задание 4
//int[] array1 = { 1, 2, 3, 4, 5 };
//int[] array2 = { 10, 20, 30, 40, 50 };
//Console.WriteLine("Массив №1");
//foreach (int number in array1)
//{
//    Console.Write(number + " ");
//}
//Console.WriteLine("\nМассив №2");
//foreach (int number in array2)
//{
//    Console.Write(number + " ");
//}
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
//    Console.WriteLine("\nв массиве 1 среднее арифетическое больше чем в массиве 2");
//}
//else if (average1 < average2)
//{
//    Console.WriteLine("\nв массиве 2 среднее арифетическое больше чем в массиве 1");
//}
//else
//{
//    Console.WriteLine("\nсреднее арифметическое массива 1 равно среднему арифметическому массива 2");
//}


//занятие 6 методы и классы

//Console.WriteLine("Hello, World!");

//PrintArray(new int[] { 1, 2, 3 });


//int first = 2;
//int second = 3;

//int result = Multiply(first, second);
//Console.WriteLine(result);
//// создан метод умножения
//int Multiply(int a, int b)
//{
//    int c = a * b;

//    return c;
//}
//// создан метод вывода матрицы
//void PrintArray(int[] array)
//{
//    Console.WriteLine(string.Join(", ", array));
//}


//var person = new Person()
//{
//    Name = "Вася",
//    Age = 3453,
//};

//var person2 = new Person()
//{
//    Name = "Вася123123",
//    Age = 345321321,
//};

//var info = person.GetInfo();
//person2.GetInfo();

//Console.WriteLine(info);


//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public string GetInfo()
//    {
//        return $"{Name} , {Age}";
//    }
//}


//var person = new Person("123", 123);

//class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public Person(string name)
//    {
//        Name = name;
//    }

//    public Person(string name, int age) : this(name)
//    {
//        Age = age;
////    }
//public static void Print(string message)
//{
//    Console.WriteLine(message);
//}
//}

using lessons;

Student[] students = new Student[14];
for (int i = 0; i < students.Length; i++)
{
    students[i] = new Student(i.ToString(), Random.Shared.Next(0, 11));
}

foreach (Student student in students)
{
    //if (student.Score > 8)
    {
        student.Print();
    }
}
