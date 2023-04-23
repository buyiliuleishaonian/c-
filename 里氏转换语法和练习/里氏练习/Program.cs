using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 里氏练习
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] pers = new Person[10];
            Random nums = new Random();
            for (int x=0;x<pers.Length;x++)
            {
                int y = nums.Next(1,7);
                switch (y)
                {
                    case 1:
                        pers[x] = new Student();
                        Student st = pers[x] as Student;
                        st.StudentSayHello();
                        break;
                    case 2:
                        pers[x] = new Teachar();
                        Teachar th = pers[x]  as Teachar;
                        th.TeacherSayHello();
                        break;
                    case 3:
                        pers[x] = new Person();
                        Person pe = pers[x] as Person;
                        pe.PersonSayHello();
                        break;
                    case 4:
                        pers[x] = new MeiLv();
                        MeiLv ml = pers[x] as MeiLv;
                        ml.MeilvSayHello();
                        break;
                    case 5:
                        pers[x] = new Yeshou();
                        Yeshou ys = pers[x] as Yeshou;
                        ys.YeShouSayHello();
                        break;
                    case 6:
                        pers[x] = new Shuaige();
                        Shuaige sg = pers[x] as Shuaige;
                        break;
                }
            }
            //for (int x=0;x<pers.Length; x++)
            //{
            //    if (pers[x] is Student)
            //    {
            //        Student st = (Student)pers[x];
            //        st.StudentSayHello();
            //    }
            //    else if (pers[x] is Shuaige)
            //    {
            //        Shuaige sg = (Shuaige)pers[x];
            //        sg.ShuaigeSayHello();
            //    }
            //    else if (pers[x] is Teachar)
            //    {
            //        Teachar th = (Teachar)pers[x];
            //        th.TeacherSayHello();
            //    }
            //    else if (pers[x] is MeiLv)
            //    {
            //        MeiLv ml = (MeiLv)pers[x];
            //        ml.MeilvSayHello();
            //    }
            //    else if (pers[x] is Yeshou)
            //    {
            //        Yeshou ys = (Yeshou)pers[x];
            //        ys.YeShouSayHello();
            //    }
            //    else
            //    {
            //        Person pr = (Person)pers[x];
            //        pr.PersonSayHello();
            //    }
            //}
            Console.ReadKey(true);
        }
    }
}
