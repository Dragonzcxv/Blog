using Blog.Interfaces;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Mocks
{
    public class MockCategory : IPostCategories
    {
        public IEnumerable<Category> AllCategories
        {
            get
            {
                return new List<Category>
                {
                    new Category{ Name = "C#", Description = "Категория C# разработки"},
                    new Category{ Name = "Web", Description = "Категория Web разработки"}
                };
            }
        }
    }
}
