namespace PubMaui.Shared.Dtos
{
    public record LoggedInUser(Guid Id, string FirstName, string LastName, string FullName, string Email, string PhNumber, string Address, string CityTown, string PostalCode);

}
