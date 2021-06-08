using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Controllers
{
    class UserController
    {
        Models.UserDetailModel userDetail = new Models.UserDetailModel();
        public bool loginUser(string email, string password)
        {
            return userDetail.validateLoginUser(email, password);
        }

        public bool registerUser(string fName, string lName,string email, string password)
        {
            return userDetail.registerUserDetail(fName, lName, email, password);
        }

        public bool updateProfile(string fName, string lName)
        {
            return userDetail.updateUserProfile(fName, lName);
        }

        public bool updateEmail(string email)
        {
            return userDetail.updateUserEmail(email);
        }

        public bool updatePassword(string password)
        {
            return userDetail.updateUserPassword(password);
        }

        public UserInfo getUserInformations()
        {
            return userDetail.getUserDetail();
        }
    }
}
