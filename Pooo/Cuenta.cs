using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pooo
{
    class Cuenta
    {
        private string _idAccount;
        private string _password;
        private string _creationDate;
        private string _owner;
        
        public string _email { get; set; }
        public string getIdAccount()
        {
            return _idAccount;
        }
        public void setIdaccount(string Idaccount)
        {
            _idAccount = Idaccount;
        }
        public string getPassword()
        {
            return _password;
        }
        public void setpassword(string Password)
        {
            _password = Password;
        }
        public string getcreationDate()
        {
            return _creationDate;
        }
        public void setowner(string Owner)
        {
            _owner = Owner;
        }
        //public string getemail()
        //{
           // return _email;
        //}
       //  public void setemail(string Email)
        //{
           // _email = Email;
       // }
    }
   
}
