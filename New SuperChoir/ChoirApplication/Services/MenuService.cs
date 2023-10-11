using ChoirApplication.Models;

namespace ChoirApplication.Services;

internal class MenuService
{
    private MemberService _memberService = new MemberService();

    //för min egen skull i mitt första egna projekt har jag lagt de olika menyalternativen under varann för att lätt se dem i ordning.
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

        foreach (var member in _memberService.GetMembers())
            Console.WriteLine($"{member.FirstName} {member.LastName}");

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

        if (email == null || member == null)

            Console.WriteLine("Personen är inte medlem i kören");

        else
            Console.WriteLine($"{member.FirstName} {member.LastName}");


        Console.ReadKey();
    }

    //Case 4 - ta bort medlem
    private void RemoveMember()   //tar bort oavsett om medlemmen finns
    {
        Console.Clear();
        Console.WriteLine("Ta bort en medlem ur listan");
        Console.WriteLine("___________________________\n");

        Console.WriteLine("Ange epostadress: ");
        var email = Console.ReadLine();


        if (!string.IsNullOrEmpty(email))
        {
            var member = _memberService.ViewSpecificMember(email);
            if (member != null)
            {
                _memberService.RemoveMember(email);

                Console.Clear();
                Console.WriteLine("Medlemmen är borttagen");

            } 
            else
            {
                Console.WriteLine("Personen är inte medlem i kören");
            }
        }
        else
            Console.WriteLine("Du måste ange en e-postadress");

        Console.ReadKey();

    }

}