using DotNET.ResultPattern.Sample.Domain.Followers;
using Microsoft.AspNetCore.Mvc;

namespace DotNET.ResultPattern.Sample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FollowerController : ControllerBase
    {
 
        private readonly ILogger<FollowerController> _logger;

        private readonly FollowerService _followerService;

        public FollowerController(
            ILogger<FollowerController> logger,
            FollowerService followerService
            )
        {
            _logger = logger;
            _followerService = followerService;
        }

        [HttpPost(Name = "users/{userId}/follow/{followerId}")]
        public async Task<IResult> FollowAsync(Guid userId, Guid followedId)
        {
            var result = await _followerService.StartFollowingAsync(
            new User(userId),
            new User(followedId,true),
            DateTime.UtcNow);

            if (result.IsFailure)
            {
                return Results.BadRequest(result.Error);
            }

            return Results.NoContent();
        }
    }
}