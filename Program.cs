// //int number = new Random().Next(10, 100); //Next (старт, финишь +1)
// int number = 55;
// int firstDigit = number / 10; // Первая цифра числа: 78 -> 7

// int secondDigit = number % 10; // Вторая цифра числа: 78 -> 8

// // System.Console.WriteLine(firstDigit);
// // System.Console.WriteLine(secondDigit);

// int max = firstDigit; // Пусть максимум - первая цифра числа

// if(secondDigit > max) // max = 5, secondDigit = 10
// {
//     max = secondDigit;
// }
// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Максималное число: " + max);

// var rnd = new Random().Next(100, 1000);
// var firstDigit = rnd / 100;
// var thirdDigit = rnd % 10;
// Console.WriteLine("Исходное число: " + rnd);
// Console.WriteLine("первое число " + firstDigit);
// Console.WriteLine("Второе число: " + thirdDigit);


// Console.Write("Введите первое число: ");
// var firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// var secondNumber = Convert.ToInt32(Console.ReadLine());

// var result = firstNumber % secondNumber;

// if(result > 0)

//     Console.WriteLine("Остаток от деления: " + result);
// else
//     Console.WriteLine("Кратно! ");

// Console.Write("Введите число: ");
// var number = Convert.ToInt32(Console.ReadLine());

// if(number % 7 == 0 && number % 23 ==0)
// Console.WriteLine("Да! ");
// else
// // Console.WriteLine("Нет! ");
// int number = new Random().Next(100, 1000);
// int firstDigit = number / 100;

// int thirdDigit = number % 10;

// int result = firstDigit * 10 + thirdDigit;

// Console.WriteLine("Исходное число: " + number);
// Console.WriteLine("Первая и третья цифра числа: " + result);

// Показал препод 12 задачу.
// Console.Write("Введите первое число: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// if (firstNumber % secondNumber == 0)
// {
//     Console.WriteLine("Кратно! ");
// }
// else Console.WriteLine("Не кратно, остаток: " + (firstNumber % secondNumber));

//Задача 14, написал препод

// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// // "&&" - "И" - Обязательное Выполнение условий: 
// if(number % 7 ==0 && number % 23 == 0  )
// {
//     Console.WriteLine("Кратно ");
// }
// else Console.WriteLine(("Не кратно "));