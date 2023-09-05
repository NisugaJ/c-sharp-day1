// Note: Uncomment required section before executing

// 1. Output
//Console.WriteLine("Hello Nisuga");

// 2. Input
// string? x = Console.ReadLine();
// Console.WriteLine(x);


// 3. Use below to stop terminal from automatically closing
// Console.ReadKey();





// variables -------------------


// decimal means the base is 10. decimals have a large precision than any other built-in binary floating point types.


//char gender = 'F';

/** 4. Literals & Variable **//**
// literals are hardcoded values
console.writeline(12.3m); // decimal
console.writeline('c');
console.writeline("lorem lorem ipsum");
console.writeline(true && false);
**//**
string s1 = "Nisuga";
bool orderSubmitted = true;
int userId = 45678;
**//**
decimal veganPoplulation = 12.32m;
decimal deci = 0.00000000000030000m;
double dbl = 0.00000000000030000;
while (deci != 0m)
{
    Console.WriteLine(deci);
    deci = deci / 5m;
}

while (dbl != 0)
{
    Console.WriteLine(dbl);
    dbl = dbl / 5;
}
**//**
var multitypevar = "abscs"; // must be intilized when implicitly declaring a variable. (implcityly means declraing without the variable type. the type of the initialized value be taken as the type of the variable.)
string rr; // can be declare without initizlizing with a value because we are explicitly providing the type as string.
rr = "uywehjb";
console.writeline(multitypevar);
console.writeline(rr);
**//** 5. Formatting strings **//**
Console.WriteLine("Hello\nWorld");
Console.WriteLine("Hello\tWorld");

Console.Write("Hello: Nisuga");
Console.Write("\nWelcome to C#");
Console.Write("\nCall me \"Microsoft Bot\"");
Console.Write("\n Find the key file in C:\\Users\\nisuga\n");
Console.WriteLine(@"Find the key file in C:\Users\nisuga"); // easy way to escape characters in C#
string sss = @"Find the key file in C:\Users\nisuga";
Console.WriteLine(sss);

// String interpolation
string name = "Nisuag";
string msg = $"Hello, {name}. Today is {DateTime.Now}";
Console.WriteLine(msg);
**//** 6. Conditions **//**
var dice = new Random();

var roll1 = dice.Next(1, 7);
var roll2 = dice.Next(1, 7);
var roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"You have {roll1} + {roll2} + {roll3} = {total}");

// if else block
if (total > 14)
    Console.WriteLine("Greater than 14. You have won");
else
    Console.WriteLine("You lost");
**//** 7. Looooooops **//**
string[] arr1 = new string[5];

int[] inventory = { 10, 100, 500, 800, 200 };
int total = 0;
foreach (int item in inventory)
{
    total += item;
    Console.WriteLine(item);

}

Console.WriteLine($"Total is {total}");

**//**
for (int i = 0; i < 99; i++)
{
    Console.WriteLine(i);
}
**//**
int i2 = 0;
while(i2 < 100)
{
    Console.WriteLine(i2);
    i2++;
}
**//**
int i3 = 100;
do // always executes first loop
{
    Console.WriteLine(i3);
    i3 /= 3;
} while (i3 > 1);
**/

/** 8. Switch statements**//**
int i = new Random(0).Next(1,10);
Console.WriteLine($"i is {i}");

switch (i)
{
    case 0:
        Console.WriteLine("0");
        break;
    case < 0:
    case > 5:
        Console.WriteLine("Out of range");
        break;
    default:
        Console.WriteLine($"Value is {i}");
        break;
}
**/

/** 9. Switch statements with Case Guard **/
/**
int a = 55;
int b = 59;

switch (a, b)
{
    case (>0, >0) when a == b:  // case guard
        Console.WriteLine("a & b are valid and they are Equal values");
        break;
    case ( > 0, > 0):
        Console.WriteLine("a & b are valid but not Equal values");
        break;
    default:
        Console.WriteLine("a & b are not valid values");
        break;
}
**/

/** 10. Switch expressions for value pattern matching **/
/**
string color = "r"; // red
var result = color switch
{
    "r" => "Color is red",
    "g" => "Color is green",
    "b" => "Color is blue",
    _ => "Color is unknown"
};
Console.WriteLine(result);
**/

/** 10. Switch expressions for type pattern matching **/
/**
string CheckType(object val) => val switch
{
    int => "Integer Type",
    string => "String Type",
    double => "Double Type",
    float => "Float Type",
    Array => "Array Type",
    List<string> => "List<string> Type",
    _ => "Other Type"
};

Console.WriteLine(CheckType(23.321m));
Console.WriteLine(CheckType("test"));
Console.WriteLine(CheckType( new int[]{1,2,3}) );
Console.WriteLine(CheckType( new List<string>{"abc", "def"}) );
**/

/** 10. Switch expressions for logical pattern matching **/
/**
var numbers = new List<int> { 1,2,3,-4,5,-6,-7,8,};
foreach (var num in numbers)
{
    var result = num switch
    {
        > 0 => "Positive number",
        0 => "Zero",
        < 0 => "Negative number",
    };
    Console.WriteLine(result);
}
**/

/** 11. Switch expressions with when guards **/
/**
var people = new List<Member>
{
    new("John","Doe", 44),
    new Member("Johnny", "Depp", 39),
    new("Nish","Jay", 25),
    new("Ryan", "Michael",13)
};
string CheckMember(Member person)
{
    return person switch
    {
        { Age: var age } when age < 18 => "Minor aged person",
         _ => "Adult"
    };
}

Console.WriteLine(CheckMember(people[0]));
**/

/** 12. OOP **/
using CSharpDay1;
/**
BankAccount acc1 = new BankAccount("Nisuga J", 50000);
BankAccount acc2 = new BankAccount("Nish J", 500);

Console.WriteLine(acc1.Number);
Console.WriteLine(acc2.Number);

acc1.MakeDeposit(35000, DateTime.Now, "Salary");
acc1.Withdraw(5000, DateTime.Now, "Taxi");
acc1.Withdraw(4000, DateTime.Now, "McDonalds");

Console.WriteLine(acc1.Balance);
Console.WriteLine(acc1.GetAccountStatement());
**/

/**
Person person = new Person()
{
    FirstName = "Nisuga",
    LastName = "Jayawardana",
    BasicSalary = 100000
};

person.PrintDetails();
**/

/**
// Class inheritance
//  base class  methods with 'virtual' keyword can be overriden by a sub class.

using CSharpDay1.inheritance;

Student ryan = new Student()  // Student class inherits from Audit class
{
    Id = "65132",
    FullName = "Ryan Bolt",
    Created = DateTime.Now,
    CreatedById = "65132"
};

Console.WriteLine(ryan.GetDetails());

**/






//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
//---------------------------------
Console.ReadKey();


// namespaces and type declarations
record Member(string FirstName, string LastName, int Age);

