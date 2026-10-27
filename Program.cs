using System.Formats.Asn1;
using System.Transactions;

namespace convertisseur_temp;

class Program
{
    static void Main(string[] args)
    {
        // Créez un programme sur console qui converti une température rentrée par l’utilisateur dans l’unité de son choix.
        // Deux sens de conversion doivent être possibles : soit de degrés Celsius vers Fahrenheit, soit de degrés Fahrenheit vers Celsius.
       
        double temp;
        double convertedtemp = 0;
    
        while (true)

        {
        System.Console.WriteLine("Do you wish to convert");
        System.Console.WriteLine("1: °C to °F");
        System.Console.WriteLine("2: °F to °C");
        string choice = System.Console.ReadLine();
        if(choice == "1")
            {
            System.Console.WriteLine("Enter the temperature you wish to convert:");
            temp =  Convert.ToInt32(System.Console.ReadLine());
            convertedtemp = (temp * 1.8) + 32;
            System.Console.WriteLine($"Your converted temperature is {convertedtemp}°F");
            }
        else if(choice == "2")
            {
            System.Console.WriteLine("Enter the temperature you wish to convert:");
            temp =  Convert.ToInt32(System.Console.ReadLine());
            convertedtemp = (temp - 32) / 1.8;  
            System.Console.WriteLine($"Your converted temperature is {convertedtemp}°C");
            }
            System.Console.WriteLine("Do you wish to use the converter again? Y/N");
            string answer = Console.ReadLine();
            if (answer == "N"|| answer == "n")
            {
                break;
            }
        }
    }

}