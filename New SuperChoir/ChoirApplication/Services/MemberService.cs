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
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!; 
        
        
        foreach(var member in _memberList)
        {
            Console.WriteLine($"Namn: {member.FirstName} {member.LastName}\nTele: {member.PhoneNumber} \nEpost: <{member.Email}>\n___________________\n");
        }


    }


}
