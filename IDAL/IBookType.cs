﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.IDal
{
    public partial interface IBookType
    {
        int GetMaxId();
        bool Exists(int TypeId);
        int Add(Shop.Model.BookType model);
        bool Update(Shop.Model.BookType model);
        bool Delete(int TypeId);
        bool DeleteList(string TypeIdlist);
        Shop.Model.BookType GetModel(int TypeId);
        Shop.Model.BookType DataRowToModel(DataRow row);
        DataSet GetList(string strWhere);
        DataSet GetList(int Top, string strWhere, string filedOrder);
        int GetRecordCount(string strWhere);
        DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex);
    }
}
