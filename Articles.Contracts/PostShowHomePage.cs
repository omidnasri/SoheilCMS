﻿using System;
using System.Collections.Generic;

namespace Articles.Contracts
{
    public class PostShowHomePage
    {
        public int PostId { get; set; }
        public string Title { get; set; }

        public DateTime SendDate { get; set; }

        
        public int VisitCount { get; set; }


        public string PostImage { get; set; }

        public IEnumerable<string> Tag { get; set; }

        public string CategoryName { get; set; }

        public string AuthorName { get; set; }

        public int AuthorId { get; set; }
        
        public int TagId { get; set; }

        public int CategoryId { get; set; }
        public string Slug { get; set; }
        public string Summary { get; set; }
    }
}
