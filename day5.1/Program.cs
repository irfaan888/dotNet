using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Empl;
using System.Runtime.Serialization.Formatters.Soap;
using System.Collections;
using Product;
namespace day5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region filestream writer
            //FileStream fs = new FileStream(@"G:\dotnet_solutions\day5\myFile.txt", FileMode.OpenOrCreate, FileAccess.Write);
            //StreamWriter writer = new StreamWriter(fs);
            //Console.WriteLine("please write a line");
            //writer.WriteLine(Console.ReadLine());
            //writer.Close();
            //fs.Close(); 
            #endregion

            #region filestream reader
            //FileStream fs = new FileStream(@"G:\dotnet_solutions\day5\myFile.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);
            //StreamReader reader = new StreamReader(fs);

            //string data=reader.ReadToEnd();
            //Console.WriteLine(data);
            //reader.Close();
            //fs.Close(); 
            #endregion

            #region binaryFormatter writer using collection
            //FileStream fs = new FileStream(@"G:\dotnet_solutions\day5\myFile2.txt",
            //                                FileMode.OpenOrCreate,
            //                                FileAccess.Write);
            //BinaryFormatter writer = new BinaryFormatter();

            //Emp e1 = new Emp();
            //Emp e2 = new Emp();
            //Emp e3 = new Emp();
            //Console.WriteLine("enter no1");
            //e1.No = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter no2");
            //e2.No = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter no3");
            //e3.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter name1");
            //e1.Name = Console.ReadLine();
            //Console.WriteLine("enter name2");
            //e2.Name = Console.ReadLine();
            //Console.WriteLine("enter name3");
            //e3.Name = Console.ReadLine();

            //ArrayList arr = new ArrayList();
            //arr.Add(e1);
            //arr.Add(e2);
            //arr.Add(e3); 

            //writer.Serialize(fs,arr);

            //writer = null;
            //fs.Close();
            #endregion


            #region binaryFormatter reader using collection
            //FileStream fs = new FileStream(@"g:\dotnet_solutions\day5\myfile2.txt",
            //                                FileMode.Open,
            //                                FileAccess.Read);
            //BinaryFormatter reader = new BinaryFormatter();

            //ArrayList ar1 = new ArrayList();

            //object obj = reader.Deserialize(fs);

            //ar1 = (ArrayList)obj;
            //foreach (object item in ar1)
            //{
            //    if(item is Emp)
            //    {
            //        Emp e = (Emp)item;
            //        string z = e.GetDetails();
            //        Console.WriteLine(z);
            //    }

            //}
            //Console.ReadLine();
            //reader = null;
            //fs.Close();
            #endregion

            #region xmlSerialixzation writer using collection
            //FileStream fs = new FileStream(@"g:\dotnet_solutions\day5\myfile5.xml",
            //                              FileMode.OpenOrCreate,
            //                              FileAccess.Write);
            //XmlSerializer writer = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Emp), typeof(product) });

            //Emp e1 = new Emp();
            //Console.WriteLine("enter no");
            //e1.No = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter name");
            //e1.Name = Console.ReadLine();

            //Emp e2 = new Emp();
            //Console.WriteLine("enter no");
            //e2.No = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter name");
            //e2.Name = Console.ReadLine();

            //product p1 = new product();
            //Console.WriteLine("enter pid");
            //p1.Pid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter pname");
            //p1.Pname = Console.ReadLine();

            //product p2 = new product();
            //Console.WriteLine("enter pid");
            //p2.Pid = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter pname");
            //p2.Pname = Console.ReadLine();

            //ArrayList arr1 = new ArrayList();
            //arr1.Add(e1);
            //arr1.Add(e2);
            //arr1.Add(p1);
            //arr1.Add(p2);

            //writer.Serialize(fs, arr1);
            //writer = null;
            //fs.Close();
            #endregion

            #region xmlSerialization reader
            FileStream fs = new FileStream(@"g:\dotnet_solutions\day5\myfile5.xml",
                                        FileMode.Open,
                                        FileAccess.Read);
            XmlSerializer reader = new XmlSerializer(typeof(ArrayList), new Type[] { typeof(Emp), typeof(product) });

            object obj = reader.Deserialize(fs);
            ArrayList ar = new ArrayList();
            ar = (ArrayList)obj;

            foreach (object item in ar)
            {
                if (item is Emp)
                {
                    Emp e2 = (Emp)item;
                    string e = e2.GetDetails();
                    Console.WriteLine(e);
                    
                }
                if (item is product)
                {
                    product p1 = (product)item;
                    string s = p1.getProducts();
                    Console.WriteLine(s);
                }
            }
            Console.ReadLine();

            reader = null;
            fs.Close();
            #endregion

            #region soapformatter writer
            //FileStream fs = new FileStream(@"g:\dotnet_solutions\day5\SOAP1.xml",
            //                FileMode.OpenOrCreate,
            //                FileAccess.Write);

            //SoapFormatter writer = new SoapFormatter();

            //Emp e1 = new Emp();
            //Console.WriteLine("enter no");
            //e1.No = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("enter name");
            //e1.Name = Console.ReadLine();

            //writer.Serialize(fs, e1);

            //writer = null;
            //fs.Close();
            #endregion

            #region soapformatter reader
            //FileStream fs = new FileStream(@"g:\dotnet_solutions\day5\SOAP1.xml",
            //    FileMode.Open,
            //    FileAccess.Read);

            //SoapFormatter reader = new SoapFormatter();

            //object obj = reader.Deserialize(fs);

            //if (obj is Emp)
            //{
            //    Emp e5 = (Emp)obj;
            //    string a = e5.GetDetails();
            //    Console.WriteLine(a);
            //    Console.ReadLine();
            //}

            //reader = null;
            //fs.Close();
            #endregion

        }
    }



   

}
