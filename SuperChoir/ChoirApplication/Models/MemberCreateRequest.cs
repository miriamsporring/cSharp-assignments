
namespace ChoirApplication.Models;

internal class MemberCreateRequest
//skapar
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string? PhoneNumber { get; set; }
    public string VocalRange { get; set; } = null!;
}
