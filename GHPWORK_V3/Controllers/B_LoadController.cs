using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GHPWORK_V3.Controllers
{
    public class B_LoadController : B_SystemController
    {

        /// <summary>
        /// 获取菜单
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public JsonResult GetMenus()
        {

            using (var V3DB = Core.LinkDBHelper.CreateDB("GPKV3"))
                try
                {

                    var Menu01 = V3DB.Queryable<Models.S_Menus>().Where(T => T.IsDeleted == 0 & T.Level == 1).ToList();

                    //第一层菜单
                    foreach (S_Menus item in Menu01)
                    {

                        string SJID = item.ID;
 
                        item.Info = V3DB.Queryable<S_Menus>().Where(T => T.IsDeleted == 0 & T.Level == 2 & T.ShangJiID == SJID).ToList();

                        //第二层菜单
                        foreach (S_Menus item2 in item.Info)
                        {

                            string SJID2 = item2.ID;

                            item2.Info = V3DB.Queryable<S_Menus>().Where(T => T.IsDeleted == 0 & T.Level == 3 & T.ShangJiID == SJID2).ToList();

                        }
 
                    }
 
                    return Json(new { status = 1, data = Menu01, msg ="" });

                }
                catch (Exception ex)
                {

                    Core.C_Exception.C_JiluLog("---", ex.Message, -2, ex.Source, "获取菜单");

                    return Json(new { status = -2, data = "", msg = ex.Message });

                }

        }

    }
}