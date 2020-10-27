using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Var35n6n18n27;

namespace TestControl
{
    public class People
    {
        public int Id { get; set; }
        public String Post { get; set; }
        public String Deport { get; set; }
        public String FIO { get; set; }

        public People(int Id,String Post,String Deport,String FIO)
        {
            this.Id = Id;
            this.Post = Post;
            this.Deport = Deport;
            this.FIO = FIO;
        }

        
    }
}
