using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace Infrastructure.Data.Postgres.Repositories
{
    public class TweetRepository : Repository<Tweet, int>, ITweetRepository
    {
        public TweetRepository(PostgresContext postgresContext) : base(postgresContext)
        {

        }

        public async Task<IList<Tweet>> GetTweetByIdAsync(int id)
        {
            return await PostgresContext.Set<Tweet>()
                  .Include(Tweet => Tweet.User)
            

                .Where(Tweet => Tweet.Id == id)
                .ToListAsync();
        }
        public override async Task<IList<Tweet>> GetAllAsync(Expression<Func<Tweet, bool>>? filter = null)
        {
            var tweet = PostgresContext.Set<Tweet>();
            return filter == null
                ? await tweet.ToListAsync()
                : await tweet.Where(filter)
                .ToListAsync();
        }


    }
}