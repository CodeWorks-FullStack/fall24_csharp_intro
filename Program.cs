Console.Clear();
Console.WriteLine("Hello, World!");
Console.WriteLine("What is up class");

string firstName = "Jeremy";
char doubleQuote = '"';
char middleInitial = 'B';
string lastName = "Fowler";
string fullName = firstName + middleInitial + lastName;
Console.WriteLine($"My name is {firstName} {middleInitial} {lastName}.");

int age = 34;

// explicit type
double moneyInPocket = 23.5;

// implicit type
var weirdNumber = age + moneyInPocket;
age++;
age--;

// NOT ALLOWED
// age += 10.3;

bool ateBreakfast = false;
bool cameToWork = true;

if (ateBreakfast)
{
  Console.WriteLine("Jeremy is in a good mood and will be helpful during lab");
}
else
{
  Console.WriteLine("Jeremy is going to pass you off to Jake because he ain't got time for your nonsense");
}

// if (age) NO TRUTHY FALSY IN C#
if (age > 33 && !ateBreakfast)
{
  Console.WriteLine("Jeremy is tired and should have eaten breakfast");
}


string nameThatDoesNotExist; // null
int numberThatDoesNotExist; // 0
bool boolThatDoesNotExist; // false

// NOTE arrays are stupid
string[] favoriteFoods = ["Hot wings", "Macaroni and cheese", "Tom Yum soup"];

Console.WriteLine(favoriteFoods[0]);

for (int i = 0; i < favoriteFoods.Length; i++)
{
  string food = favoriteFoods[i];
  Console.WriteLine(food);
}

