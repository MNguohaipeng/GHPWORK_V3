using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class S_Menus
    {
        public S_Menus()
        {


        }
        /// <summary>
        /// Desc:主键
        /// Default:newid()
        /// Nullable:False
        /// </summary>           
        public string ID { get; set; }

        /// <summary>
        /// Desc:菜单名称
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string name { get; set; }

        /// <summary>
        /// Desc:图标
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string icon { get; set; }

        /// <summary>
        /// Desc:路径
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string Url { get; set; }

        /// <summary>
        /// Desc:上级ID
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string ShangJiID { get; set; }

        /// <summary>
        /// Desc:等级【1，2，3】
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? Level { get; set; }

        /// <summary>
        /// Desc:创建时间
        /// Default:
        /// Nullable:True
        /// </summary>           
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// Desc:创建人
        /// Default:
        /// Nullable:True
        /// </summary>           
        public string CreatePeople { get; set; }

        /// <summary>
        /// Desc:是否删除【0，1】【是，否】
        /// Default:
        /// Nullable:True
        /// </summary>           
        public int? IsDeleted { get; set; }

        [SqlSugar.SugarColumn(IsIgnore =true)]
        public List<S_Menus> Info { get; set; }

    }
}
