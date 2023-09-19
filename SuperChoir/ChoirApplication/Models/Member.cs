
namespace ChoirApplication.Models;

internal class Member //hämtar från MenuService.cs
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; } //ej obligatoriskt
    public string VocalRange { get; set; } = null!;
    //VocalRange = Vilken körstämma: sopran, alt, tenor eller bas, tralala
}

