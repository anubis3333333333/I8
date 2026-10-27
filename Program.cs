// PrintLine();
// Console.WriteLine("Отчет");
// PrintLine();

// static void PrintLine(){
//     Console.WriteLine("^_^");
// }


// PrintHeader("!");
// PrintHeader("??");

// static void PrintLine() {
//     Console.WriteLine("🌟✨🌟✨🌟✨🌟✨🌟");
// }

// static void PrintHeader(string title) {
//     PrintLine();
//     Console.WriteLine($"      {title}");
//     PrintLine();
//     Console.WriteLine(); 
// }





// int max1 = Max(10, 20);
// int max2 = Max(-5, -1);
// int max3 = Max(42, 42);
// Console.WriteLine($"Большее из 10 и 20: {max1}"); 
// Console.WriteLine($"Большее из -5 и -1: {max2}"); 
// Console.WriteLine($"Большее из 42 и 42: {max3}"); 
// Console.WriteLine();
// Console.WriteLine($"Число 4 чётное? {IsEven(4)}"); 
// Console.WriteLine($"Число 7 чётное? {IsEven(7)}"); 
// Console.WriteLine($"Число 0 чётное? {IsEven(0)}"); 




// static void PrintLine(){
//     Console.WriteLine("🌟✨🌟✨🌟✨🌟✨🌟");
// }

// static void PrintHeader(string title){
//     PrintLine();
//     Console.WriteLine($"      {title}");
//     PrintLine();
//     Console.WriteLine();
// }


// static int Max(int a, int b){
//     if (a > b){
//         return a;
//     }
//     else{
//         return b;
//     }
// }


// static bool IsEven(int n){
//     return n % 2 == 0;
// }






// int[] testArray = { 120, 45, 300, 80, 15, 210 };
// double avg = Average(testArray);
// int count = CountGreater(testArray, 100); 
// Console.WriteLine($"Среднее значение массива: {avg:F2}"); 
// Console.WriteLine($"Количество элементов больше 100: {count}");

// static double Average(int[] arr){
//     if (arr.Length == 0) return 0;
//     double sum = 0;
//     foreach (int x in arr){
//         sum += x;
//     }
//     return sum / arr.Length;
// }


// static int CountGreater(int[] arr, int limit){
//     int count = 0;
//     foreach (int x in arr){
//         if (x > limit){
//             count++;
//         }
//     }
//     return count;
// }



// double c1 = 0;
// double f1 = ToFahrenheit(c1);
// Console.WriteLine($"{c1} °C = {f1} °F");

// double c2 = 100;
// double f2 = ToFahrenheit(c2);
// Console.WriteLine($"{c2} °C = {f2} °F"); 

// double c3 = 37;
// double f3 = ToFahrenheit(c3);
// Console.WriteLine($"{c3} °C = {f3} °F"); 

// static double Average(int[] arr) { double sum = 0; foreach (int x in arr) sum += x; return sum / arr.Length; }
// static int CountGreater(int[] arr, int limit) { int count = 0; foreach (int x in arr) if (x > limit) count++; return count; }

// static double ToFahrenheit(double celsius){
//     return celsius * 9 / 5 + 32;
// }



// Console.WriteLine($"Факториал 5! = {Factorial(5)}"); 
// Console.WriteLine("Простые числа от 2 до 50:");
// for (int i = 2; i <= 50; i++){
//     if (IsPrime(i)){
//         Console.Write($"{i} ");
//     }
// }
// Console.WriteLine("\n"); 
// Console.WriteLine("Тестирование ввода с проверкой");
// int num1 = ReadPositive("Введите первое положительное число: ");
// int num2 = ReadPositive("Введите второе положительное число: ");
// int sum = num1 + num2;
// Console.WriteLine($"Сумма введенных чисел: {sum}");






// static long Factorial(int n){
//     long result = 1;
//     for (int i = 1; i <= n; i++){
//         result *= i;
//     }
//     return result;
// }


// static bool IsPrime(int n){
//     if (n < 2) return false;
//     for (int i = 2; i * i <= n; i++){
//         if (n % i == 0) return false;
//     }
//     return true;
// }


// static int ReadPositive(string message){
//     int number;
//     do{
//         Console.Write(message);
//         string input = Console.ReadLine();
        
//         if (int.TryParse(input, out number)){
//             if (number > 0){
//                 return number; 
//             }
//         }
        
//         Console.WriteLine("Ошибка! Нужно ввести целое положительное число (больше 0).");
//     } while (true); 
// }


int choice = -1;

while (choice != 0){
    Console.WriteLine("\n1 – сумма двух чисел");
    Console.WriteLine("2 – большее из двух чисел");
    Console.WriteLine("3 – факториал");
    Console.WriteLine("0 – выход");
    Console.Write("Выберите пункт: ");
    
    if (!int.TryParse(Console.ReadLine(), out choice)){
        Console.WriteLine("Нет такого пункта");
        choice = -1; 
        continue;
    }

    switch (choice){
        case 1:
            int a1 = ReadPositive("Введите первое число: ");
            int b1 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Сумма: {Sum(a1, b1)}");
            break;
        case 2:
            int a2 = ReadPositive("Введите первое число: ");
            int b2 = ReadPositive("Введите второе число: ");
            Console.WriteLine($"Большее число: {Max(a2, b2)}");
            break;
        case 3:
            int n = ReadPositive("Введите число для факториала: ");
            Console.WriteLine($"Факториал: {Factorial(n)}");
            break;
        case 0:
            Console.WriteLine("Выход из программы.");
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}



static int Sum(int a, int b) {
    return a + b;
}

static int Max(int a, int b) {
    return a > b ? a : b;
}

static long Factorial(int n) {
    long result = 1;
    for (int i = 1; i <= n; i++) result *= i;
    return result;
}

static int ReadPositive(string message) {
    int value = 0;
    bool isValid = false;

    while (!isValid){
        Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out value) && value > 0){
            isValid = true;
        }
    }
    
    return value;
}
