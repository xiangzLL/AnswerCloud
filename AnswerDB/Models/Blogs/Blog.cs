using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB.Models.Blogs
{
    public class Blog
    {
        public string Id { get; set; }
        /// <summary>
        /// 博客内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 博客标题
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// 博客关键字描述
        /// </summary>
        public string Keyword { get; set; }
        /// <summary>
        /// 撰写时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public string UpdateTime { get; set; }
        /// <summary>
        /// 支持个数
        /// </summary>
        public int SupportCount { get; set; }
        /// <summary>
        /// 博客评论
        /// </summary>
        public List<Remark> Remarks { get; set; }
        /// <summary>
        /// 写博客的用户
        /// </summary>
        public User User { get; set; }
    }
}
