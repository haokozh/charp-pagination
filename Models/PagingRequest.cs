using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PagingRequest
    {
        private int _PageNumber = 1;

        public int PageNumber
        {
            get { return _PageNumber; }
            set { _PageNumber = value < 1 ? 1 : value; }
        }

        private int _PageSize = 3;

        public int PageSize
        {
            get { return _PageSize; }
            set { _PageSize = value < 1 ? 3 : value; }
        }

        public int RecordStartIndex
        {
            get { return (PageNumber - 1) * PageSize; }
        }
    }
}