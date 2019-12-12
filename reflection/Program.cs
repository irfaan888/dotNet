using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using myAttributes;

namespace reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter path of any dotnet assembly dll file");
            string dllpath = Console.ReadLine();
            Assembly assembly = Assembly.LoadFrom(dllpath);
            Type[] types = assembly.GetTypes();
            foreach (Type type in types)
            {
                string table;
                bool isSerializable = false;
                
                List<Attribute> allAttributes = type.GetCustomAttributes().ToList();
                foreach (Attribute attr in allAttributes)
                {
                    if (attr is SerializableAttribute)
                    {
                        isSerializable = true;
                        //Console.WriteLine(type.Name + " is serializable");
                    }
                    if (attr is Table)
                    {
                        Table t = (Table)attr;
                        Console.WriteLine("create table "+t.Tablename+"(");
                        table = t.Tablename;
                        PropertyInfo[] props=type.GetProperties();
                        bool flag = false;
                        foreach (PropertyInfo item in props)
                        {
                            List<Attribute> la = item.GetCustomAttributes().ToList();
                            
                            foreach (Attribute a in la)
                            {
                                
                                if(a is Column)
                                {
                                    if (flag)
                                    {
                                        Console.Write(",");
                                    }
                                    Column c=(Column)a;
                                    Console.Write(c.Columnname+" ");
                                    Console.Write(c.Columntype);
                                    
                                   }

                                flag = true;
                            }

                            
                        }
                        Console.WriteLine(");");
                    }
                }

                if (isSerializable = !true)
                {
                    //Console.WriteLine(type.Name + " is not marked as serializable");
                }
                //Console.WriteLine(type.Name);

                MethodInfo[] methods = type.GetMethods();
                //Console.WriteLine("|");
                //Console.WriteLine();
                foreach (MethodInfo item in methods)
                {
                    //Console.WriteLine("--------" + item.Name);
                    ParameterInfo[] parameters = item.GetParameters();
                    foreach (ParameterInfo para in parameters)
                    {
                        //Console.WriteLine("----------------------" + para.Name + "----" + para.ParameterType);

                    }
                }

            }
            Console.ReadLine();
        }
    }
}
    