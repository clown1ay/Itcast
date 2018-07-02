using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DalFactory
{
    public partial class SimpleFactory
    {
        public static Shop.IDal.IBookType GetBookTypeDal()
        {
            return new Shop.DAL.BookType();
        }
    }
}
