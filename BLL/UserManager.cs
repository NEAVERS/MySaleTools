﻿using Common;
using Common.Entities;
using Dal;
using Dal.Mapping.Erp;
using Model;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        private  SaleToolsContext _context = new SaleToolsContext();
        private ErpContext _erp = new ErpContext();

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UserReg(UserInfo user)
        {
            if (user.TypeId < 0)
            {
                user.BTypeId = GetEmployeeId(user.UserCode);
            }
            else
                user.BTypeId = GetBtypeId(user.UserCode);

            _context.UserInfoes.Add(user);

            return _context.SaveChanges() > 0;
        }


        public bool CheckPhone(Guid userId, string phone)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.Tel == phone&&x.UserId!=userId &&!x.IsDelete);
            return user == null;

        }


        public bool CheckUsernum(Guid userid, string num)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId != userid && x.UserNum == num && !x.IsDelete);
            return user == null;
        }

        public bool CheckAccount(Guid userid, string accout)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId != userid && x.Account == accout && !x.IsDelete);

            return user == null;
        }


        public bool IsExitUser(Guid userId)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId && !x.IsDelete);
            return user == null;
        }

        public bool UpdateUser(UserInfo user)
        {
            var model = _context.UserInfoes.FirstOrDefault(x => x.UserId == user.UserId);
            if(model!=null)
            {
                model.UserName = user.UserName;
                model.Account = user.Account;
                model.UserNum = user.UserNum;
                model.TypeId = user.TypeId;
                model.TypeName = user.TypeName;
                if(!string.IsNullOrWhiteSpace(user.PassWord))
                    model.PassWord = user.PassWord;
                model.Province = user.Province;
                model.ProvinceNum = user.ProvinceNum;
                model.CityNum = user.CityNum;
                model.City = user.City;
                model.AreaNum = user.AreaNum;
                model.Area = user.Area;
                model.ReceiveName =  user.UserName;
                model.SaleManGuid = user.SaleManGuid;
                model.SaleManName = user.SaleManName;
                model.Addr = user.Addr;
                model.StoreArea = user.StoreArea;
                model.SotreName = user.SotreName;
                model.Email = user.Email;
                model.Remark = user.Remark;
                model.Tel = user.Tel;
                model.UserCode = user.UserCode;
                if(model.TypeId <0)
                {
                    model.BTypeId = GetEmployeeId(user.UserCode);
                }
                else
                    model.BTypeId = GetBtypeId(user.UserCode);
            }

            return _context.SaveChanges() > 0;
        }


        private string GetBtypeId(string userCode)
        {
            var model = _erp.btypes.FirstOrDefault(x => x.UserCode == userCode);
            if (model == null)
                return "";
            return model.typeId;
        }

        private string GetEmployeeId(string userCode)
        {
            var model = _erp.employees.FirstOrDefault(x => x.UserCode == userCode);
            if (model == null)
                return "";
            return model.typeId;
        }
        public bool DelUser(Guid userid)
        {
            var model = _context.UserInfoes.FirstOrDefault(x => x.UserId == userid);
            if (model != null)
                model.IsDelete = true;
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 获取供应商列表
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Supplier> GetSupplierList(Guid userId)
        {
            var q = _context.Suppliers.Where(x => x.CreateUserId == userId && !x.IsDelete);
            return q.ToList();
        }

        /// <summary>
        /// 删除供应商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DelSupplier(int id)
        {
            var model = _context.Suppliers.FirstOrDefault(x => x.Id == id && !x.IsDelete);
            model.IsDelete = true;
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 根据Id获取供应商
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Supplier GetSupplierById(int id)
        {
            var model = _context.Suppliers.FirstOrDefault(x => x.Id == id);
            return model;
        }

        /// <summary>
        /// 添加供应商
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddSupplier(Supplier model)
        {
            _context.Suppliers.Add(model);
            return _context.SaveChanges() > 0;
        }

        public bool UpdateSupplier(Supplier model)
        {
            var item = _context.Suppliers.FirstOrDefault(x => x.Id == model.Id);
            item.SupplierName = model.SupplierName;
            item.SupplierCompany = model.SupplierCompany;
            item.SupplierNum = model.SupplierNum;
            item.Tel = model.Tel;
            return _context.SaveChanges() > 0;
        }



        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="account"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>
        public UserInfo Login(string account, string pwd, string ip = "")
        {
            var model =_context.UserInfoes.FirstOrDefault(x =>( x.Account == account ||x.Tel == account||x.UserNum == account)&& x.PassWord == pwd&&!x.IsDelete);
            if(model!=null)
            {
                model.LastLoginIP = ip;
                model.LastLoginTime = DateTime.Now;
                _context.SaveChanges();
            }
            return model;
        }

        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="index"></param>
        /// <param name="size"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="key"></param>
        /// <param name="isDelete"></param>
        /// <returns></returns>
        public PageData<UserInfo> GetUserByPage(int index ,int size,DateTime start,DateTime end, string province, string city, string area, string saleManId, int userType, string key,bool isDelete)
        {

            PageData<UserInfo> pager = new PageData<UserInfo>();
            pager.PageIndex = index;
            pager.PageSize = size;
            
            var q = from c in _context.UserInfoes
                    where c.Account.Contains(key)
                    || c.UserName.Contains(key)
                    || c.UserNum.Contains(key)
                    || c.SotreName.Contains(key)
                    || c.Tel.Contains(key)
                    || c.Addr.Contains(key)
                    select c;
            
            q = q.Where(x => x.CreateTime > start && x.CreateTime < end);
            q = q.Where(x => !x.IsDelete);
            q = q.Where(x => x.TypeId > 0);//类型ID大于0的为客户  下雨
            if (province != "-1"&&!string.IsNullOrWhiteSpace(province))
                q = q.Where(x => x.ProvinceNum == province);
            if (city != "-1" && !string.IsNullOrWhiteSpace(city))
                q = q.Where(x => x.CityNum == city);
            if (area != "-1" && !string.IsNullOrWhiteSpace(area))
                q = q.Where(x => x.AreaNum == area);
            if (saleManId != "-1" && !string.IsNullOrWhiteSpace(saleManId))
                q = q.Where(x => x.SaleManGuid.ToString() == saleManId);
            if (userType != 0)
                q = q.Where(x => x.TypeId == userType);
            pager.TotalCount = q.Count();
            var list = q.OrderByDescending(x=>x.CreateTime).Skip((index - 1) * size).Take(size).ToList();
            pager.ListData = list;
            return pager;
        }




        public string ExportUserInfo(DateTime start, DateTime end, string province, string city, string area, string saleManId, int userType, string key, bool isDelete)
        {
            var pager = GetUserByPage(1, 10000, start, end, province, city, area, saleManId, userType, key, false);
            string sWebRootFolder = AppDomain.CurrentDomain.BaseDirectory + "/DownLoadExcelexport";
            if (!Directory.Exists(sWebRootFolder))
                Directory.CreateDirectory(sWebRootFolder);
            string sFileName = "小店用户" + $"{Guid.NewGuid()}.xlsx";
            //把项目名加到指定存放的路径
            FileInfo file = new FileInfo(Path.Combine(sWebRootFolder, sFileName));

            using (ExcelPackage package = new ExcelPackage(file))
            {
                //添加worksheet的名字
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("商品列表");

                string title = "小店编号,小店区域,小店名称,小店地址,用户名,联系方式,创建时间,业务员,小店平米数,客户类型,单位ID,是否锁定";
                var tittles = title.Split(',');

                for (int i = 0; i < tittles.Length; i++)
                {
                    worksheet.Cells[1, i + 1].Value = tittles[i];

                }

                //添加值
                var rowNum = 2; // rowNum 1 is head
                foreach (var item in pager.ListData)
                {
                    worksheet.Cells["A" + rowNum].Value = item.UserNum;//第一列
                    worksheet.Cells["B" + rowNum].Value = item.Area;//第一列
                    worksheet.Cells["C" + rowNum].Value = item.SotreName;//第一列
                    worksheet.Cells["D" + rowNum].Value = item.Addr;//第一列
                    worksheet.Cells["E" + rowNum].Value = item.UserName;//第一列
                    worksheet.Cells["F" + rowNum].Value = item.Tel;//第一列
                    worksheet.Cells["G" + rowNum].Value = item.CreateTime.ToString("yyyy-MM-dd HH:mm:ss");//第一列
                    worksheet.Cells["H" + rowNum].Value = item.SaleManName;//第一列
                    worksheet.Cells["I" + rowNum].Value = item.StoreArea;//第一列
                    worksheet.Cells["J" + rowNum].Value = item.TypeName;//第一列
                    worksheet.Cells["K" + rowNum].Value = item.UserCode;//第一列
                    worksheet.Cells["L" + rowNum].Value = (item.IsLocked ? "锁定" : "未锁定");//第一列
                       rowNum++;
                }
                package.Save();
            }

            var fileUrl = Path.Combine(sWebRootFolder, sFileName);
            return fileUrl;



        }


        public UserInfo GetUserByUserId(Guid userId)
        {
            return _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
        }


        public List<UserInfo> GetSysUser(int type,Guid createUsrId)
        {
            var q = from c in _context.UserInfoes
                    where !c.IsDelete
                    && c.CreateUserId == createUsrId
                    && c.TypeId == type
                    select c;
            return q.ToList();
        }

        public UserInfo GetUserByUserAndType(Guid id,int type)
        {
            return _context.UserInfoes.FirstOrDefault(x => x.UserId == id&&x.TypeId == type&&!x.IsDelete);

        }
        /// <summary>
        /// 解锁
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool ToggaleLock(Guid userId)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
            if(user!=null)
            {
                user.IsLocked = !user.IsLocked;
                return _context.SaveChanges() > 0;
            }
            return false;
        }

        /// <summary>
        /// 获取类型列表
        /// </summary>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public List<UserType> GetTypeList(bool isAdmin =false)
        {
            var list = Utils.GetUserTypes();
            return list;
        }

        
       


        /// <summary>
        /// 给客户设置业务员
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="saleManId"></param>
        /// <param name="saleManName"></param>
        /// <returns></returns>
        public bool SetSaleMan(Guid userId, Guid saleManId, string saleManName)
        {
            var model = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId);
            if(model!=null)
            {
                model.SaleManGuid = saleManId;
                model.SaleManName = saleManName;
            }
            return _context.SaveChanges() > 0;
        }


        public bool ChangePwd(Guid userId, string oldPwd, string newPwd)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserId == userId && x.PassWord == oldPwd && !x.IsDelete);
            if (user != null)
                user.PassWord = newPwd;
            return _context.SaveChanges()>0 ;
        }

        public bool IsExitNum(string num)
        {
            var user = _context.UserInfoes.FirstOrDefault(x => x.UserNum == num);
            if (user == null)
                return false;
            else return true;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<UserInfo> GetUserInfByNunm(List<string> nums, Guid userId)
        {
            var q = from c in _context.UserInfoes
                    where nums.Contains(c.UserNum)
                    && c.CreateUserId == userId
                    && !c.IsDelete
                    select c;
            return q.ToList();
        }

        public List<UserInfo> GetUserInfoByUserType(List<int> types,Guid userId)
        {
            var q = from c in _context.UserInfoes
                    where types.Contains(c.TypeId)
                    && c.CreateUserId == userId
                    && !c.IsDelete
                    select c;
            return q.ToList();
        }

        public List<string> GetUserSourse(Guid userId)
        {
            var list = new List<string>();
            var q = _context.UserResourses.Where(x => x.UserId == userId);
            list = q.Select(x => x.Resourse).ToList();
            return list;
        }


        public bool SaveUserResourse(Guid userId,List<string> resourse)
        {
            var q= _context.UserResourses.Where(x => x.UserId == userId);
            _context.UserResourses.RemoveRange(q);
            var list = new List<UserResourse>();
            resourse.ForEach(x =>
            {
                if (!string.IsNullOrWhiteSpace(x))
                {
                    var model = new UserResourse();
                    model.UserId = userId;
                    model.Resourse = x;
                    list.Add(model);
                }
            });
            _context.UserResourses.AddRange(list);
            return _context.SaveChanges() > 0;
        }

        public List<string> GetAllSourse()
        {
            var list = new List<string>();
            list.Add("财务管理员");
            list.Add("订单管理");
            list.Add("财务");
            list.Add("仓库");
            list.Add("业务员查询订单");
            list.Add("财务查询");
            list.Add("统计权限");
            list.Add("商品编辑管理员");
            list.Add("公告管理");
            list.Add("首页查看");
            list.Add("订单综合统计");
            list.Add("修改密码");
            list.Add("订单导出");
            list.Add("小店列表");
            list.Add("商品账单主管");
            list.Add("供应商管理");
            list.Add("活动管理");
            list.Add("系统管理");
            list.Add("业务员管理");
            list.Add("分拣管理");
            list.Add("应收未收对比");
            list.Add("取消订单");
            list.Add("小店管理");
            list.Add("订单收款撤销");
            list.Add("商品查询");
            list.Add("送货员管理");
            list.Add("商品导出");
            return list;
        }
    }
}
