using Business.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Update
{
    public class TweetUpdateDto
    {
        public int tweet_no { get; set; } = default!;
        public string tweet_date { get; set; } = default!;
        public string tweet_title { get; set; } = default!;
        public string tweet_text { get; set; } = default!;


    }
}
