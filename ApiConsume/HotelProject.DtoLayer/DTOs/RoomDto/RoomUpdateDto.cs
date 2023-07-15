using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DtoLayer.DTOs.RoomDto
{
    public class RoomUpdateDto
    {
        public int RoomID { get; set; }
        [Required(ErrorMessage = "Please enter the room number")]
        public string RoomNumber { get; set; }
        [Required(ErrorMessage = "Please enter the room image")]
        public string RoomCoverImage { get; set; }
        [Required(ErrorMessage = "Please enter the room price")]
        public int Price { get; set; }
        [Required(ErrorMessage = "Please enter the room title")]
        [StringLength(100, ErrorMessage = "Must be maximum 100 charachters")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter the bed count")]
        public string BedCount { get; set; }
        [Required(ErrorMessage = "Please enter the bath count")]
        public string BathCount { get; set; }
        public string Wifi { get; set; }
        [Required(ErrorMessage = "Please enter any description")]
        public string Description { get; set; }
    }
}
