using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Var35n6n18n27;

namespace TestControl
{
    public class People : ITreeView
    {
        private int Id;
        private String Post;
        private String Deport;
        private String FIO;

        public People(int Id,String Post,String Deport,String FIO)
        {
            this.Id = Id;
            this.Post = Post;
            this.Deport = Deport;
            this.FIO = FIO;
        }

        public string[] GetInternals()
        {
            return new string[] { Id.ToString(), Post, Deport, FIO };
        }
    }
}
