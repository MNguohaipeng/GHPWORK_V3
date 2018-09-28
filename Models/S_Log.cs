using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///
    ///</summary>
    public partial class S_Log
    {
           public S_Log(){


           }
           /// <summary>
           /// Desc:
           /// Default:newid()
           /// Nullable:False
           /// </summary>    
           [SqlSugar.SugarColumn(IsPrimaryKey =true)]
           public string ID {get;set;}

           /// <summary>
           /// Desc:内容
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string NeiRong {get;set;}

           /// <summary>
           /// Desc:执行状态
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? Status {get;set;}

           /// <summary>
           /// Desc:标识数据
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string BiaoShi {get;set;}

           /// <summary>
           /// Desc:发生时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? DateTime {get;set;}

           /// <summary>
           /// Desc:分组
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Group {get;set;}

           /// <summary>
           /// Desc:位置
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string WeiZhi {get;set;}

    }
}
