using EduDom.Core.Aplication.DTOs.Account;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EduDom.Core.Application.Interfaces.Services
{
    public interface IAccountServices
    {
        Task<AuthenticationResponse> AuthenticationAsync(AuthenticationRequest request);
        Task<string> ConfirmEmailAsync(string userId, string token);
        Task<ForgotPasswordResponse> ForgotPasswordRequestAsync(ForgotPasswordRequest request, string origin);
        Task<RegisterResponse> RegisterUserAsync(RegisterRequest request, string origin);
        Task<ResetPasswordResponse> ResetPasswordAsync(ResetPasswordRequest request);

        Task<List<AuthenticationResponse>> GetAllUsersAsync();
        Task<AuthenticationResponse> GetUserByIdAsync(string id);
        Task<AuthenticationResponse> IsVerified(string id);
        Task<RegisterResponse> UpdateUserAsync(RegisterRequest request);

        Task SignOutAsync();
    }
}