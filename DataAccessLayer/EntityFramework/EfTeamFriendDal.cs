using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Entity;

namespace DataAccessLayer.EntityFramework
{
    public class EfTeamFriendDal : GenericRepository<TeamFriend>, ITeamFriendDal
    {
        private readonly FoodContext _foodContext;
        public EfTeamFriendDal(FoodContext foodContext) : base(foodContext)
        {
            _foodContext = foodContext;
        }

        public IEnumerable<TeamFriend> TeamFriendsForTrue()
        {
           return _foodContext.TeamFriends.Where(x=>x.Status==true).ToList();
        }
    }

}
