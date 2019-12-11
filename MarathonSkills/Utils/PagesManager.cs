using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.Utils
{
    public class PagesManager<T> where T : class
    {
        private readonly DbSet<T> entities;

        public PagesManager(DbSet<T> entities, int pageSize = 20)
        {
            this.entities = entities;
            PageSize = pageSize;
        }

        public int PageSize { get; set;}
        private int currentPage;

        //page starts from 1
        public IEnumerable<T> LoadPage(int page)
        {
            if (page <= PagesCount() && page > 0)
            {
                currentPage = page;
                return entities.Skip(PageSize * (page - 1)).Take(PageSize).ToList();
            }
            return new List<T>();
        }

        public IEnumerable<T> LoadNextPage()
        {
            return LoadPage(currentPage + 1);
        }


        public IEnumerable<T> LoadPreviousPage()
        {
            return LoadPage(currentPage - 1);
        }

        public int PagesCount()
        {
            return (int)Math.Ceiling((double)entities.Count() / PageSize);
        }


    }
}
