// // 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// // 78 -> 8 
// // 12-> 2 
// // 85 -> 8

// Console.Clear();
// int x = new Random().Next(10, 100);
// Console.WriteLine(x);

// int temp2 = x % 10;
// int temp = (x - temp2) / 10;
// Console.WriteLine(temp);
// Console.WriteLine(temp2);

// if (temp == temp2)
// {
//     Console.WriteLine($"{temp} равен {temp2}. Ты чиво наделал?!");
// }
// else if (temp2 > temp)
// {
//     Console.WriteLine($"{temp2} больше");
// }
// else if (temp > temp2)
// {
//     Console.WriteLine($"{temp} больше");
// }


// // 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// // 456 -> 46
// // 782 -> 72
// // 918 -> 98

// Console.Clear();
// int x = new Random().Next(100, 1000);
// Console.WriteLine(x);

// int temp2 = x % 10;
// int temp = x / 100;
// Console.Write(temp);
// Console.WriteLine(temp2);




// // 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
// // Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// // 34, 5 -> не кратно, остаток 4 
// // 16, 4 -> кратно

// Console.Clear();
// Console.Write("Введите два числа: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int temp = 0;
// if (num1 % num2 == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     temp = num1 % num2;
//     Console.WriteLine($"Не кратно, остаток - {temp}");
// }



// // Напиши программу, которая по введённому возрасту пользователя сообщает, к какой возрастной группе он относится:
// // 	до 13 включительно – детство;
// // 	от 14 до 24 – молодость;
// // 	от 25 до 59 – зрелость;
// // 	от 60 – старость.

// Console.Clear();
// Console.Write("Введите возраст пользователя: ");
// int age = Convert.ToInt32(Console.ReadLine());

// if (age >= 0 && age <= 13)
// {
//     Console.WriteLine("Детство");
// }
// else if (age >= 14 && age <= 24)
// {
//     Console.WriteLine("Молодость");
// }
// else if (age >= 25 && age <= 59)
// {
//     Console.WriteLine("Зрелость");
// }
// else if (age >= 60)
// {
//     Console.WriteLine("Старость");
// }
// else if (age < 0)
// {
//     Console.WriteLine("Неверный возраст");
// }



// // Напиши программу,  где вводим три числа, а потом выводим сумму только положительных чисел.

// Console.Clear();
// Console.Write("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// int sum = 0;

// if (num1 < 0){
//     num1 = 0;
// }
// else if (num2 < 0){
//         num2 = 0;
// }
// else if (num3 < 0){
//             num3 = 0;
// }

// sum = num1 + num2 + num3;
// Console.Write("Сумма положительных чисел равна ");
// Console.WriteLine(sum);