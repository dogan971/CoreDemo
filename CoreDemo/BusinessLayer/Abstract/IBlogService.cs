using EntityLayer.Concreate;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IBlogService : IGenericService<Blog>
    {



        List<Blog> getListWithCategory();
        List<Blog> getBlogListWithWriter(int id);

    }
}
