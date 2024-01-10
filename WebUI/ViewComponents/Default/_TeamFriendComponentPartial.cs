using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.ViewComponents.Default
{
    public class _TeamFriendComponentPartial:ViewComponent
    {
        private readonly ITeamFriendService _teamFriendService;

        public _TeamFriendComponentPartial(ITeamFriendService teamFriendService)
        {
            _teamFriendService = teamFriendService;
        }

        public IViewComponentResult Invoke()
        {
            var value = _teamFriendService.BusinessGetFriendsForTrue();
            return View(value);
        }
    }
}
