using ClassLibrary1.Contracts;
using ClassLibrary1.DTOs;
using IdentityManagerServerApi.Data;
using Microsoft.AspNetCore.Identity;
using static ClassLibrary1.DTOs.ServiceResponses;

namespace IdentityManagerServerApi.Repositories
{
    public class AccountRepository(UserManager<ApplicationUser> userManager, 
                                    RoleManager<IdentityRole> roleManager,
                                    IConfiguration config) : IUserAccount
    {
        public async Task<ServiceResponses.GeneralResponse> CreateAccount(UserDTO userDTO)
        {
            if (userDTO is null) return new GeneralResponse(false, "Model is empty");
            var newUser = new ApplicationUser()
            {
                Name = userDTO.Name,
                Email = userDTO.Email,
                PasswordHash = userDTO.Password,
                UserName = userDTO.Email
            };

            var user = await userManager.FindByEmailAsync(newUser.Email);
            if (user is not null) return new GeneralResponse(false, "User Registered Already");
        }

        public Task<ServiceResponses.LoginResponse> LoginAccount(LoginDTO loginDTO)
        {
            throw new NotImplementedException();
        }
    }
}
