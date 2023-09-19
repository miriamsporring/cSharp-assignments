
using ChoirApplication.Interfaces;
using ChoirApplication.Models;

namespace ChoirApplication.Services;

internal class MemberService : IMemberService
//Kopplar klassen till interfacet
{

    private List<Member> _members = new List<Member>();


    public void Create(MemberCreateRequest memberCreateRequest)
    {
        throw new NotImplementedException();
    }

    public Member Get(Func<Member, bool> expression)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Member> GetAll()
    {
        throw new NotImplementedException();
    }
}
