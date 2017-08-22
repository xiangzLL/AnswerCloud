using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB.Models.Resumes
{
    public class Education
    {
        public string Id { get; set; }
        /// <summary>
        /// 学校
        /// </summary>
        public string School { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        public string BeginTime { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        public string EndTime { get; set; }
    }
}
