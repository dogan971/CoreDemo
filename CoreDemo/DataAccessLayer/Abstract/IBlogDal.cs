using EntityLayer.Concreate;
using System.Collections.Generic;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> getListWithCategory();
        List<Blog> getListWithCategoryByWriter(int id);
    }
}
