namespace Razor.CleanArchitecture.Domain;

public class Player : BaseAuditableEntity
{
    public string Name { get; set; }
    public int? ShirtNo { get; set; }
    public int? ClubId { get; set; }
    public string PhotoUrl { get; set; }
    public DateTime? BirthDate { get; set; }
}
