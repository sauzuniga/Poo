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
        private string _birthDate;
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
            return _birthDate;
        }
        public void setbirthDate(string BirthDate)
        {
            _birthDate = BirthDate;
        }
        public string getowner()
        {
            return _owner;
        }
        public void setowner(string Owner)
        {
            _owner = Owner;
        }
        public string getCuentainfo()
        {
            return "Su cuenta se ha creado correctamenente, sus datos son: ";
                
        }
        public string getIdinfo()
        {
            return
                "ID: " + _idAccount;
              
        }
        public string getPasswordinfo()
        {
            return
                "Clave:" + _password;
                
        }
        public string getBirthDateinfo()
        {
            return
                "Fecha de nacimiento:" + _birthDate;
                
        }
        public string getOwnerinfo()
        {
            return
                "Propietario de la cuenta:" + _owner;
               
        }
        public string getEmailinfo()
        {
            return 
                "Correo electronico:" + _email;
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
