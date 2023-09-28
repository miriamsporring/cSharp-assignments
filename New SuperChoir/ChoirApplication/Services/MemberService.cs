using System.Runtime.CompilerServices;
using ChoirApplication.Models;
using Newtonsoft.Json;

namespace ChoirApplication.Services;

internal class MemberService
{
    private List<Member> _members = new List<Member>(); //listan skapas
    private readonly FileService _fileService = new FileService();

    public void AddMemberToList(Member member)
    {
        _members.Add(member);
        _fileService.SaveToFile(@"c:\Code\members.json", JsonConvert.SerializeObject(_members));
   
    }

    private static readonly string filePath = @"c:\Code\members.json";
    public void ReadFromFile(string filePath)
    {
        using var sw = new StreamReader(filePath);

        var content = sw.ReadToEnd();

    }



}
