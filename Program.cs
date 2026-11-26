// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1044;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");


// int variant = 2;
// bool isPrime = true;

// for (int divisor = 2; divisor < variant; divisor++)
// {
//     if (variant % divisor == 0)
//     {
//         isPrime = false;
//         break;
//     }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");



// int[] pointsPerLab = { 8, -1, 10, 9, -1, 7 };
// int sum = 0;
// int count = 0;

// foreach (int points in pointsPerLab)
// {
//     if (points < 0)
//     {
//         continue;
//     }
//     sum += points;
//     count++;
// }

// Console.WriteLine($"Сумма баллов за сданные работы: {sum}", "Работ сдано: {count}");
// Console.WriteLine($"Работ сдано: {count}");


// int[] groupIds = { 101, 104, 107, 104, 110 };
// bool hasDuplicates = false;

// for (int i = 0; i < groupIds.Length; i++)
// {
//     for (int j = i + 1; j < groupIds.Length; j++)
//     {
//         if (groupIds[i] == groupIds[j])
//         {
//             hasDuplicates = true;
//             Console.WriteLine($"Найден дубликат: {groupIds[i]} и {groupIds[j]}");
//             break;
//         }
//     }
//     if (hasDuplicates)
//     {
//         break;
//     }
// }

// Console.WriteLine(hasDuplicates ? "Есть повторяющиеся номера" : "Все номера уникальны");




// int days = 5;
// int lessonsPerDay = 6;
// bool found = false;

// for (int day = 1; day <= days && !found; day++)
// {
//     for (int lesson = 1; lesson <= lessonsPerDay; lesson++)
//     {
//         bool isFree = (day == 3 && lesson == 4);

//         if (isFree)
//         {
//             Console.WriteLine($"Свободный слот: день {day}, урок {lesson}");
//             found = true;
//             break;
//         }
//     }
// }

// if (!found )
// {
//     Console.WriteLine("Свободных слотов нет");
// }



// int[] count = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//         int sum = 0;

//         for (int i = 0; i < count.Length; i++)
//         { 
//             if (count[i] % 2 != 0)
//             {
//                 continue;
//             }
//             sum+= count[i];
//         }
//     Console.WriteLine("Сумма чётных чисел: " + sum);




// int[] plu = { 5, 8, 2, 9, 5, 1 };
//         bool hasDuplicates = false;

//         for (int i = 0; i < plu.Length; i++)
//         {
//             for (int j = i + 1; j < plu.Length; j++)
//             {
//                 if (plu[i] == plu[j])
//                 {
//                     hasDuplicates = true;
//                     break; 
//                 }
//             }
//             if (hasDuplicates)
//             {
//                 break;
//             }
//         }

//         if (hasDuplicates)
//         {
//             Console.WriteLine("В массиве есть повторяющиеся элементы.");
//         }
//         else
//         {
//             Console.WriteLine("Повторяющихся элементов нет.");
//         }




// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");




// int Numb = -1;

// for (int i = 1; i <= 100; i++)
//     {
//         if (i % 2 == 0 && i % 3 == 0)
//         {
//             Numb = i; 
//             break;           
//          }
//     }
//         if (Numb != -1)
//         {
//             Console.WriteLine($"Число кратное 2 и 3: {Numb}");
//         }
//         else
//         {
//             Console.WriteLine("Нету числа");
//         }




// int[] array = { 5, 12, 0, -3, 8, -7, 4 };
        
//     int foundIndex = -1;      
//     bool isFound = false;     
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] < 0)
//         {
//             foundIndex = i;   
//             isFound = true;   
//             break;            
//         }
//     }
//     if (isFound)
//     {
//         Console.WriteLine($"Индекс первого отрицательного числа: {foundIndex}");
//     }
//     else
//     {
//         Console.WriteLine("Не найдено");
//     }