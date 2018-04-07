using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserManager
    {
        private  SaleToolsContext _context = new SaleToolsContext();

        /// <summary>
        /// 用户注册
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public bool UserReg(UserInfo user)
        {
            _context.UserInfoes.Add(user);
            return _context.SaveChanges() > 0;
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
                model.PassWord = user.PassWord;
                model.Province = user.Province;
                model.ProvinceNum = user.ProvinceNum;
                model.CityNum = user.CityNum;
                model.City = user.City;
                model.AreaNum = user.CityNum;
                model.Area = user.AreaNum;
                model.ReceiveName = string.Empty;
                model.SaleManGuid = user.SaleManGuid;
                model.SaleManName = user.SaleManName;
                model.Addr = user.Addr;
                model.StoreArea = user.StoreArea;
                model.SotreName = user.SotreName;
                model.Email = user.Email;
                model.Remark = user.Remark;

            }

            return _context.SaveChanges() > 0;
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
        public UserInfo Login(string account,string pwd)
        {
            var model =_context.UserInfoes.FirstOrDefault(x => x.Account == account && x.PassWord == pwd&&!x.IsDelete);
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
        public List<UserInfo> GetUserByPage(int index ,int size,DateTime start,DateTime end, string province, string city, string area, string saleManId, int userType, string key,bool isDelete)
        {
            var q = from c in _context.UserInfoes
                    where c.Account.Contains(key)
                    || c.UserName.Contains(key)
                    || c.UserNum.Contains(key)
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
            var list = q.OrderByDescending(x=>x.CreateTime).Skip((index - 1) * size).Take(size).ToList();
            return list;
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
            var q = _context.UserTypes.Where(x=>x.IsAdmin == isAdmin||isAdmin).ToList();
            return q;
        }


        /// <summary>
        /// 添加用户类型
        /// </summary>
        /// <param name="userType"></param>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        public string AddUserType(string userType,bool isAdmin)
        {
            var q = _context.UserTypes.FirstOrDefault(x => x.TypeName == userType);
            if (q != null)
                return "该类型已经存在";
            UserType type = new UserType();
            type.TypeName = userType;
            type.IsAdmin = isAdmin;
            _context.UserTypes.Add(type);
            if (_context.SaveChanges() > 0)
                return "添加成功！";
            return "添加失败";
        }

        public UserType GetUserType(int typeId)
        {
            var model = _context.UserTypes.FirstOrDefault(x => x.TypeId == typeId);
            return model;
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
    }
}
