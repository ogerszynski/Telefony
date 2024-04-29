using System;
using System.Text.RegularExpressions; //wyrazenia regularne

class Program // logika programu
{
    static void Main()
    {
        // pytamy usera o numer
        Console.WriteLine("Podaj numer telefonu:");
        string input = Console.ReadLine();
        // wywołanie funkcji
        string result = CheckNumber(input);
        // wyświetl rezultat
        Console.WriteLine(result);
    }

    // def funkcji
    static string CheckNumber(string input)
    {
        // oczyszczamy ciag znaków
        string cleanedNumber = Regex.Replace(input, "[^0-9]", "");
        // liczymy znaki czy 11 i czy od 0
        if (cleanedNumber.Length == 11 && cleanedNumber.StartsWith("0"))
        {
            return cleanedNumber;
        }
        else
        {
            return "To nie jest numer telefonu";
        }
    }
}
