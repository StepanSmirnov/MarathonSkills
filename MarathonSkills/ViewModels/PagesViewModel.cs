using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarathonSkills.ViewModels
{
    public class PageData
    {
        public string ControllerName { get; set; }

        public string ActionName { get; set; }

        [BindProperty]
        public int CurrentPage { get; set; }

        [BindProperty]
        public int PagesCount { get; set; }

        public int ButtonsLimit { get; set; }

        public IEnumerable<int> PageNumbers()
        {
            if (PagesCount <= ButtonsLimit)
                return Enumerable.Range(1, PagesCount);
            int left = CurrentPage - (int)Math.Ceiling((double)ButtonsLimit / 2) + 1;
            if (left < 1)
                return Enumerable.Range(1, ButtonsLimit);
            int right = CurrentPage + (int)Math.Floor((double)ButtonsLimit / 2);
            if (right > PagesCount)
                return Enumerable.Range(PagesCount - ButtonsLimit + 1, ButtonsLimit);
            return Enumerable.Range(left, PagesCount);
        }
    }

    public class PagesViewModel<T>
    {
        public IEnumerable<T> Items { get; set; }

        public PageData Data;
    }
}
