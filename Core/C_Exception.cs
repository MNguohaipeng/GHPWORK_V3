using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class C_Exception : Exception
    {

        public C_Exception(Exception ex)
        {
            //string BiaoShi, string NeiRong, int Status, string WeiZhi, string Group

            using (var DB = LinkDBHelper.CreateDB("GPKV3"))
            {

                Models.S_Log Log = new Models.S_Log();

                Log.DateTime = DateTime.Now;

                Log.BiaoShi = ex.Source;

                Log.NeiRong = ex.Message;

                Log.Status = -1;

                Log.WeiZhi = ex.Source;

                Log.Group = "系统异常";

                DB.Insertable(Log).ExecuteCommand();

            }

        }


        public static void C_JiluLog(string BiaoShi, string NeiRong, int Status, string WeiZhi, string Group)
        {

            using (var DB = LinkDBHelper.CreateDB("GPKV3"))
            {

                Models.S_Log Log = new Models.S_Log();

                Log.DateTime = DateTime.Now;

                Log.BiaoShi = BiaoShi;

                Log.NeiRong = NeiRong;

                Log.Status = Status;

                Log.WeiZhi = WeiZhi;

                Log.Group = Group;

                DB.Insertable(Log).ExecuteCommand();

            }

        }

    }
}
