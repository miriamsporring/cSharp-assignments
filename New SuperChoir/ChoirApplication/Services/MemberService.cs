using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class MemberService
{
    private List<Member> _memberList = new List<Member>(); //listan skapas

    public void AddMemberToList(Member member)
    {
        _memberList.Add(member);

        var json = JsonConvert.SerializeObject(_memberList);
        FileService.SaveToFile(json); //listan skrivs till fil
    }

    public void GetMembers()

    {
        var content = FileService.ReadFromFile();



        if (!string.IsNullOrEmpty(content))
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!; //listan skrev inte över den existerande filen, bara fyllde på den1/10 13:00
        
        
        foreach(var member in _memberList)
        {
            Console.WriteLine($"{member.FirstName} {member.LastName} <{member.Email}>");
        }

        //Console.WriteLine();
        //Console.ReadKey();

    }




    //private static readonly string filePath = @"c:\Code\members.json";
    //public void ReadFromFile(string filePath)
    //{
    //    using var sw = new StreamReader(filePath); //hur får jag ut det i menuservice?
    //    var content = sw.ReadToEnd();
    //    Console.ReadLine();

    //}






    //internal void ViewAllMembers(object member)
    //{
    //    string filePath = @"c:\Code\members.json"; // Ange sökvägen till din fil

    //    try
    //    {
    //        // Öppna filen för läsning med hjälp av StreamReader
    //        using (StreamReader sr = new StreamReader(filePath))
    //        {
    //            // Läs innehållet av filen
    //            string fileContent = sr.ReadToEnd();

    //            // Visa innehållet på konsolen
    //            Console.WriteLine("Alla medlemmar i kören:");
    //            Console.WriteLine(fileContent);
    //        }
    //    }
    //    catch (IOException e)
    //    {
    //        Console.WriteLine("Ett fel uppstod när filen skulle läsas: " + e.Message);
    //    }
    //}

}
