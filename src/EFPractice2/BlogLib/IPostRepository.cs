using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLib
{
    public interface IPostRepository
    {
        List<Post> ListAll();
        Post GetById(int id);
        void Add(Post newBlog);
        void Update(Post updateBlog);
        void Delete(int id);

    }
}
