﻿namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCategory
    {
        public int MessageCategoryID { get; set; }
        public string MessageCategoryName { get; set; }
        //Navigation Property
        public List<Contact> Contacts { get; set; }
    }
}
