using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB.Models.Resumes
{
    public class WorkCompany
    {
        public string Id { get; set; }
        /// <summary>
        /// 公司名
        /// </summary>
        public string CompanyName { get; set; }
        /// <summary>
        /// 公司详细地址
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// 公司所在城市
        /// </summary>
        public string City { get; set; }
        /// <summary>
        /// 项目介绍
        /// </summary>
        public string WorkContent { get; set; }
        /// <summary>
        /// 工作岗位
        /// </summary>
        public string WorkPosition { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public string BeginTime { get; set; }
        /// <summary>
        /// 离职时间
        /// </summary>
        public string EndTime { get; set; }
        /// <summary>
        /// 工资
        /// </summary>
        public string Salary { get; set; }
    }
}
