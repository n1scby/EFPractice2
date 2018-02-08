using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IBlogRepository
    {
        List<Blog> ListAll();
        Blog GetById(int id);
        void Add(Blog newBlog);
        void Update(Blog updateBlog);
        void Delete(int id);

    }
}
