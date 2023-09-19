
namespace ChoirApplication.Models
{
    internal class Member //hämtar från menyn
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string VocalRange { get; set; } = null!;
        //VocalRange = Vilken körstämma: sopran, allt tenor eller bas
    }
}
