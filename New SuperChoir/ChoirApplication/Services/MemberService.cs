using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class MemberService
{
    private List<Member> _memberList = new List<Member>(); //listan skapas

    public MemberService()
    {
        GetMembers(); //varje gång programmet startas hämtas medlemmarna
    }


    //Lägg till medlem i listan
    public void AddMemberToList(Member member)
    {

        _memberList.Add(member);

        var json = JsonConvert.SerializeObject(_memberList);
        FileService.SaveToFile(json); //listan skrivs till fil
    }

    //Visa medlemmar
    public List<Member> GetMembers()

    {
        var content = FileService.ReadFromFile();

        if (!string.IsNullOrEmpty(content))
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!;

        return _memberList;
    }

    //Visa specifik medlem
    public Member ViewSpecificMember(string email)
    {
        var member = _memberList.FirstOrDefault(x => x.Email == email);
        return member ?? null!;
    }



    //Ta bort medlem
    public void RemoveMember(string email)
    {

        var member = _memberList.FirstOrDefault(x => x.Email == email);
        

        if (member != null)
        
                _memberList.Remove(member);

                var json = JsonConvert.SerializeObject(_memberList);
                FileService.SaveToFile(json); //listan skrivs till fil
            
    }

}

