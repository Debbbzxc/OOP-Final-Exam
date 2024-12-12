using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaltazarFinalExam
{
    public class Subject
    {
        public int code { get; set; }
        public string courseno { get; set; }
        public string description { get; set; }
        public string schedule { get; set; }
        public string room { get; set; }
        public Subject()
        {
            code = 0;
            courseno = string.Empty;
            description = string.Empty;
            schedule = string.Empty;
            room = string.Empty;
        }
    }
}
