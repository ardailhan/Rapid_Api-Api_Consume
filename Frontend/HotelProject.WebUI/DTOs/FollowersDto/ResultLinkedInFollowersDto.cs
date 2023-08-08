namespace HotelProject.WebUI.DTOs.FollowersDto
{
    public class ResultLinkedInFollowersDto
    {
        public Data data { get; set; }
        public class Data
        {
            public int followers_count { get; set; }
        }
    }
}
