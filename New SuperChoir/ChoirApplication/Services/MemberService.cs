using System.Security.Cryptography.X509Certificates;
using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class MemberService
{
    private List<Member> _memberList = new List<Member>(); //listan skapas



    //ADD MEMBER TO LIST - FUNGERAR
    public void AddMemberToList(Member member)
    {
        _memberList.Add(member);

        var json = JsonConvert.SerializeObject(_memberList);
        FileService.SaveToFile(json); //listan skrivs till fil
    }

    //GET MEMBERS - FUNGERAR
    public List<Member> GetMembers()

    {
        var content = FileService.ReadFromFile();

        if (!string.IsNullOrEmpty(content))
            _memberList = JsonConvert.DeserializeObject<List<Member>>(content)!;

        return _memberList;
    }

    //VIEW SPECIFIC MEMBER - TO DO
    public Member ViewSpecificMember(string email)
    {
        Console.Clear();

        var member = _memberList.FirstOrDefault(x => x.Email == email);
        return member ?? null!;
    }



    //REMOVE MEMBER - TO DO
    public Member RemoveMember(string email)
    {
       
        //var member = _memberList.FirstOrDefault(x => x.Email == email);
        
        //RemoveMember(email!);
        return (null!);
    }




}

