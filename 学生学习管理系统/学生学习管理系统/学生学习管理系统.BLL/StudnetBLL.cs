using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.DAL;
using 学生学习管理系统.Model;

namespace 学生学习管理系统.BLL
{
    public  class StudnetBLL
    {
        /// <summary>
        /// 验证输入学生的身份证和卡号是否有重复的
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public static bool BoolInStudent(StudentModel objStudent)
        {
            return StudentDAL.BoolStudents(objStudent);
        }

        /// <summary>
        /// 将封装好的学员信息，添加到数据库中
        /// </summary>
        /// <param name="objStu"></param>
        /// <returns></returns>
        public static int InsertStu(StudentModel objStu)
        {
            return StudentDAL.SetStudent(objStu);
        }

        //按照班级查询学员信息
        public List<StudentModel> ReadStudents(int classid)
        {
            return StudentDAL.ReadStus(classid);
        }

        /// <summary>
        /// 按照学号查询学员信息
        /// </summary>
        /// <param name="studentid"></param>
        /// <returns></returns>
        public StudentModel ReadStu(string studentid)
        {
            return StudentDAL.ReadStu(studentid);
        }

        /// <summary>
        /// 读取所有学员的信息
        /// </summary>
        /// <returns></returns>
        public List<StudentModel> AllStudent()
        {
            return StudentDAL.ReadStus();
        }

        /// <summary>
        /// 验证修改之后的学生身份证是否在数据库中已存在
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="studentidno"></param>
        /// <returns></returns>
        public bool determine(string studentid,string studentidno)
        {
            return StudentDAL.YanzhengStudentIDNO(studentid, studentidno);
        }

        /// <summary>
        /// 将修改的学生数据传送给数据库
        /// </summary>
        /// <param name="objStudent"></param>
        /// <returns></returns>
        public int UpdateStu(StudentModel objStudent)
        {
            return StudentDAL.UpdateStudent(objStudent);
        }
    }
}
