using System.Text.RegularExpressions;

List<string> Name = [];
List<string> Points = [];
string option1;
string option2;

bool allDigits;


bool ContainsNumbers(string input)
{
    return Regex.IsMatch(input, @"\d");
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Välj Namn (mellan 3-14 karactärer, utan siffror)");
    option1 = Console.ReadLine();

    while (option1.Length < 3 || option1.Length > 15 || ContainsNumbers(option1))
    {
        // om namnet är för kort
        if (option1.Length < 3)
        {
            Console.WriteLine("Namn är för kort, försök igen");
            option1 = Console.ReadLine();
        }
        // om namnet är längre än 14
        else if (option1.Length > 15)
        {
            Console.WriteLine("Namn är för långt, försök igen");
            option1 = Console.ReadLine();
        }
        // om namnet har siffror i sig
        else if (ContainsNumbers(option1))
        {
            Console.WriteLine("Namn har nummer i sig, försök igen");
            option1 = Console.ReadLine();
        }
    }
    Name.Add(option1);

    Console.WriteLine("Välj Poäng (bara siffor)");
    option2 = Console.ReadLine();

    allDigits = option2.All(char.IsDigit);

    while (allDigits == false)
    {
        
    }
    
}



for (int i = 0; i < Name.Count; i++)
{
    Console.Write(Points[i]);
    Console.Write("  ");
    Console.WriteLine(Name[i]);
}


Console.ReadLine();