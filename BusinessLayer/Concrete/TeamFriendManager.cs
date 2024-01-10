using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DtoLayer.TeamFriendDtos;
using EntityLayer.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeamFriendManager : ITeamFriendService
    {
        private readonly ITeamFriendDal _teamFriendDal;

        public TeamFriendManager(ITeamFriendDal teamFriendDal)
        {
            _teamFriendDal = teamFriendDal;
        }

        public void BusinessDelete(TeamFriend entity)
        {
            _teamFriendDal.Delete(entity);
        }

        public List<TeamFriend> BusinessGetAll()
        {
            return _teamFriendDal.GetAll();
        }

        public TeamFriend BusinessGetById(int id)
        {
            return _teamFriendDal.GetById(id);
        }

        public IEnumerable<ResultTeamFriendDto> BusinessGetFriendsForTrue()
        {
            return _teamFriendDal.TeamFriendsForTrue()
         .Select(item => new ResultTeamFriendDto
         {
             FullName = item.FullName,
             ImageUrl = item.ImageUrl,
             Status = item.Status,
             TeamFriendId = item.TeamFriendId,
             Title = item.Title,
             FacebookUrl = item.FacebookUrl,
             InstagramUrl = item.InstagramUrl,
             TwitterUrl = item.TwitterUrl
         })
         .ToList();
        }

        public void BusinessInsert(TeamFriend entity)
        {
            _teamFriendDal.Insert(entity);
        }

        public void BusinessUpdate(TeamFriend entity)
        {
            _teamFriendDal.Update(entity);
        }
    }
}
