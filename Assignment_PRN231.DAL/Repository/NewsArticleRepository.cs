using Assignment_PRN231.DAL.Repository.IRepository;
using Assignment_PRN231.Model.Data;
using Assignment_PRN231.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.DAL.Repository
{
    public class NewsArticleRepository : GenericRepository<NewsArticle>, INewsArticleRepository
    {
        private readonly FunewsManagementSpring2025Context _context;

        public NewsArticleRepository(FunewsManagementSpring2025Context context) : base(context)
        {
            _context = context;
        }
    }
}
