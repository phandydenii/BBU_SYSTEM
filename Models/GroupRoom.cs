using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BBU_SYSTEM.Model;

[Table("group_room")]
public class GroupRoom
{
    [Key]
    public int group_room_id { get; set; }
    public int group_id { get; set; }
    public int term_no { get; set; }
    public string? room_name { get; set; }
    public DateTime? start_payment { get; set; }
}
