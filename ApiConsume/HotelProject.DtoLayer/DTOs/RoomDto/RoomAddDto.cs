using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.DTOs.RoomDto
{
    public class RoomAddDto
    {
        [Required(ErrorMessage = "Please enter the room number")]
        public string RoomNumber { get; set; }
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter any room title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter bed count")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please enter bath count")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        public string Description { get; set; }
    }
}
