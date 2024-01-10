using DtoLayer.TeamFriendDtos;
using EntityLayer.Entity;

namespace BusinessLayer.Abstract
{
    public interface ITeamFriendService : IGenericService<TeamFriend>
    {
        public IEnumerable<ResultTeamFriendDto> BusinessGetFriendsForTrue();
    }
 
}
