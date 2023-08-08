using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework.Configurations.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.Data.Postgres.EntityFramework.Configurations
{
    public class TweetConfiguration : Configuration<Tweet,int>
    {
        public override void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Tweet_no).IsRequired();
            builder.HasIndex(x => x.Tweet_no).IsUnique(); // Burada Advert No'yu Unique olduğunu belirttik bu sayede karışıklık ihtimali ortadan kalktı
            builder.Property(x => x.Tweet_date).IsRequired();
            builder.Property(x => x.Tweet_title).IsRequired();
            builder.Property(x => x.Tweet_text).IsRequired();


       

        }

    }
}
