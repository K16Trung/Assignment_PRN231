using Assignment_PRN231.Model.Models.DTO.NewsArticle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_PRN231.Model.Models.DTO.Category
{
    public class CategoryDTO
    {
        public short CategoryId { get; set; }

        public string CategoryName { get; set; } = null!;

        public string CategoryDesciption { get; set; } = null!;

        public short? ParentCategoryId { get; set; }

        public bool? IsActive { get; set; }
        public ICollection<CategoryDTO> InverseParentCategor { get; set; } = new List<CategoryDTO>();
        public ICollection<NewsArticleDTO> NewsArticles { get; set; } = new List<NewsArticleDTO>();
    }
}
