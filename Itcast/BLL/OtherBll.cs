using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shop.BLL
{
    public partial class BookType
    {
        public bool Delete(Shop.Model.BookType bookType)
        {
            return Delete(bookType.TypeId);
        }
    }
}
