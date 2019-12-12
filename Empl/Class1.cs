using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empl
{
    [Serializable]
    public class Emp
    {
        [NonSerialized]
        private string _Password = "abc@123";

        private int _No;

        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        public string GetDetails()
        {
            return string.Format("No = {0}, Name = {1}", this.No, this.Name);
        }

    }
}
