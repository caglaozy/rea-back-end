using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities.Base;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Tweet : Entity<int>
    {
        public int Tweet_no { get; set; } = default!;
        public string Tweet_date { get; set; } = default!;
        public string Tweet_title { get; set; } = default!;
        public string Tweet_text { get; set; } = default!;
      
    

       
    
        public int User_id { get; set; }


        public User? User { get; set; }
    
    }
}
