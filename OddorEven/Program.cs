

Console.WriteLine("Please Enter a Number:");
int userNum = Convert.ToInt32(Console.ReadLine());

// Kas kasutaja arv on paaris või paaritu

int result = userNum % 2;

if (result != 0) // ! = ei ole võrdne - eitus
{
    Console.WriteLine("User Number is odd.");
}
else
{
    Console.WriteLine("User Number is even.");
}