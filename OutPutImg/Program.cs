using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutPutImg
{
    class Program
    {
        static bool isCreate = false;

        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["path"].ToString();
            GoodsManager goodsManager = new GoodsManager();
            List<GoodInfo> list = goodsManager.GetAllGoods();
            if(!string.IsNullOrWhiteSpace(path)&& Directory.Exists(path))
            {
                list.ForEach(x =>
                {
                    string imgPath = path + x.pic1;
                    if (!File.Exists(imgPath))
                        WriteFile(x);
                });
            }
        }

        static void WriteFile(GoodInfo info)
        {
            string path = @"E:\info.csv";
            if (!isCreate)
            {
                FileStream fs = File.Create(path);
                fs.Close();
                isCreate = true;
            }
            string text = string.Format("{0},{1},{2},'{3}'\n\t", info.GoodsNum, info.Id.ToString(), info.GoodsTittle, info.BarCode);
            File.AppendAllText(path, text);
        }
    }
}
