using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();
       
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }

        public int AddAuthorBL (Author p)
        {
            if (p.AuthorName==""||p.AboutShort==""||p.AuthorTitle=="")
            {   
                return -1;
            }
            return repoauthor.Insert(p);
        }
    }
}
