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



double c1 = 0;
double f1 = ToFahrenheit(c1);
Console.WriteLine($"{c1} °C = {f1} °F");

double c2 = 100;
double f2 = ToFahrenheit(c2);
Console.WriteLine($"{c2} °C = {f2} °F"); 

double c3 = 37;
double f3 = ToFahrenheit(c3);
Console.WriteLine($"{c3} °C = {f3} °F"); 

static double Average(int[] arr) { double sum = 0; foreach (int x in arr) sum += x; return sum / arr.Length; }
static int CountGreater(int[] arr, int limit) { int count = 0; foreach (int x in arr) if (x > limit) count++; return count; }

static double ToFahrenheit(double celsius){
    return celsius * 9 / 5 + 32;
}