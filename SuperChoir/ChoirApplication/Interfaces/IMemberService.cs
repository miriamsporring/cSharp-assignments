using System.Dynamic;
using System.Reflection.Metadata;
using ChoirApplication.Models;

namespace ChoirApplication.Interfaces;

internal interface IMemberService
{
    //Metod för att skapa medlem
    public void Create(MemberCreateRequest memberCreateRequest);

    //Hämtar medlem med ett lamda expression
    public Member Get(Func<Member, bool> expression);

    //Hämtar alla medlemmar i listan, ger en läsbar lista
    public IEnumerable<Member> GetAll();
}
