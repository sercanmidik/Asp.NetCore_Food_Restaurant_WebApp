using EntityLayer.Entity;

namespace DataAccessLayer.Abstract
{
    public interface ITeamFriendDal : IGenericDal<TeamFriend>
    {
        public IEnumerable<TeamFriend> TeamFriendsForTrue();
    }
}
