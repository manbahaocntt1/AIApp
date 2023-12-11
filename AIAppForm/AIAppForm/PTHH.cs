using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIAppForm
{
    internal class PTHH
    {
        private List<string> veTrai;

        private string vePhai;


        public PTHH(List<string> veTrai, string vePhai)
        {
            this.veTrai = veTrai;
            this.vePhai = vePhai;
        }

        public List<string> VeTrai { get => veTrai; set => veTrai = value; }
        public string VePhai { get => vePhai; set => vePhai = value; }
    }
}
