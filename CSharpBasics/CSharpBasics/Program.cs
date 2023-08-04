
#region declaringVariables

double doubleVariable = 5.6d;
int intVariable = 5;
decimal decimalVariable = 126555m;
float floatVariable = -548.7f;
bool boolVariable = false;
string stringVariable = "new string";
char charVariable = 'a';

#endregion


#region Implicit Casting

double fromIntToDouble = intVariable;
Console.WriteLine("int to double value" + fromIntToDouble);

float fromIntToFloat = intVariable;

int fromCharToInt = charVariable;

#endregion


#region Explicit Casting

int fromFloatToInt = (int)floatVariable;

int fromDoubleToInt = (int)doubleVariable;

int decimalToInt = (int)decimalVariable;

Console.WriteLine(Convert.ToString(intVariable));    // Convert int to string
Console.WriteLine(Convert.ToDouble(intVariable));    // Convert int to double
Console.WriteLine(Convert.ToInt32(doubleVariable));  // Convert double to int
Console.WriteLine(Convert.ToString(boolVariable));   // Convert bool to string
//Console.WriteLine(Convert.ToInt32(stringVariable));   // Convert string to int

#endregion


#region Flow Control

//if
Console.WriteLine("Write First Number ");
var temperature1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write Second Number ");
var temperature2 = Convert.ToInt32(Console.ReadLine());

//a
if (temperature1 > 20 || temperature2 > 20)
    Console.WriteLine("One of the numbers is higher than 50");

//b
if (temperature1 <= 100 && temperature2 <= 100)
    Console.WriteLine("Both numbers are less than 100");



//if...else

//c
if (temperature1 <= 50)
    Console.WriteLine("First number is less or equal to 50");
else
{
    Console.WriteLine("First number is higher than 50");
}

if (temperature2 <= 50)
    Console.WriteLine("First number is less or equal to 50");
else
{
    Console.WriteLine("First number is higher than 50");
}


//if...elseif...else
//d

if (temperature1 == 0 || temperature1 <= 10.5)
    Console.WriteLine("Temperature is between 0 and 10.5");
else if (temperature1 == 11.5 || temperature1 <= 20.5)
    Console.WriteLine("Temperature is between 11.5 and 20.5");
else
    Console.WriteLine("Temperature is above 20.5");



//e
int number1, number2, number3;

Console.Write("Enter the number 1:");
number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number 2:");
number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number 3:");
number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2 && number1 > number3)
    Console.WriteLine("The number 1 is greatest");
else if (number2 > number1 && number2 > number3)
    Console.WriteLine("The number 2 is greatest");
else if (number3 > number1 && number3 > number2)
    Console.WriteLine("The number 3 is greatest");
else
    Console.WriteLine("Numbers equals");



//5
int number;

Console.Write("Number? ");
number = Convert.ToInt32(Console.ReadLine());

if ((number == 9) || (number == 10))
    Console.WriteLine("Sobresaliente");
else if ((number == 7) || (number == 8))
    Console.WriteLine("Notable");
else if (number == 6)
    Console.WriteLine("Bien");
else if (number == 5)
    Console.WriteLine("Aprobado");
else if ((number >= 0) && (number <= 4))
    Console.WriteLine("Suspenso");
else
    Console.WriteLine("No válido");

switch (number)
{
    case 0:
    case 1:
    case 2:
    case 3:
    case 4:
        Console.WriteLine("Suspenso");
        break;
    case 5:
        Console.WriteLine("Aprobado");
        break;
    case 6:
        Console.WriteLine("Bien");
        break;
    case 7: goto case 8;
    case 8:
        Console.WriteLine("Notable");
        break;
    case 9:
        Console.WriteLine("Bajo, pero... ");
        goto case 10;
    case 10:
        Console.WriteLine("Sobresaliente");
        break;
    default:
        Console.WriteLine("Nota no válida");
        break;
}

//7 3 ways
for (int i = 10; i <= 20; i += 2)
{
    if (i == 16)
        continue;
    Console.WriteLine(i);
}

for (int i = 10; i <= 20; i++)
{
    if (i % 2 == 1)
        continue;
    if (i == 16)
        continue;
    Console.WriteLine(i);
}

for (int i = 10; ; i += 2)
{
    if (i == 16)
        continue;
    if (i > 20)
        break;
    Console.WriteLine(i);

}

//8
int num, amount;
int increment;

Console.Write("Enter a number: ");
num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter an amount: ");
amount = Convert.ToInt32(Console.ReadLine());

for (increment = 0; increment < amount; increment++)
    Console.Write(num);


Console.WriteLine();

increment = 0;
while (increment < amount)
{
    Console.Write(num);
    increment++;
}


Console.WriteLine();

increment = 0;
do
{
    Console.Write(num);
    increment++;
}
while (increment < amount);


#endregion
