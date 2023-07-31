using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GuestController : ControllerBase
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _guestService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddRoom(Guest guest)
        {
            _guestService.TInsert(guest);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var values = _guestService.TGetByID(id);
            _guestService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Guest guest)
        {
            _guestService.TUpdate(guest);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetRoom(int id)
        {
            var values = _guestService.TGetByID(id);
            return Ok(values);
        }
    }
}
