// // // // // // // // // // // // Console.WriteLine("Введите число: ");
// // // // // // // // // // // // int number = int.Parse(Console.ReadLine());
// // // // // // // // // // // // if (number > 0) {
// // // // // // // // // // // //    Console.WriteLine("Число положительное.");
// // // // // // // // // // // // }
// // // // // // // // // // // // else if (number < 0) {
// // // // // // // // // // // //    Console.WriteLine("Число отрицательное.");
// // // // // // // // // // // // }
// // // // // // // // // // // // else {
// // // // // // // // // // // //    Console.WriteLine("Число равно нулю.");
// // // // // // // // // // // // }
// // // // // // // // // // // Console.WriteLine("Введите балл(0-100): ");
// // // // // // // // // // // int score = int.Parse(Console.ReadLine());
// // // // // // // // // // // if (score >= 91) {
// // // // // // // // // // //    Console.WriteLine("Оценка: Отлично (5)");
// // // // // // // // // // // }
// // // // // // // // // // // else if (score >= 71) {
// // // // // // // // // // //    Console.WriteLine("Оценка: Хорошо (4)");
// // // // // // // // // // // }
// // // // // // // // // // // else if (score >= 51) {
// // // // // // // // // // //    Console.WriteLine("Оценка: Удовлетворительно (3)");
// // // // // // // // // // // }
// // // // // // // // // // // else {
// // // // // // // // // // //    Console.WriteLine("Оценка: Неудовлетворительно (2)");
// // // // // // // // // // // }
// // // // // // // // // // Console.WriteLine("Введите количество посещений (из 19): ");
// // // // // // // // // // int attendance = int.Parse(Console.ReadLine());
// // // // // // // // // // Console.Write("Введите средний балл по практике: ");
// // // // // // // // // // double practiceGpa = double.Parse(Console.ReadLine());
// // // // // // // // // // bool goodAttendance = attendance >= 14;
// // // // // // // // // // bool goodGrades = practiceGpa >= 3.0;
// // // // // // // // // // if (goodAttendance && goodGrades) {
// // // // // // // // // //    Console.WriteLine("+ Допуск к экзамену разрешен.");
// // // // // // // // // // }
// // // // // // // // // // else if (!goodAttendance && goodGrades) {
// // // // // // // // // //    Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// // // // // // // // // // }
// // // // // // // // // // else if (goodAttendance && goodGrades) {
// // // // // // // // // //    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы");
// // // // // // // // // // }
// // // // // // // // // // else {
// // // // // // // // // //    Console.WriteLine("- Проблемы с посещаемостью, и с оценками. Срочно к преподавателю.");
// // // // // // // // // // }
// // // // // // // // // Console.WriteLine("Введите ваш возраст : ");
// // // // // // // // // int age = int.Parse(Console.ReadLine());
// // // // // // // // // string ageGroup = age >= 18 ? "совершеннолетний" : "несовершеннолетний";
// // // // // // // // // Console.WriteLine($"Вы {ageGroup}.");
// // // // // // // // // Console.WriteLine("\nВведите температуру за окном(C): ");
// // // // // // // // // double temp = double.Parse(Console.ReadLine());
// // // // // // // // // string weather = temp >= 20 ? "тепло" : (temp >= 0 ? "прохладно" : "мороз");
// // // // // // // // // Console.WriteLine($"За окном {weather}.");
// // // // // // // // // Console.Write("\nВведите число: ");
// // // // // // // // // int n = int.Parse(Console.ReadLine());
// // // // // // // // // string parity = n % 2 == 0 ? "четное" : "нечетное";
// // // // // // // // // Console.WriteLine($"Число {n} - {parity}.");
// // // // // // // // Console.WriteLine("Меню");
// // // // // // // // Console.WriteLine("1. Посмотреть расписание");
// // // // // // // // Console.WriteLine("2. Посмотреть оценки");
// // // // // // // // Console.WriteLine("3. Связаться с преподавателем");
// // // // // // // // Console.WriteLine("4. Выйти");
// // // // // // // // Console.Write("Выберите пункт (1-4): ");
// // // // // // // // string choice = Console.ReadLine();

// // // // // // // // switch (choice) {
// // // // // // // //    case "1":
// // // // // // // //       Console.WriteLine("Расписание: ИСП-244, каб. 102, 08:30");
// // // // // // // //       break;
// // // // // // // //    case "2":
// // // // // // // //       Console.WriteLine("Ваши оценки: ИРСПО - 20, РМП - 35,");
// // // // // // // //       break;
// // // // // // // //    case "3":
// // // // // // // //       Console.WriteLine("Email: denis.leontev92@yandex.ru");
// // // // // // // //       break;
// // // // // // // //    case "4":
// // // // // // // //       Console.WriteLine("До свидания!");
// // // // // // // //       break;
// // // // // // // //    default:
// // // // // // // //       Console.WriteLine($"Ошибка: пункт \"{choice}\" не существует. Введите число от 1 до 4.");
// // // // // // // //       break;
// // // // // // // // }
// // // // // // // Console.Write("\nВведите номер дня недели (1-7): ");
// // // // // // // int dayNumber = int.Parse(Console.ReadLine());

// // // // // // // switch (dayNumber) {
// // // // // // //    case 1:
// // // // // // //    case 2:
// // // // // // //    case 3:
// // // // // // //    case 4:
// // // // // // //    case 5:
// // // // // // //       Console.WriteLine("Рабочий день – пора учиться!");
// // // // // // //       break;
// // // // // // //    case 6:
// // // // // // //    case 7:
// // // // // // //       Console.WriteLine("Выходной – заслуженный отдых.");
// // // // // // //       break;
// // // // // // //    default:
// // // // // // //       Console.WriteLine("Такого дня не существует.");
// // // // // // //       break;
// // // // // // // }
// // // // // // // Console.Write("Введите номер месяца (1-12): ");
// // // // // // // int monthNumber = int.Parse(Console.ReadLine());

// // // // // // // switch (monthNumber) {
// // // // // // //    case 12:
// // // // // // //    case 1:
// // // // // // //    case 2:
// // // // // // //       Console.WriteLine("Зима");
// // // // // // //       break;
// // // // // // //    case 3:
// // // // // // //    case 4:
// // // // // // //    case 5:
// // // // // // //       Console.WriteLine("Весна");
// // // // // // //       break;
// // // // // // //    case 6:
// // // // // // //    case 7:
// // // // // // //    case 8:
// // // // // // //       Console.WriteLine("Лето");
// // // // // // //       break;
// // // // // // //    case 9:
// // // // // // //    case 10:
// // // // // // //    case 11:
// // // // // // //       Console.WriteLine("Осень");
// // // // // // //       break;
// // // // // // //    default:
// // // // // // //       Console.WriteLine("Некорректный ввод! Введите число от 1 до 12.");
// // // // // // //       break;
// // // // // // // }
// // // // // // Random random = new Random();
// // // // // // int secret = random.Next(1, 101);

// // // // // // int attempts = 0;
// // // // // // bool guessed = false;

// // // // // // Console.WriteLine("Угадай число (1-100)");
// // // // // // Console.WriteLine("Я загадал число. Попробуй угадать!");

// // // // // // while (!guessed) {
// // // // // //    Console.Write($"Попытка {attempts + 1}. Твой вариант: ");
// // // // // //    string input = Console.ReadLine();

// // // // // //    if (!int.TryParse(input, out int guess)) {
// // // // // //       Console.WriteLine("!!! Введи целое число, а не текст!");
// // // // // //       continue;
// // // // // //    }

// // // // // //    if (guess < 1 || guess > 100) {
// // // // // //       Console.WriteLine("!!! Число должно быть от 1 до 100!");
// // // // // //       continue;
// // // // // //    }

// // // // // //    attempts++;

// // // // // //    if (guess < secret) {
// // // // // //       int diff = secret - guess;
// // // // // //       string hint = GetHint(diff);
// // // // // //       Console.WriteLine($"↑ Больше! {hint}\n");
// // // // // //    }
// // // // // //    else if (guess > secret) {
// // // // // //       int diff = guess - secret;
// // // // // //       string hint = GetHint(diff);
// // // // // //       Console.WriteLine($"↓ Меньше! {hint}\n");
// // // // // //    }
// // // // // //    else {
// // // // // //       guessed = true;
// // // // // //    }
// // // // // // }

// // // // // // string result = attempts <= 7
// // // // // //     ? $"Отличный результат! Всего {attempts} попыток."
// // // // // //     : $"Число найдено за {attempts} попыток. Можно лучше!";

// // // // // // Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// // // // // // Console.WriteLine($"{result}");

// // // // // // string GetHint(int difference) {
// // // // // //    switch (difference) {
// // // // // //       case <= 3:
// // // // // //          return "🔥 Горячо!";
// // // // // //       case <= 10:
// // // // // //          return "🌡️ Тепло.";
// // // // // //       case <= 25:
// // // // // //          return "🌀 Прохладно.";
// // // // // //       default:
// // // // // //          return "❄️ Холодно!";
// // // // // //    }
// // // // // // }
// // // // // string password = Console.ReadLine()!;
// // // // // string confirm = Console.ReadLine()!;

// // // // // if (password == confirm) {
// // // // //    Console.WriteLine("Пароль принят");
// // // // // }
// // // // // else {
// // // // //    Console.WriteLine("Пароль не принят");
// // // // // }
// // // // int age = int.Parse(Console.ReadLine()!);

// // // // if (age >= 18) {
// // // //    Console.WriteLine("Доступ разрешён");
// // // // }
// // // // else {
// // // //    Console.WriteLine("Доступ запрещён");
// // // // }
// // // double a = double.Parse(Console.ReadLine()!);
// // // double b = double.Parse(Console.ReadLine()!);
// // // string op = Console.ReadLine()!;

// // // switch (op) {
// // //    case "+":
// // //       Console.WriteLine($"{a} + {b} = {a + b}");
// // //       break;
// // //    case "-":
// // //       Console.WriteLine($"{a} - {b} = {a - b}");
// // //       break;
// // //    case "*":
// // //       Console.WriteLine($"{a} * {b} = {a * b}");
// // //       break;
// // //    case "/":
// // //       if (b != 0) {
// // //          Console.WriteLine($"{a} / {b} = {a / b}");
// // //       }
// // //       else {
// // //          Console.WriteLine("Ошибка: деление на ноль!");
// // //       }
// // //       break;
// // //    default:
// // //       Console.WriteLine("Неверная операция");
// // //       break;
// // // }
// // int num1 = int.Parse(Console.ReadLine()!);
// // int num2 = int.Parse(Console.ReadLine()!);
// // int num3 = int.Parse(Console.ReadLine()!);

// // int sum = 0;

// // if (num1 > 0) sum += num1;
// // if (num2 > 0) sum += num2;
// // if (num3 > 0) sum += num3;

// // Console.WriteLine(sum);
// Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути:");
// Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
// Console.WriteLine("Путь B: Пойти по тёмному коридору.");
// Console.Write("Выберите путь (А/В): ");
// string choice1 = Console.ReadLine()!.ToUpper();

// if (choice1 == "А" || choice1 == "A") {
//    Console.WriteLine("Дракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
//    Console.Write("Ваш ответ: ");
//    string answer = Console.ReadLine()!.ToLower();

//    if (answer == "рыба") {
//       Console.WriteLine("Дракон откроет дверь в следующую комнату.");
//    }
//    else {
//       Console.WriteLine("Дракон вас съел!");
//    }
// }
// else if (choice1 == "В" || choice1 == "B") {
//    Console.WriteLine("Вас ждёт тёмная комната с двумя дверями:");
//    Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master'а.");
//    Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
//    Console.Write("Выберите дверь (1/2): ");
//    string choice2 = Console.ReadLine()!;

//    if (choice2 == "1") {
//       Console.WriteLine("Вы получили сокровища!");
//    }
//    else if (choice2 == "2") {
//       Console.WriteLine("Вы попали в ловушку!");
//    }
//    else {
//       Console.WriteLine("Неверный выбор, вы заблудились в темноте.");
//    }
// }
// else {
//    Console.WriteLine("Неверный выбор пути.");
// }

