using System;
using System.Configuration;
using SqlSugar;

namespace Core
{

    public class LinkDBHelper
    {

         

        #region 创建链接

        private static SqlSugarClient CreateDB(string ConnectionString, string ConnectionStringType)
        {

            try
            {

                ConnectionConfig LinkConfig = new ConnectionConfig();

                LinkConfig.ConnectionString = ConnectionString;

                LinkConfig.IsAutoCloseConnection = true;//是否自动释放数据库，设为true我们不需要close或者Using的操作，

                LinkConfig.InitKeyType = InitKeyType.Attribute;

                switch (ConnectionStringType)//数据库类型
                {

                    case "MYSQL":

                        LinkConfig.DbType = DbType.MySql;

                        break;

                    case "SQLSERVER":

                        LinkConfig.DbType = DbType.SqlServer;

                        break;

                    case "NEWAPS":

                        LinkConfig.DbType = DbType.Oracle;

                        break;

                    case "ORACLE":

                        LinkConfig.DbType = DbType.Oracle;

                        break;

                    default:
                        throw new Exception("未知数据库类型");

                }

                SqlSugarClient db = new SqlSugarClient(LinkConfig); //初始化主键和自增列信息的方式 默认SystemTable

                return db;

            }
            catch (Exception ex)
            {

                throw;

            }

        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
        public static SqlSugarClient CreateDB(string Type)
        {

            switch (Type)
            {
               
                case "GPKV3":
                    
                    return CreateDB(ConfigurationManager.ConnectionStrings["GHPWORK_V3_DB"].ToString(), ConfigurationManager.ConnectionStrings["GHPWORK_V3_TYPE"].ToString());
 
                default:
                    throw new Exception("没有对应的DB，创建失败");
            }

        }
 


        #endregion



    }

}
