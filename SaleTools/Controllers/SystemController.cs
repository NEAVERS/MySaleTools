using BLL;
using Common;
using Common.Entities;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SaleTools.Controllers
{
    public class SystemController : BaseController
    {
        SystemManager _system = new SystemManager();
        private UserManager manager = new UserManager();

        // GET: System
        public ActionResult SendGoodsfoot()
        {
            var model = _system.GetConfig(SysConfigTypes.PageBottom);
            string pageBottom = "";
            if (model != null)
                pageBottom = model.Value;
            ViewBag.PageBottom = pageBottom;
            return View();
        }

        public string SaveSendGoodsfoot(string value)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var model = new SysConfig();
            model.UpdateTime = DateTime.Now;
            model.Type =SysConfigTypes.PageBottom.ToString();
            model.Value = value;
            model.UpdateUser = loginUser.UserId;
            var res =  _system.SaveSysConfig(model);
            return Utils.SerializeObject(res);
        }


        public ActionResult Operate()
        {
            var model = _system.GetConfig(SysConfigTypes.IsCanReturn);
            string value = "";
            if (model != null)
                value = model.Value;
            ViewBag.IsCanReturn = value;
            model = _system.GetConfig(SysConfigTypes.IsShowBill);
            if (model != null)
                value = model.Value;
            ViewBag.IsShowBill = value;
            model = _system.GetConfig(SysConfigTypes.ContactTell);
            if (model != null)
                value = model.Value;
            ViewBag.ContactTell = value;

            return View();
        }

        public string SaveOperate(string isCanReturn, string isShowBill ,string contactTell)
        {
            var loginUser = (UserInfo)ViewBag.User;

            var model = new SysConfig();
            model.UpdateTime = DateTime.Now;
            model.Type = SysConfigTypes.IsCanReturn.ToString();
            model.Value = isCanReturn;
            model.UpdateUser = loginUser.UserId;
            var res = _system.SaveSysConfig(model);
            if(res)
            {
                model.Type = SysConfigTypes.IsShowBill.ToString();
                model.Value = isShowBill;
                res= _system.SaveSysConfig(model);
            }
            if(res)
            {
                model.Type = SysConfigTypes.ContactTell.ToString();
                model.Value = contactTell;
                res = _system.SaveSysConfig(model);

            }
            return Utils.SerializeObject(res);
        }

        public ActionResult ImgSetList()
        {
            return View();
        }

        public string GetImgSetStr()
        {
            var list = _system.GetImgSet();
            var q = from c in list
                    select new
                    {
                        ImgSetInfo = c,
                        UserTypeStr = string.Join(",", _system.GetUserTypeByImgSetId(c.Id).Select(x => x.TypeName))
                    };
            return Utils.SerializeObject(q);

        }

        public ActionResult AddImgSet(string setId = "")
        {

            Guid setGuid = Utils.ParseGuid(setId);

            var list = _system.GetUserTypeByImgSetId(setGuid);
            if (list == null)
                list = new List<UserType>();
            ViewBag.UserTypeList = list;
            var model = _system.GetImgeSetById(setGuid);

            var typelist = manager.GetTypeList();
            ViewBag.TypeList = typelist;
            if (model == null)
                model = new ImgSet();
            return View(model);
        }


        public string SaveImgSet(ImgSet set, List<int> userTypeList)
        {
            var res = _system.SaveImgSet(set, userTypeList);

            return Utils.SerializeObject(res);
        }
       
    }
}