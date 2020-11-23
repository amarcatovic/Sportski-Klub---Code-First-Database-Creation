using System;
using System.Collections.Generic;
using System.Text;

namespace Sportski_Klub.Models
{
    public class ClubMedia
    {
        public Club Club { get; set; }

        public int ClubId { get; set; }

        public Media Media { get; set; }

        public int MediaId { get; set; }

        public DateTime PublishDate { get; set; }

        public string ArticleUrl { get; set; }
    }
}
