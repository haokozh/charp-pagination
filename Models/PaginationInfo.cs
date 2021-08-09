using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PaginationInfo
    {
        public string urlTemplate;

        public string GetUrl(int pageNumber)
        {
            return $"{urlTemplate}{pageNumber}";
        }

        // 總筆數
        public int TotalRecords { get; set; }

        // 一頁會顯示的筆數
        public int PageSize { get; set; }

        // 頁碼
        public int PageNumber { get; set; }

        // 總頁數
        public int Pages => (int)Math.Ceiling((double)TotalRecords / PageSize);

        // 頁數欄會顯示的頁數
        public int PageItemCount => 5;

        // 頁數欄的起始數字
        public int PageBarStartNumber
        {
            get
            {
                int startNumber = PageNumber - ((int)Math.Floor((double)this.PageItemCount / 2));
                return startNumber < 1 ? 1 : startNumber;
            }
        }

        public int PageItemPrevNumber => (PageBarStartNumber <= 1)
            ? 1
            : PageBarStartNumber - 1;

        public int PageBarItemCount => PageBarStartNumber + PageItemCount > Pages
            ? Pages - PageBarStartNumber + 1
            : PageItemCount;

        public int PageItemNextNumber => (PageBarStartNumber + PageItemCount >= Pages)
            ? Pages
            : PageBarStartNumber + PageItemCount;
    }
}