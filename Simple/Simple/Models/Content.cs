using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simple.Models
{
    /// <summary>
    /// 内容实体
    /// </summary>
    public class Content
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { set; get; }
        /// <summary>
        /// 标题
        /// </summary>
        public string title { set; get; }
        /// <summary>
        /// 内容
        /// </summary>
        public string content { set; get; }
        /// <summary>
        /// 状态：0、正常  1、删除
        /// </summary>
        public int isDelete { set; get; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime createOn { set; get; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime updateOn { set; get; }
    }
}
