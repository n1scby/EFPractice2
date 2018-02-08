using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlogLib
{
    public class BlogRepositoryEF : IBlogRepository
    {
        private readonly BloggingContext _dbContext;

        public BlogRepositoryEF(BloggingContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(Blog newBlog)
        {
            _dbContext.Add(newBlog);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> ListAll()
        {
            return _dbContext.Blogs.ToList();
        }

        public void Update(Blog updateBlog)
        {
            throw new NotImplementedException();
        }
    }
}
