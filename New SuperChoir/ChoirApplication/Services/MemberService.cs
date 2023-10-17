using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class MemberService
{
    //Skapar listan
    private List<Member> _memberList = new List<Member>(); 

    public MemberService()
    {
        GetMembers(); //Varje gång programmet startar hämtas medlemmarna från filen
    }

    //Lägger till medlem i listan
    public void AddMemberToList(Member member)
    {

        _memberList.Add(member);

        var json = JsonConvert.SerializeObject(_memberList);
        FileService.SaveToFile(json); //listan skrivs till fil
    }

    //Visar medlemmar
    public List<Member> GetMembers()

    {

        var content = FileService.ReadFromFile(@"c:\Code\members.json"); //Sökvägen behöver finnas med här!
        

        if (!string.IsNullOrEmpty(content))
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!;

        return _memberList;
    }

    //Visar specifik medlem
    public Member ViewSpecificMember(string email)
    {
        var member = _memberList.FirstOrDefault(x => x.Email == email);
        return member ?? null!;
    }
    
    //Tar bort medlem
    public void RemoveMember(string email)
    {

        var member = _memberList.FirstOrDefault(x => x.Email == email);
        

        if (member != null)
        
                _memberList.Remove(member);

                var json = JsonConvert.SerializeObject(_memberList);
                FileService.SaveToFile(json); //listan skrivs till fil           
    }

}

