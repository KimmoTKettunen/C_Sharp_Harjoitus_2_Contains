using System.ComponentModel.Design;

namespace substring_Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Check whether a given substring is present in the given string: ");
            Console.WriteLine("--------------------------------------------------------------------");

            Console.Write("Input the string: ");
            string lause1 = Console.ReadLine();  // konsoli lukee ja tallentaa syötetyn arvon myöhempää contains komentoa varten
            Console.Write("Input the substring to search: ");
            string lause2 = Console.ReadLine();  // konsoli lukee ja tallentaa syötetyn arvon myöhempää contains komentoa varten



            // Console.WriteLine(lause1.Contains(lause2));
            if (lause1.Contains(lause2))  // contains komennolla tarkistetaan, sisältääkö Lause 1 lauseen 2
                                              // Esim. jos lause 1 on "Koirat ovat kivoja"  ja lause 2 on "kivoja" niin pitää paikkansa.
                { 
                Console.WriteLine("The substring exists in the string"); // koska pitää paikkansa, niin tulostaa tämän
                }
                 else
            {                                                                    // jos lause 2 olisi jotain, mitä lause 1 ei sisällä kuten "kissat"                                 
                Console.WriteLine("The substring does not exist in the string"); // niin contains komento palauttaisi boolean false ja tulostaisi tämän tekstin
            }   
            
           
            
            
            Console.ReadLine();
        }
    }
}
