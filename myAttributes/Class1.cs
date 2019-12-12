using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myAttributes
{
    public class Table:Attribute
    {
        private string _Tablename;

        public string Tablename
        {
            get { return _Tablename; }
            set { _Tablename = value; }
        }

    }
    Console.WriteLine();
        Console.WriteLine(  );
        Console.ReadLine(); 
        Console.ReadLine(); 
          
    public class Column:Attribute
    {
        private string _columnname;

        public string Columnname
        {
            get { return _columnname; }
            set { _columnname = value; }
        }
        private string _Columntype;

        public string Columntype
        {
            get { return _Columntype; }
            set { _Columntype = value; }
        }

    }
}
