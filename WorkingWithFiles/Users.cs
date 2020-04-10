using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    public class Users
    {
        public string Username { get; set; }
        public  string PassWord { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Contanct { get; set; }
        public void WriteContent()
        {
            string content = Username + "#" + PassWord + "#" + Name + "#" + LastName + "#" + Contanct;

            FileManger.WriteToFile(content);


        }
    }

 
}
