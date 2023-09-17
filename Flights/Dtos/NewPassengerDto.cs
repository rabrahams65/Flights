using System.ComponentModel.DataAnnotations;

namespace Flights.Dtos
{
    public record NewPassengerDto(
        [Required][StringLength(100, MinimumLength = 3)][EmailAddress] string Email, 
        [Required][MinLength(2)][MaxLength(35)][Display(Name = "First Name")] string FirstName,
        [Required][MinLength(2)][MaxLength(35)][Display(Name = "Last Name")] string LastName, 
        [Required] bool Gender);
}
