using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

//I klassen MemberService skapas metoderna
internal class MemberService
{
    //Skapar listan
    private List<Member> _memberList = new List<Member>();     
    public MemberService()
    {
        //Varje gång programmet startar hämtas medlemmarna från filen
        GetMembers(); 
    }

    
    //Lägger till medlem i filen _memberList
    public void AddMemberToList(Member member)
    {

        _memberList.Add(member);

        //listan skrivs till fil
        var json = JsonConvert.SerializeObject(_memberList);
        FileService.SaveToFile(json); 
    }

    
    //Visar alla medlemmar, hämtar från _memberList
    public List<Member> GetMembers()

    {
        //Sökvägen nedan behöver finnas med för att enhetstestet ska fungera
        var content = FileService.ReadFromFile(@"c:\Code\members.json"); 
        

        //listan hämtas ur fil
        if (!string.IsNullOrEmpty(content))
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!;

        return _memberList;
    }

    
    //Visar specifik medlem från _memberList
    public Member ViewSpecificMember(string email)
    {
        var member = _memberList.FirstOrDefault(x => x.Email == email);
        return member ?? null!;
    }
    
    
    //Tar bort medlem ur _memberList
    public void RemoveMember(string email)
    {
        //Personen söks i _memberList
        var member = _memberList.FirstOrDefault(x => x.Email == email);

        //Om personen finns i listan tas den bort
        if (member != null)
        {
            _memberList.Remove(member);

            //Den ny listan skrivs till fil  
            var json = JsonConvert.SerializeObject(_memberList);
            FileService.SaveToFile(json);
        }
    }

}

