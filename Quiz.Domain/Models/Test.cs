using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.Domain.Models
{
    public class Test
    {
        public int Id { get; set; }
        public string Question { get; set; }
        public string CorrectAnswer { get; set; }
        public string inCorrect1 { get; set; }
        public string inCorrect2 { get; set; }
        public string inCorrect3 { get; set; }
    }
}
