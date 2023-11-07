using geria.ioCalculatorAssessmentTest.Data.DTO;
using geria.ioCalculatorAssessmentTest.Models;

namespace geria.ioCalculatorAssessmentTest.Auth
{
    public interface IAuthenticationService
    {
        Task<ResponseDto<string>> Login(UserDto request);
        Task<ResponseDto<User>> Register(UserDto request);
    }
}
