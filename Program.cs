Console.WriteLine("1. Doira yuzini aniqlash");
Console.WriteLine("1. Silindr hajmini aniqlash\n");
Console.Write("Tanlovingizni kiriting : ");
string input = Console.ReadLine();
switch(input)
{
    case "1" : 
        {
            Console.Write("R = ");
            string strRadius = Console.ReadLine();
            double radius = Convert.ToDouble(strRadius);
            Console.WriteLine($"R = {strRadius} bo'lsa S = {Math.PI * radius * radius}");
        }
        break;
    case "2" :
        {
            Console.Write("R = ");
            string strRadius = Console.ReadLine();
            Console.Write("H = ");
            string strHigh = Console.ReadLine();
            double radius = Convert.ToDouble(strRadius);
            double high = Convert.ToDouble(strHigh);
            Console.WriteLine($"Silindrning hajmi {Math.PI * radius * radius * high}");
        }
        break;
}