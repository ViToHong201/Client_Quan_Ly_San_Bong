using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Quan_Ly_San_Bong.DAL;

namespace Quan_Ly_San_Bong.BLL
{
    class Account_BLL
    {

        public string HasCode(string str)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(str);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }

            return hasPass;
        }
        public bool Login(string username, string password)
        {
            
            Account_DAL a = new Account_DAL();
          
            if (a.Login(username, HasCode(password)) != null)
                return true;
            return false;
        }


        public bool SignUp(string username, string password, string phone)
        {
            Account_DAL a = new Account_DAL();
            return a.SignUp(username, HasCode(password), phone);
        }
    }
}
