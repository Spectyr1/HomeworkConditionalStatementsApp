

int age;
int ageOlder;
int ageYounger;


Console.Write("Hello, please enter your current age: ");
age = Int32.Parse(Console.ReadLine());
ageOlder = age + 25;
ageYounger = age - 25;

Console.WriteLine($"Based on your current age of {age}, you will be {ageOlder} in 25 years. Our math also shows that you were {ageYounger}, 25 years ago.");
Console.ReadLine();
