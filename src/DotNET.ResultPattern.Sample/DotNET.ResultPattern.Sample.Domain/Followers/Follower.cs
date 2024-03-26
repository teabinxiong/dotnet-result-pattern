using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.ResultPattern.Sample.Domain.Followers
{
    public sealed class Follower
    {
        User User { get; set; }

        User Followed { get; set; }

        DateTime CreatedOnUtc { get; set; }

        private Follower(User user, User followed, DateTime createdOnUtc)
        {
            User = user;
            Followed = followed;
            CreatedOnUtc = createdOnUtc;
        }

        public static Follower Create(Guid userId, Guid followedId, DateTime createdOnUtc)
        {
            var follower = new Follower(new User(userId), new User(followedId), createdOnUtc);

            return follower;
        }

    }
}
