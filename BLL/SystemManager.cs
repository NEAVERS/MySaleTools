using Common;
using Common.Entities;
using Dal;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{

    public class SystemManager
    {
        private SaleToolsContext _context = new SaleToolsContext();

        /// <summary>
        /// 获取系统配置项
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public SysConfig GetConfig(SysConfigTypes type)
        {
            var model = _context.SysConfigs.FirstOrDefault(x => x.Type == type.ToString());
            return model;
        }

        /// <summary>
        /// 保存系统配置项
        /// </summary>
        /// <param name="config"></param>
        /// <returns></returns>
        public bool SaveSysConfig(SysConfig config)
        {
            var model = _context.SysConfigs.FirstOrDefault(x => x.Type == config.Type);
            if (model == null)
                _context.SysConfigs.Add(config);
            else
            {
                model.Value = config.Value;
                model.UpdateUser = config.UpdateUser;
                model.UpdateTime = config.UpdateTime;
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        ///  获取图片设置
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<ImgSet> GetImgSet(int type = -1)
        {
            var q = from c in _context.ImgSets
                    join d in _context.ImgSetOfUserTypes on c.Id equals d.ImgSetId
                    where type  <0 || d.UserType == type
                    select c;
            return q.Distinct().OrderByDescending(x=>x.SortedId).ToList();
        }



        /// <summary>
        /// 根据获取指定海报的可看用户类型
        /// </summary>
        /// <param name="imgSetId"></param>
        /// <returns></returns>
        public List<UserType> GetUserTypeByImgSetId(Guid imgSetId)
        {
            var types = Utils.GetUserTypes();
            var q = from c in _context.ImgSetOfUserTypes
                    where c.ImgSetId == imgSetId
                    select c.UserType;
            return types.Where(x=>q.Contains(x.TypeId)).ToList();
        }


        /// <summary>
        /// 保存海报信息
        /// </summary>
        /// <param name="set"></param>
        /// <param name="userTypes"></param>
        /// <returns></returns>
        public bool SaveImgSet(ImgSet set,List<int> userTypes)
        {
            var model = _context.ImgSets.FirstOrDefault(x => x.Id == set.Id);
            List<ImgSetOfUserType> list = new List<ImgSetOfUserType>();
            userTypes.ForEach(x =>
            {
                var setOfType = new ImgSetOfUserType();
                setOfType.ImgSetId = set.Id;
                setOfType.UserType = x;
                list.Add(setOfType);

            });
            if(model == null)
            {
                _context.ImgSets.Add(set);
            }
            else
            {
                model.Ttile = set.Ttile;
                model.ImgType = set.ImgType;
                model.ImgUrl = set.ImgUrl;
                model.TurnUrl = set.TurnUrl;
                model.SortedId = set.SortedId;
                var _q = _context.ImgSetOfUserTypes.Where(x => x.ImgSetId == set.Id);
                _context.ImgSetOfUserTypes.RemoveRange(_q);
            }
            _context.ImgSetOfUserTypes.AddRange(list);
            return _context.SaveChanges() > 0;
        }

        public ImgSet GetImgeSetById(Guid setId)
        {
            var model = _context.ImgSets.FirstOrDefault(x => x.Id == setId);
            return model;
        }

        public bool DeleteImgSet(Guid id)
        {
            var model = _context.ImgSets.FirstOrDefault(x => x.Id == id);
            if (model != null)
                _context.ImgSets.Remove(model);
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 获取所有公告
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Notice> GetAllNotice(Guid userid)
        {
            var q = _context.Notices.Where(x => x.CreateUserId == userid && !x.IsDelete);
            return q.ToList();
        }

        /// <summary>
        /// 根据ID获取公告信息
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public Notice GetNoticeById(int Id)
        {
            return _context.Notices.FirstOrDefault(x => x.Id == Id);
        }

        /// <summary>
        /// 保存公告
        /// </summary>
        /// <param name="model"></param>
        /// <param name="userTypes"></param>
        /// <returns></returns>
        public bool SaveNotice(Notice model,List<int> userTypes)
        {
            if(model.Id>0)
            {
                var temp = _context.Notices.FirstOrDefault(x => x.Id == model.Id);
                temp.Tittle = model.Tittle;
                temp.Content = model.Content;
                temp.UserTypes = string.Join(",", userTypes);
            }
            else
            {
                model.UserTypes = string.Join(",", userTypes);
                _context.Notices.Add(model);
            }
            return _context.SaveChanges() > 0;
        }

        /// <summary>
        /// 删除公告
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DealNotice(int id)
        {
            var model = _context.Notices.FirstOrDefault(x => x.Id == id);
            if (model != null)
                model.IsDelete = true;
            return _context.SaveChanges() > 0;
        }


        public List<Notice> GetNoticeForShow(int userType,Guid createUserId)
        {
            var q = from c in _context.Notices
                    where c.CreateUserId == createUserId
                    && !c.IsDelete
                    && (c.UserTypes.Contains(userType.ToString()) || c.UserTypes.Contains("1"))
                    select c;
            return q.ToList();
        }

    }
}
