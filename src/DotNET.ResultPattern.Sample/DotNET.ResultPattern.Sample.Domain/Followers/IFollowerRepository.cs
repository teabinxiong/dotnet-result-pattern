using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.ResultPattern.Sample.Domain.Followers
{
    public interface IFollowerRepository
    {
        void Insert(Follower follower);

        Task<Boolean> IsAlreadyFollowingAsync(Guid id, Guid followerdId, CancellationToken ct);

    }
}
