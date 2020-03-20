using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork
{
    public class Client
    {
        public string login{ get;set; }
        public string role { get; set; }

        public Client(string login, string role)
        {
            this.login = login;
            this.role = role;
        }

        public override string ToString()
        {
            string output = String.Format("login: {0}, role: {1}", login, role);
            return output;
        }

    }
}
