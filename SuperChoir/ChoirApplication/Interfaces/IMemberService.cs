using System.Dynamic;
using System.Reflection.Metadata;
using ChoirApplication.Models;

namespace ChoirApplication.Interfaces;

internal interface IMemberService
{

    public void Create(MemberCreateRequest memberCreateRequest);
    //Metod för att skapa medlem

    public Member Get(Func<Member, bool> expression);
    //Hämtar medlem med ett lambda expression

    public IEnumerable<Member> GetAll();
    //Hämtar alla medlemmar i listan, ger en läsbar lista
}
