using Employee_Login_JWT_API_11.Identity;
using Employee_Login_JWT_API_11.Service_Contract;
using Employee_Login_JWT_API_11.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Login_JWT_API_11.Services
{
    public class UserServices : IUserService
    {
        

        public Task<ApplicationUser> Authenticate(LoginViewModel loginViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
