using RozkladSharp.Domain.Models;

namespace RozkladSharp.DomainServices
{
    public static class RankData
    {
        public static void Initialize(RozkladSharpDbContext context)
        {
            context.Ranks.AddRange(
                new Rank { Id = 0, Name = "асистент" },
                new Rank { Id = 1, Name = "доцент" },
                new Rank { Id = 2, Name = "викладач" },
                new Rank { Id = 3, Name = "старший викладач" },
                new Rank { Id = 4, Name = "професор" }
            );
        }
    }
}