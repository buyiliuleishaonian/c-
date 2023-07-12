using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 学生学习管理系统.Model;
using 学生学习管理系统.DAL;
namespace 学生学习管理系统.BLL
{
    /// <summary>
    /// 班级逻辑层
    /// </summary>
    public class ClassIDBLL
    {
        /// <summary>
        /// 将数据库中的所有班级都读取出来
        /// </summary>
        /// <returns></returns>
        public List<ClassIDModel> GetClassID()
        {
            ClassIDDAL classIDDAL = new ClassIDDAL();
            return classIDDAL.GetClassID();
        }
    }
}
