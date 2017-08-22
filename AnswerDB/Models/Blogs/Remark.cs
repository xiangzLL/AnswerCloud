using System;
using System.Collections.Generic;
using System.Text;

namespace AnswerDB.Models.Blogs
{
    /// <summary>
    /// 博客评论
    /// </summary>
    public class Remark
    {
        public string Id { get; set; }
        /// <summary>
        /// 评论内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 评论时间
        /// </summary>
        public string CreateTime { get; set; }
        /// <summary>
        /// 点赞数
        /// </summary>
        public int SupportCount { get; set; }
        /// <summary>
        /// 评论的评论
        /// </summary>
        public List<Remark> Remarks { get; set; }
    }
}
