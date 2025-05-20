namespace BBU_SYSTEM.DTO;

public class GroupRoomDto
{
    	public int group_room_id { get; set; }
        public int group_id { get; set; }
        public int term_no { get; set; }
        public string? room_name { get; set; }
        public DateTime start_payment { get; set; }
}