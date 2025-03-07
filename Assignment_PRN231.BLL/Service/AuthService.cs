using Assignment_PRN231.BLL.Service.IService;
using Assignment_PRN231.DAL.Repository.IRepository;
using Assignment_PRN231.Model.Commons;
using Assignment_PRN231.Model.Models.DTO.Auth;
using Assignment_PRN231.Model.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.BLL.Service
{
    public class AuthService : IAuthService
    {
        private readonly ISystemAccountRepository _systemAccountRepository;
        private readonly JwtHelper _jwtHelper;

        public AuthService(ISystemAccountRepository systemAccountRepository, JwtHelper jwtHelper)
        {
            _systemAccountRepository = systemAccountRepository;
            _jwtHelper = jwtHelper;
        }
        public async Task<ResponseDTO> LoginAsync(AccountLoginDTO loginDTO)
        {
            if (string.IsNullOrEmpty(loginDTO.AccountEmail) || string.IsNullOrEmpty(loginDTO.AccountPassword))
            {
                return new ResponseDTO { IsSucceed = false, Message = "Email and password are required." };
            }

            var account = await _systemAccountRepository.GetByEmailAsync(loginDTO.AccountEmail);
            if (account == null || !VerifyPassword(loginDTO.AccountPassword, account.AccountPassword))
            {
                return new ResponseDTO { IsSucceed = false, Message = "Invalid email or password." };
            }

            var token = _jwtHelper.GenerateJwtToken(account);
            return new ResponseDTO { IsSucceed = true, Message = "Login successful.", Data = token };
        }

        private bool VerifyPassword(string enteredPassword, string storedPassword)
        {
            return enteredPassword == storedPassword;
        }
    }
}
