using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class PostModel
    {
        /// <summary>
        /// 标题
        /// </summary>
        public string  Title{ get; set; }
        /// <summary>
        /// 标识是否是专家解读
        /// </summary>
        public bool IsExpert { get; set; }
        /// <summary>
        /// zuo
        /// </summary>
        public string ExprtName { get; set; }
        public string CurrentDate{ get; set; }

        public bool IsFav{ get; set; }
       
        public string CurrentTime { get; set; }

        /// <summary>
        /// HTML文本内容
        /// </summary>
        public string Content { get; set; }
  
    }
   
}