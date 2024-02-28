
using ClassLibrary1.DTOs;
using static ClassLibrary1.DTOs.ServiceResponses;

namespace ClassLibrary1.Contracts
{
     public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}
