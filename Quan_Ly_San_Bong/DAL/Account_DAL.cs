using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Design;
using System.Data;
using System.ComponentModel;


namespace Quan_Ly_San_Bong.DAL
{
    class Account_DAL
    {
        Management_FootballPitchEntities db = new Management_FootballPitchEntities();
        

        public Account Login(string username, string password)
        {
            return db.Accounts.Where(x => x.username == username && x.password == password).FirstOrDefault();
        }

        public bool SignUp(string username, string password, string phone)
        {
            try
            {
                if (db.Accounts.Where(x => x.username == username).FirstOrDefault() != null)
                {
                    return false;
                }

                string tmp = DateTime.Now.ToString("hh:dd:yyyy:MM:mm:ss");
                string id = tmp.Replace(":", "");
                Account acc = new Account()
                {
                    id_account = id,
                    date_crate = DateTime.Today,
                    username = username,
                    password = password,
                    phone = phone,
                    permission = "khách hàng",
                    state = "hoạt động"
                };
                db.Accounts.Add(acc);
                db.SaveChanges();
                
                return true;
            }
            catch (Exception e)
            {
                //foreach (var eve in e.EntityValidationErrors)
                //{
                //    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                //        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                //    foreach (var ve in eve.ValidationErrors)
                //    {
                //        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                //            ve.PropertyName, ve.ErrorMessage);
                //    }
                //}

                Console.WriteLine(e.ToString());
                return false;

            }
        }
    }
}
