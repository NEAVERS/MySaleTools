﻿using Common.Entities;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common
{
    public class Utils
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="myString"></param>
        /// <returns></returns>
        public static string GetMD5(string myString)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = System.Text.Encoding.Unicode.GetBytes(myString);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x");
            }
            return byte2String;
        }
        /// <summary>
        /// 根据字符串获取时间
        /// </summary>
        /// <param name="timeStr"></param>
        /// <param name="isStart"></param>
        /// <returns></returns>
        public static DateTime GetTime(string timeStr, bool isStart = false)
        {
            DateTime dt = new DateTime();
            if (!DateTime.TryParse(timeStr, out dt))
            {
                if (isStart)
                    dt = DateTime.Now.AddMonths(-1);
                else
                    dt = DateTime.Now;
            }
            return dt;
        }
        /// <summary>
        /// 转Json
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public static string SerializeObject(object o)
        {
            string json = JsonConvert.SerializeObject(o);
            return json;
        }


        public static T DeepCopyByJson<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            string json = JsonConvert.SerializeObject(obj);
            T newObj = JsonConvert.DeserializeObject<T>(json);
            return newObj;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public static Guid ParseGuid(string str)
        {
            Guid res = new Guid();
            if(!Guid.TryParse(str,out res))
            {
                res = Guid.Empty;
            }
            return res;
        }

        public static int ParseInt(string str)
        {
            int res = 0;
            if(!int.TryParse(str,out res))
            {
                res = 0;
            }
            return res;
        }

        public static decimal ParseDecimal(string str)
        {
            decimal res = 0;
            if (!decimal.TryParse(str, out res))
            {
                res = 0;
            }
            return res;
        }

        /// <summary>
        /// 深复制
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static T DeepCopyByReflect<T>(T obj)
        {
            //如果是字符串或值类型则直接返回
            if (obj is string || obj.GetType().IsValueType) return obj;
            object retval = Activator.CreateInstance(obj.GetType());
            FieldInfo[] fields = obj.GetType().GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in fields)
            {
                try { field.SetValue(retval, DeepCopyByReflect(field.GetValue(obj))); }
                catch { }
            }
            return (T)retval;
        }
        /// <summary>
        /// 获取所有的用户类型
        /// </summary>
        /// <returns></returns>
        public static List<UserType> GetUserTypes()
        {
            var list = new List<UserType>();
            foreach (StoreUserType type in Enum.GetValues(typeof(StoreUserType)))
            {
                var model = new UserType();
                model.TypeId = (int)type;
                model.TypeName = type.ToString();
                model.IsAdmin = false;
                list.Add(model);
            }
            return list;
        }
        /// <summary>
        /// 获取客户端Ip
        /// </summary>
        /// <returns></returns>
        public static string GetUserHostAddress()
        {
            string ip = string.Empty;
            try
            {
                var request = System.Web.HttpContext.Current.Request;
                ip = request.ServerVariables["HTTP_X_FORWARDED_FOR"];
                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.ServerVariables["REMOTE_ADDR"];
                }
                if (string.IsNullOrEmpty(ip))
                {
                    ip = request.UserHostAddress;
                }
            }
            catch (Exception)
            {

            }
            return ip;
        }

    }
}
