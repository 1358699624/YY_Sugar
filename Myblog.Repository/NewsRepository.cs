using MyBlog.IRepository;
using MyBlog.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YY_Model;

namespace Myblog.Repository
{
    public  class NewsRepository:BaseRepository <NewsTable>,INewsRepository
    {
    }
}
