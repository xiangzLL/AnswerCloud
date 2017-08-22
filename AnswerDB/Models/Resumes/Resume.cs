using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB.Models.Resumes
{
    /// <summary>
    /// 简历
    /// </summary>
    public class Resume
    {
        public string Id { get; set; }

        /// <summary>
        /// 真实姓名
        /// </summary>
        public string RealName { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// 出生年
        /// </summary>
        public int YearOfBirthday { get; set; }

        /// <summary>
        /// 出生月
        /// </summary>
        public int MonthOfBirthday { get; set; }

        /// <summary>
        /// 出生日
        /// </summary>
        public int DayOfBirthday { get; set; }

        /// <summary>
        /// 工作年限
        /// </summary>
        public int WorkYear { get; set; }
        /// <summary>
        /// 手机号
        /// </summary>
        public string MobilePhone { get; set; }
        /// <summary>
        /// 邮箱地址
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 工资
        /// </summary>
        public string Salary { get; set; }
        /// <summary>
        /// 希望最低工资
        /// </summary>
        public string ExpectLowestSalary { get; set; }
        /// <summary>
        /// 希望最高工资
        /// </summary>
        public string ExpectHighestSalary { get; set; }
        /// <summary>
        /// 当前状态  观望中...
        /// </summary>
        public string CurrentSituation { get; set; }

        /// <summary>
        /// Github地址
        /// </summary>
        public string GitHubUrl { get; set; }
        /// <summary>
        /// 婚姻状况
        /// </summary>
        public bool Marrige { get; set; }
        /// <summary>
        /// 目前所在城市
        /// </summary>
        public string CurrentCity { get; set; }

        /// <summary>
        /// 目前所在公司
        /// </summary>
        public string CurrentCompany { get; set; }
        /// <summary>
        /// QQ号
        /// </summary>
        public string QQ { get; set; }
        /// <summary>
        /// 简历是否公开
        /// </summary>
        public bool IsOpen { get; set; }
        /// <summary>
        /// 教育经验
        /// </summary>
        public List<Education> Educations { get; set; }
        /// <summary>
        /// 工作经验
        /// </summary>
        public List<Company> Companys { get; set; }
        /// <summary>
        /// 语言能力
        /// </summary>
        public List<Language> Languages { get; set; }
        /// <summary>
        /// 相关证书
        /// </summary>
        public List<Credit> Credits { get; set; }
    }
}
