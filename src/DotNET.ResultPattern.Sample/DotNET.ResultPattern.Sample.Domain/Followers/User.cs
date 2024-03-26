namespace DotNET.ResultPattern.Sample.Domain.Followers
{
    public sealed record User(Guid Id, Boolean HasPublicProfile = false);
}