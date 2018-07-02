using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.BLL
{
    public partial class BookType
    {
        //简介工厂
        //private readonly Shop.IDal.IBookType dal = Shop.DalFactory.SimpleFactory.GetBookTypeDal();

        //抽象工厂
        private readonly Shop.IDal.IBookType dal = Shop.DalFactory.AbstractFactory.GetBookTypeDal();

        public bool Delete(Shop.Model.BookType bookType)
        {
            return Delete(bookType.TypeId);
        }

    }

    public partial class UserManager
    {
        public bool Update(Shop.Model.UserManager model,bool isPwdEdit)
		{
			return dal.Update(model,isPwdEdit);
		}

        public bool Exists(Shop.Model.UserManager model,out int id)
        {
            return dal.Exists(model,out id);
        }
    }
}
