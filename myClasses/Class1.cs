using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myAttributes;

namespace myClasses
{
    [Table(Tablename="myEmployee")]
    [Serializable]
    public class Emp
    {
        private int _No;
        [Column(Columnname ="No",Columntype ="Integer")]
        public int No
        {
            get { return _No; }
            set { _No = value; }
        }

        private string _Name;
        [Column(Columnname = "Name", Columntype = "String")]
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

    }
}
