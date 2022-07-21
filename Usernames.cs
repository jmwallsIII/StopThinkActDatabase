using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopThinkAct
{
    public class Usernames
    {
        public string? User
            { get; set; }
        public static string TimeReference()
        {
            string now = DateTime.Now.ToString();
            return now;
        }
    }
    
}
