
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Model
{
    public class Game
    {   
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("creator")]
        public string Creator { get; set; }
        [Column("style")]
        public string Style { get; set; }
        [Column("date_of_release")]
        public string DateOfRelease { get; set; }
    }
}
