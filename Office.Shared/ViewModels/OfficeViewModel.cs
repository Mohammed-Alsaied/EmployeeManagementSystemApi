
namespace Offices.Shared;
public class OfficeViewModel : BaseViewModel
{
    public string City { get; set; }
    public string PhoneNumber { get; set; }
    public string Address1 { get; set; }
    public string? Address2 { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public int? PostalCode { get; set; }
}