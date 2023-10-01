using ChoirApplication.Models;

namespace ChoirApplication.Services;

internal class MenuService
{
    private MemberService _memberService = new MemberService();

    public void MainMenu()  
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("Varmt välkommen till Super Choir!");
            Console.WriteLine("_________________________________\n");
            Console.WriteLine("1. Anmäl dig till kören \n");
            Console.WriteLine("2. Visa alla medlemmar \n");
            Console.WriteLine("3. Visa en specifik medlem \n");
            Console.WriteLine("4. Ta bort medlem ur listan \n");
            Console.WriteLine("0. Avsluta\n");
            Console.WriteLine("Välj ett av ovanstående alternativ (0-4): ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    AddMemberMenu(); //Fungerar , if-else någonstans ang hur full kören är - VÄNTA MED DET, GÖR ALLT ANNAT KLART FÖRST
                    break;

                case "2":
                    ViewAllMembers(); //Hittar caset, ska utveckas, hur? från lista
                    break; 

              
                case "3":
                    ViewSpecificMember(); //Hittar caset, ska utvecklas, hur? från lista via epost, hur?
                    break;

                case "4":
                    RemoveMember(); //Hittar caset, ska utveckas, hur? hitta från lista via epost, sen ta bort
                    break;


                case "0":
                    exit = true; //Fungerar
                    break;
            }

        }while (exit == false);

    }



    //Lägg till medlem case 1
    public void AddMemberMenu() //CreateMenu: funktion - anmäler ny medlem - FUNGERAR, jihooo
    {
        var member = new Member();

        Console.Write("Förnamn: ");
        member.FirstName = Console.ReadLine()!;

        Console.Write("Efternamn: ");
        member.LastName = Console.ReadLine()!;

        Console.Write("Telefonnummer: ");
        member.PhoneNumber = Console.ReadLine()!;

        Console.Write("Epost: ");
        member.Email = Console.ReadLine()!;
 
        _memberService.AddMemberToList(member);

        
    }

    //Case 2 - visa alla medlemmar
    private void ViewAllMembers()         //hur hämta från lista, via MemberService, FUNGERAR igen!!! 1/10
    {
        Console.WriteLine("Visa alla medlemmar");

        _memberService.GetMembers();

        Console.WriteLine();
        Console.ReadKey();

    }

    //case 3 - visa specifik medlem
    private void ViewSpecificMember()   
    {

        Console.WriteLine("Visa en specifik medlem");

        Console.WriteLine("Ange epostadress: ");
        Console.ReadKey();
        _memberService.GetMembers();


    }

    


    //Case 4 - ta bort medlem
    private void RemoveMember()        //hur hämta från lista, via MemberService???
    {

        Console.WriteLine("Ta bort medlem ur listan");
        Console.ReadLine();
    }

}
