using DotNET.ResultPattern.Sample.Domain.Followers;

namespace DotNET.ResultPattern.Sample.Data.Followers
{
    // the repository should be implemented inside a Infrastructure layer project
    public class FollowerRepository : IFollowerRepository
    {
        public void Insert(Follower follower)
        {
            // insert implementation here

        }

        public Task<bool> IsAlreadyFollowingAsync(Guid id, Guid followerdId, CancellationToken ct)
        {
            Boolean isAlreadyBeenFollowed = false;

            // check if the followed user already been followed here

            return Task.FromResult(isAlreadyBeenFollowed);
        }
    }
}
