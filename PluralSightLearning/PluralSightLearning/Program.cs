//class Program {
//    static int Main(String[] args) 
//    {
//        Console.WriteLine("Hello, World!");
//        for (var n = 0; n < args.Length; n++)
//        {
//            Console.WriteLine("args{n}) = {1}", n, args[n]);
//    }
//        return 0; 
//    }
//}

//class Program
//{
//    static void Main(string[] args) 
//    {
//        var numbers = new int[] { 1, 2, 3};
//        var sum = 0;

//        for (var n = 0; n < numbers.Length; n++)
//        {
//            sum += numbers[n];
//        }
//        Console.WriteLine(sum);
//    }
//}

//Demonstração da resiliencia e segurança do c#.
//using MyUtilities;<-- uso explicito

//namespace PluralSightLearning
//{
//   class CheckComfort
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Where should we go in May");
//            WeatherUtilities.Report("San Franscisco", WeatherUtilities.FarenheitToCelsius(65), 73);
//            WeatherUtilities.Report("Denver", WeatherUtilities.FarenheitToCelsius(77),55);
//           WeatherUtilities.Report("Bologna", 23, 65); // ~73 F
//        }
//    } -----> Programa desenvolvido em conjunto com WaetherUtilities.
//} 
Console.WriteLine("Bem vindo ao sistema");
int monthlyWage = 1234, months = 12, bonus = 1000;

var isActive = true; //bool

var rating = 99.25; //double

//byte numberOfEmployees = 300; <- "byte" não suporta 300.

int hoursWorked;

hoursWorked = 125;

hoursWorked = 148;

//monthlyWage = true; <- impossivel pois o tipo é "int" não "bool".

const double interestRate = 0.07;

//interestRate = 1;

string firstName = "Gabriel";
string lastName = "Oliveira";

string emptyString = "";

//Console.WriteLine(firstName + " " + lastName);
Console.WriteLine($"{firstName} {lastName}");


double ratePerHour = 12.34;
int numberOfHoursWorked = 165;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bonus;
Console.WriteLine(currentMonthWage);

ratePerHour += 3; // <--- é igual: ratePerHour = ratePerHour + 3;.
Console.WriteLine(ratePerHour);

if (currentMonthWage >= 2000)
    Console.WriteLine("Funcionario mais bem pago");

int numberOfEmployees = 15;
numberOfEmployees--; // ou ++ para adicionar.

//Console.WriteLine(numberOfEmployees);


//bool a; <-- valor automatico: false.
//int b; <-- valor automatico: 0.


int intMaxValue = int.MaxValue;
int intMinValue = int.MinValue;


char userSelection = 'a';
char upperVersion = char.ToUpper(userSelection); // A

bool isDigir = char.IsDigit(userSelection); // false

bool isLetter = char.IsLetter(userSelection); // true


DateTime hireDate = new(2022, 3, 28, 14, 30, 0);
//Console.WriteLine(hireDate);

DateTime exitDate = new(2025, 12, 11);

//DateTime invalidDate = new(2025, 15, 11); <-- reconhece uma data inválida.

DateTime startDate = hireDate.AddDays(15);
//Console.WriteLine(startDate);

DateTime currentDate = DateTime.Now;
bool areWeInDst = currentDate.IsDaylightSavingTime();

var startHour = DateTime.Now; // também pode usar var, porem dificulda o entendimento do código.
TimeSpan workTime = new TimeSpan(8, 35, 0);
DateTime endHour = startHour.Add(workTime);

//Console.WriteLine(startHour.ToLongTimeString()); <-- Pode convereter a data para preferência.
//Console.WriteLine(endHour.ToShortTimeString());

long veryLongMonth = numberOfHoursWorked; // Funcionar por "long" pode receber um "int".

double d = 123456789.0;

int x = (int)d; //<-- "(int)" está deixando explicito que vamos forçar a conversão, podendo perder dados.

int intVeryLongMonth = (int)veryLongMonth;


//var a = 123; /C# entende que é um "int"
//var b = true; /C# entende que é um "bool"
//var c = 12.43; /C# entende que é um "double"