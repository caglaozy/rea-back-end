using Business.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class TweetCreateDto
    {
        public int Tweet_no { get; set; } = default!;
        public string Tweet_date { get; set; } = default!;
        public string Tweet_title { get; set; } = default!;
        public string Tweet_text { get; set; } = default!;
   


        public int User_id { get; set; }




    }
}
