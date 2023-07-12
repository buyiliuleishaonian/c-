using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Common.SQLHelper;
using 学生学习管理系统.Model;
namespace 学生学习管理系统.DAL
{
    /// <summary>
    /// 班级类
    /// </summary>
    public class ClassIDDAL
    {
        //查询出所有的班级，将其放在List集合里面
        public   List<ClassIDModel> GetClassID()
        {
            //创建sql语句
            string sql = "select classid,classname from classinfos";
            //调用sqlhelper方法
            DataTable da = SqlHelper.GetDataTable(sql);
            List<ClassIDModel> list= new List<ClassIDModel>();
            foreach (DataRow dr in da.Rows) 
            {
                list.Add(new ClassIDModel()
                {
                    ClassID = Convert.ToInt32(dr["classid"]),
                    ClassName = dr["classname"].ToString()
                }) ;
            }
            return list;
        }
    }
}
