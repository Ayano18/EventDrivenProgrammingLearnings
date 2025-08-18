
namespace UserAccountNamespace
{
    public class UserAccount
    {
        private string full_name = "Timothy";
        protected string user_name = "Tim";
        protected string user_pass = "Alvarez";
        public UserAccount(string username, string uName, string password)
        {
            user_name = username;
            full_name = uName;
            user_pass = password;
        }
        public bool validateLogin(string uName, string password)
        {
            if (uName == user_name && password == user_pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getFullName()
        {
            return full_name;
        }
    }
    public class Cashier : UserAccount
    {
        private string department = "Cashier";
        public Cashier(string name, string department, string uName, string password) : base(name, uName, password)
        {
            department = department;

        }
        public bool validateLogin(string uName, string password)
        {
            if (uName == user_name && password == user_pass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string getDepartment()
        {
            return department;
        }
    }
}