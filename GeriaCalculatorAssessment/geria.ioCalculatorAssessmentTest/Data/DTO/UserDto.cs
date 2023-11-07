using System.ComponentModel.DataAnnotations;

namespace geria.ioCalculatorAssessmentTest.Data.DTO
{
    public class UserDto
    {
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        public string FullName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
