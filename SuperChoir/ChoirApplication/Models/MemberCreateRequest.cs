
namespace ChoirApplication.Models;

internal class MemberCreateRequest
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public string VocalRange { get; set; } = null!;
}
