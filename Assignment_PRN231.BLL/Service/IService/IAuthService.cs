using Assignment_PRN231.Model.Models.DTO.Auth;
using Assignment_PRN231.Model.Models.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.BLL.Service.IService
{
    public interface IAuthService
    {
        Task<ResponseDTO> LoginAsync(AccountLoginDTO loginDTO);
    }
}
