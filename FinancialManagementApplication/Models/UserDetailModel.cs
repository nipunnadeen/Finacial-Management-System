using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagementApplication.Models
{
    class UserDetailModel
    {
        FMSystemContainer db = new FMSystemContainer();
        UserInfo dataUser = new UserInfo();

        public bool validateLoginUser(string email, string password)
        {
            try
            {
                var user = checkEmailAuth(email);
                if (user != null)
                {
                    bool checkPassowrd = CompareHashPasswords(user.Password, password);
                    if (checkPassowrd == true)
                    {
                        Util.FileRead.userEmailId = user.Id;
                        return true;
                    } 
                    else
                    {
                        return false;
                    }
                } 
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public bool registerUserDetail(string fName, string lName, string email, string password)
        {
            try
            {
                dataUser.FirstName = fName;
                dataUser.LastName = lName;
                dataUser.Email = email;
                dataUser.Password = ComputePasswrodHash(password);

                var user = checkEmailAuth(email);
                if (user == null)
                {
                    db.UserInfoes.Add(dataUser);
                    db.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        /// <summary>
        /// Get the user details
        /// </summary>
        /// <returns>dataUser</returns>
        public UserInfo getUserDetail()
        {
            try
            {
                int emailId = Util.FileRead.userEmailId;

                dataUser = db.UserInfoes.Find(emailId);
                return dataUser;
            }
            catch (Exception e)
            {
                return null;
                throw e;
            }
        }

        public bool updateUserProfile(string fName, string lName)
        {
            try
            {
                int userId = Util.FileRead.userEmailId;

                var updatedUser = db.UserInfoes.First(g => g.Id == userId);
                updatedUser.FirstName = fName;
                updatedUser.LastName = lName;
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public bool updateUserEmail(string email)
        {
            try
            {
                int userId = Util.FileRead.userEmailId;

                var user = checkEmailAuth(email);
                if (user == null)
                {
                    var updatedUser = db.UserInfoes.First(g => g.Id == userId);
                    updatedUser.Email = email;
                    db.SaveChanges();

                    return true;
                } 
                else
                {
                    return false;
                }     
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        public bool updateUserPassword(string password)
        {
            try
            {
                int userId = Util.FileRead.userEmailId;

                var updatedUser = db.UserInfoes.First(g => g.Id == userId);
                updatedUser.Password = ComputePasswrodHash(password); ;
                db.SaveChanges();

                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        /// <summary>
        /// Check the email is already used or not
        /// </summary>
        /// <param name="email">args will be passed when starting this function</param>
        /// <returns>user</returns>
        private UserInfo checkEmailAuth(string email)
        {
            try
            {
                var query = from obj in db.UserInfoes where obj.Email == email select obj;
                UserInfo user = query.AsQueryable().FirstOrDefault();
                return user;
            }
            catch(Exception e)
            {
                return null;
                throw e;
            }
        }

        /// <summary>
        /// Convert password in to hash
        /// </summary>
        /// <param name="password">args will be passed when starting this function</param>
        /// <returns>tmpHash</returns>
        private String ComputePasswrodHash(String password)
        {
            byte[] tmpSource;
            byte[] tmpHash;

            tmpSource = ASCIIEncoding.ASCII.GetBytes(password);
            //Compute hash based on source data.
            tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            return ByteArrayToString(tmpHash);
        }

        /*function to convert byte array to string array*/
        private string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }

        private bool CompareHashPasswords(String userPassword, String inputPassword)
        {
            byte[] tmpSource;
            byte[] tmpHash;

            tmpHash = Encoding.ASCII.GetBytes(userPassword);

            /*convert input password to hash which is converted as a 16 bit and then convert to string to make it 32 bit 
            and then convert to bit array again as a 32 bit*/
            tmpSource = ASCIIEncoding.ASCII.GetBytes(inputPassword);
            byte[] tmpNewHash;
            tmpNewHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string converted = ByteArrayToString(tmpNewHash);
            byte[] enteredHash = Encoding.ASCII.GetBytes(converted);

            bool isMatched = false;
            if (enteredHash.Length == tmpHash.Length)
            {
                int i = 0;
                while ((i < enteredHash.Length) && (enteredHash[i] == tmpHash[i]))
                {
                    i += 1;
                }
                if (i == enteredHash.Length)
                {
                    isMatched = true;
                }
            }
            return isMatched;
        }
    }
}
