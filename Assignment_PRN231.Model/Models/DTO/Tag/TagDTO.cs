using Assignment_PRN231.Model.Models.DTO.NewsArticle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.Model.Models.DTO.Tag
{
    public class TagDTO
    {
        public int TagId { get; set; }

        public string? TagName { get; set; }

        public string? Note { get; set; }
        public virtual ICollection<NewsArticleDTO> NewsArticles { get; set; } = new List<NewsArticleDTO>();
    }
}
