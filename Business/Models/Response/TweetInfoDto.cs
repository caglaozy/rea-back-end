using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Response
{
    public class TweetInfoDto
    {
        public int id { get; set; } = default!;
        public int Tweet_no { get; set; } = default!;
        public string Tweet_date { get; set; } = default!;
        public string Tweet_title { get; set; } = default!;
        public string Tweet_text { get; set; } = default!;
 


  
        public int User_id { get; set; }



        public UserProfileDto? User { get; set; }
        public TweetInfoDto? Animal { get; set; }


    }
}
