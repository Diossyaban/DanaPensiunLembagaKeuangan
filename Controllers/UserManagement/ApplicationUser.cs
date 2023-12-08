using Microsoft.AspNetCore.Identity;

public class ApplicationUser : IdentityUser
{
    public string NamaLengkap { get; set; }
    public string Bagian { get; set; }
    public string Jabatan { get; set; }
    public short StatusUser { get; set; }
    public string Email { get; set; }
}
