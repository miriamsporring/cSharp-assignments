using System.ComponentModel.DataAnnotations;
using ChoirApplication.Models;

namespace ChoirApplication.Services;

/*MenuService presenterar menyn samt tar in och dirigerar menyvalen till respektive ställe.
 Därifrån hämtas funktionerna från MemberService*/

public class MenuService 
{
    private MemberService _memberService = new MemberService();

    /*
    MainMenu - skriver ut menyvalen för programmet
    Valen är uppbyggda med en do-while-loop som innehåller switch (option -> case,break) som hänvisar vidare till de olika menyvalen.
     */
    public void MainMenu()  
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Varmt välkommen till Super Choir!");
            Console.WriteLine("_________________________________\n");
            Console.WriteLine("1. Lägg till en medlem \n");
            Console.WriteLine("2. Visa alla medlemmar \n");
            Console.WriteLine("3. Visa en specifik medlem \n");
            Console.WriteLine("4. Ta bort en medlem ur listan \n");
            Console.WriteLine("0. Avsluta programmet\n");
            Console.WriteLine("Välj ett av ovanstående alternativ (0-4): ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    AddMemberMenu();
                    break;

                case "2":
                    ViewAllMembers();
                    break; 
              
                case "3":
                    ViewSpecificMember(); 
                    break;

                case "4":
                    RemoveMember(); 
                    break;


                case "0":
                    exit = true;
                    break;
            }

        }while (exit == false);

    }

    //Case 1 - lägg till en medlem 
    public void AddMemberMenu() 
    {
        var member = new Member();

        Console.Clear();
        Console.WriteLine("Lägg till en medlem");
        Console.WriteLine("___________________\n");

        Console.Write("Förnamn: ");
        member.FirstName = Console.ReadLine()!;

        Console.Write("Efternamn: ");
        member.LastName = Console.ReadLine()!;

        Console.Write("Telefonnummer: ");
        member.PhoneNumber = Console.ReadLine()!;

        Console.Write("Epost: ");
        member.Email = Console.ReadLine()!;

        _memberService.AddMemberToList(member);

        /*
        Jag har försökt lägga till en if-else för att meddela om personen redan finns med i kören.
        Lyckades med if-satsen: att skriva ut att medlemmen redan finns med; 
        else-satsen fungerade inte, medlemmen skrevs ändå in i filen.
        G for trying :)
        */

        Console.Clear() ;
        Console.WriteLine("Medlemmen är tillagd");
        Console.ReadKey();
    }

    //Case 2 - visa alla medlemmar
    private void ViewAllMembers()       
    {
        Console.Clear();
        Console.WriteLine("Visa alla medlemmar");
        Console.WriteLine("___________________\n");

        /*
        Visar medlemmarnas alla uppgifter så snyggt och prydligt som en konsollapplikation medger,
        dvs med till exempel radbyten och nån snajdig rad mellan varje medlem :)
        */
        foreach (var member in _memberService.GetMembers()) 
            Console.WriteLine($"{member.FirstName} {member.LastName} \nTel: {member.PhoneNumber} \nEpost:{member.Email} \n\n-*-*-*-*-*-*-*-*-*-*-*\n");
            Console.ReadKey();
    }

    //case 3 - visa specifik medlem
    private void ViewSpecificMember()   
    {
          
        Console.Clear();
        Console.WriteLine("Visa en specifik medlem");
        Console.WriteLine("_______________________\n");

        Console.WriteLine("Ange epostadress: ");
        var email = Console.ReadLine();

        Console.Clear();
        var member = _memberService.ViewSpecificMember(email!);

        //om medlemmen inte finns med
        if (email == null || member == null)
            
            Console.WriteLine("Personen är inte medlem i kören");

        //om medlemmen finns med, skriv ut
        else

            Console.WriteLine($"{member.FirstName} {member.LastName} \nTel: {member.PhoneNumber} \nEpost:{member.Email}");

        Console.ReadKey();
    }

    //Case 4 - ta bort medlem
    private void RemoveMember()   
    {
        Console.Clear();
        Console.WriteLine("Ta bort en medlem ur listan");
        Console.WriteLine("___________________________\n");

        Console.WriteLine("Ange epostadress: ");
        var email = Console.ReadLine();


        if (!string.IsNullOrEmpty(email))
        {
            //söker medlemmen via epostadress, tar bort
            var member = _memberService.ViewSpecificMember(email); 
            if (member != null)
            {
                _memberService.RemoveMember(email);

                Console.Clear();
                Console.WriteLine("Medlemmen är borttagen");

            }
            //om personen inte finns med
            else
            {
                Console.Clear();
                Console.WriteLine("Personen är inte medlem i kören");
            }
        }
        //om ingen epostadress fyllts i
        else
            Console.WriteLine("Du måste ange en e-postadress");

        Console.ReadKey();
    }

}