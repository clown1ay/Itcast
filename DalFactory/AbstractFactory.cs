﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DalFactory
{
    public partial class AbstractFactory
    {
        public static Shop.IDal.IBookType GetBookTypeDal()
        {
            string  temp=System.Configuration.ConfigurationManager.AppSettings["BookTypeDal"];
            string[] temp2 = temp.Split(',');
            //反射:创建对象
            //1、获取程序集对象
            Assembly asm= Assembly.Load(temp2[1]);//程序集名称

            //2、创建实例
            object obj=asm.CreateInstance(temp2[0]);//类的完整名称

            return obj as Shop.IDal.IBookType;
        }
    }
}
