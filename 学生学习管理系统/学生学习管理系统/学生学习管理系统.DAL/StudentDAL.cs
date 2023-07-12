using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Common;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 学生数据访问类
    /// </summary>
    public class StudentDAL
    {
        /// <summary>
        /// 验证前端输入的数据在数据中是否存在
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static bool BoolStudents(StudentModel objStu)
        {
            string sql = "select *from studentsInfos where studentidno=@idno " +
                "or cardno=@cdno ";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("@idno",objStu.StudentIdNo),
                new SqlParameter("@cdno",objStu.CardNO)
            };
            DataTable dt = SqlHelper.GetDataTable(sql, sp);
            if (dt.Rows.Count > 0)
            {

                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 将前端添加的数据加入到数据库中
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static int SetStudent(StudentModel objStu)
        {
            string sql = "insert into studentsinfos(studentname,gender,birthday,studentidno,cardno,stuimage,age,phonenumber,studentaddress,classid)" +
                "values(@name,@gender,@birthday,@studentidno,@cardno,@stuimage,@age,@phone,@stuAddress,@class) " +
                " select @@identity";
            SqlParameter[] sp = new SqlParameter[]
                {

                    new SqlParameter("name",objStu.StudentName),
                    new SqlParameter("gender",objStu.Gender),
                    new SqlParameter("birthday",objStu.Bithday.ToString("yyyy-MM-dd")),
                    new SqlParameter("studentidno",objStu.StudentIdNo),
                    new SqlParameter("cardno",objStu.CardNO),
                    new SqlParameter("stuimage",objStu.StuImage),
                    new SqlParameter("age",objStu.Age),
                    new SqlParameter("phone",objStu.PhoneNumber),
                    new SqlParameter("stuAddress",objStu.StudentAddress),
                    new SqlParameter("class",objStu.ClassID)
                };
            int number = Convert.ToInt32(SqlHelper.GetExecuteeScalar(sql, sp));
            if (number > 0)
            {
                return number;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// 按照班级查询学员信息
        /// </summary>
        /// <param name="classid">班级</param>
        /// <returns></returns>
        public static List<StudentModel> ReadStus(int classid)
        {
            string sql = "select studentid,studentname,gender,birthday,classname " +
                " from studentsinfos " +
                " inner join classinfos " +
                " on studentsinfos.classid=classinfos.classid" +
                " where classinfos.classid=@Classid";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("Classid",classid)
                };
            List<StudentModel> stulist = new List<StudentModel>();
            DataTable dt = SqlHelper.GetDataTable(sql, sp);
            foreach (DataRow dr in dt.Rows)
            {
                stulist.Add(new StudentModel
                {
                    StudentID = Convert.ToInt32(dr["studentid"]),
                    StudentName = dr["studentname"].ToString(),
                    Gender = dr["gender"].ToString(),
                    Bithday = Convert.ToDateTime(dr["birthday"]),
                    ClassName = dr["classname"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 查询所有学员信息
        /// </summary>
        /// <returns></returns>
        public static List<StudentModel> ReadStus()
        {
            string sql = "select studentid,studentname,gender,birthday,classname " +
                " from studentsinfos " +
                " inner join classinfos " +
                " on studentsinfos.classid=classinfos.classid";

            List<StudentModel> stulist = new List<StudentModel>();
            DataTable dt = SqlHelper.GetDataTable(sql);
            foreach (DataRow dr in dt.Rows)
            {
                stulist.Add(new StudentModel
                {
                    StudentID = Convert.ToInt32(dr["studentid"]),
                    StudentName = dr["studentname"].ToString(),
                    Gender = dr["gender"].ToString(),
                    Bithday = Convert.ToDateTime(dr["birthday"]),
                    ClassName = dr["classname"].ToString()
                });
            }
            return stulist;
        }

        /// <summary>
        /// 按照学号查询学员详细信息
        /// </summary>
        /// <param name="studentId"></param>
        /// <returns></returns>
        public static StudentModel ReadStu(string studentId)
        {
            string sql = "select studentid,studentname,gender,birthday,classname,stuimage,studentidno," +
                " cardno,age,phonenumber,studentaddress " +
                " from studentsinfos " +
                " inner join  classinfos " +
                " on studentsinfos.classid=classinfos.classid " +
                " where  studentid=@studentId";
            SqlParameter[] sp = new SqlParameter[]
            {
                new SqlParameter("studentId",studentId)
            };
            SqlDataReader sqlRead = SqlHelper.GetSqlReader(sql, sp);
            StudentModel stu = null;
            if (sqlRead.Read())
            {
                stu = new StudentModel()
                {
                    StudentID = Convert.ToInt32(sqlRead["studentid"]),
                    StudentName = sqlRead["studentname"].ToString(),
                    Gender = sqlRead["gender"].ToString(),
                    Bithday = Convert.ToDateTime(sqlRead["birthday"]),
                    ClassName = sqlRead["classname"].ToString(),
                    StuImage = sqlRead["stuimage"].ToString() == null ?
                    "" : sqlRead["stuimage"].ToString(),
                    StudentIdNo = sqlRead["studentidno"].ToString(),
                    CardNO = sqlRead["cardno"].ToString(),
                    Age = Convert.ToInt32(sqlRead["age"]),
                    PhoneNumber = sqlRead["phonenumber"].ToString(),
                    StudentAddress = sqlRead["studentaddress"].ToString()
                };
                return stu;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 验证修改之后的学号，在数据库中是否存在同样的身份证号
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="studentidno"></param>
        /// <returns></returns>
        public static bool YanzhengStudentIDNO(string studentid,string studentidno)
        {
            string sql = "select studentid ,studentidno,studentname from studentsinfos " +
                " where studentid<>@Studentid and  studentidno=@StudentIDno";
            SqlParameter[] sp = new SqlParameter[]
                {
                    new SqlParameter("Studentid",studentid),
                    new SqlParameter("StudentIDno",studentidno)
                };
            SqlDataReader sqlread = SqlHelper.GetSqlReader(sql,sp) ;
            if (sqlread == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 将修改之后的数据传送给数据库
        /// </summary>
        /// <param name="stuModel"></param>
        /// <returns></returns>
        public static int UpdateStudent(StudentModel stuModel)
        {
            string sql = "update studentsinfos" +
                " set studentname=@Studentname,gender=@Gender,birthday=@Birthday,classid=@Classid," +
                " stuimage=@StuImage,studentidno=@Studentidno," +
                " cardno=@Cardno,age=@Age,phonenumber=@Phone,studentaddress=@Studentaddress " +
                " where  studentid=@Studentid";
            SqlParameter[] sq = new SqlParameter[]
            {
                new SqlParameter("Studentid",stuModel.StudentID),
                new SqlParameter("Studentname",stuModel.StudentName),
                new SqlParameter("Gender",stuModel.Gender),
                new SqlParameter("Birthday",stuModel.Bithday.ToString("yyyy-MM-dd")),
                new SqlParameter("Classid",stuModel.ClassID),
                new SqlParameter("StuImage",stuModel.StuImage),
                new SqlParameter("Studentidno",stuModel.StudentIdNo),
                new SqlParameter("Cardno",stuModel.CardNO),
                new SqlParameter("Age",stuModel.Age),
                new  SqlParameter("Phone",stuModel.PhoneNumber),
                new SqlParameter("Studentaddress",stuModel.StudentAddress)
            };
            int number=SqlHelper.GetExecteNonQuery(sql,sq);
            return number;
        }

        public static int DeleteStudent(string studentID)
        {
            string sql = "delete from studentidno";
        }
    }
}
