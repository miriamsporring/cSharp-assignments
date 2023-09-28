using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using ChoirApplication.Models;

namespace ChoirApplication.Services;

internal class MenuService
{
    private readonly MemberService _memberService = new MemberService();

    public void MainMenu()  //fungerar inte, hoppar över, skriver inte ut nånting, går direkt in i AddMemberMenu från MemberService
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Anmäl dig till kören \n");

            Console.WriteLine("2. Visa en specifik medlem \n");

            Console.WriteLine("3. Visa alla medlemmar \n");

            Console.WriteLine("0. Avsluta\n");

            Console.WriteLine("Välj ett av ovanstående alternativ (0-4: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddMemberMenu();
                    break;

                default:
                    break;
            }


        }while (exit == false);
    }




    //Lägg till medlem case 1
    public void AddMemberMenu() //CreateMenu: funktion - anmäler ny medlem
    {
        var member = new Member();

        Console.Write("Förnamn: ");
        member.FirstName = Console.ReadLine()!;

        Console.Write("Efternamn: ");
        member.LastName = Console.ReadLine()!;

        Console.Write("Email: ");
        member.Email = Console.ReadLine()!;

        _memberService.AddMemberToList(member);

    }


    
}

