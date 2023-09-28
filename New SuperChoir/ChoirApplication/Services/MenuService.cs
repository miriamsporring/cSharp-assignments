using System.ComponentModel.Design;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using ChoirApplication.Models;

namespace ChoirApplication.Services;

internal class MenuService
{
    private readonly MemberService _memberService = new MemberService();

    public void MainMenu()  //fungerar inte, hoppar över, skriver inte ut nånting, går direkt in i AddMemberMenu från MemberService
                            //Förmodligen eftersom programmet inte länkar hit? Bara till AddMemberMenu.
    {
        var exit = false;

        do
        {
            Console.Clear();
            Console.WriteLine("1. Anmäl dig till kören \n");

            Console.WriteLine("2. Visa en specifik medlem \n");

            Console.WriteLine("3. Visa alla medlemmar \n");

            Console.WriteLine("0. Avsluta\n");

            Console.WriteLine("Välj ett av ovanstående alternativ (0-3: ");
            var option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddMemberMenu();
                    break;
                case "2":
                    ViewSpecificMember(); //Fungerar inte 
                    break;
              
                case "3": 
                    ViewAllMembers(); //Fungerar inte 
                    break;


                case "0":
                    exit = true; //Fungerar
                    break;

            }


        }while (exit == false);
    }
 
    private void ViewSpecificMember()   //Ska visa specifik medlem
    {
        
    }

    private static void ViewAllMembers()   //Ska visa alla medlemmar
    {
        
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

