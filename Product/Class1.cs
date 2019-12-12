using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Product
{
    [Serializable]
    public class product
    {
        private int pid;

        public int Pid
        {
            get { return pid; }
            set { pid = value; }
        }
        private string pname;

        public string Pname
        {
            get { return pname; }
            set { pname = value; }
        }

        public string getProducts()
        {
            return string.Format("pid = {0}, pname = {1}", this.Pid, this.Pname);
        }
    }
}
