using System.ComponentModel.DataAnnotations;

namespace WebApplicationTest.Data
{
    public class Reservation
    {

        public int Id { get; set; }

        [StringLength(50)]
        public string LastName { get; set; } = string.Empty;

        [StringLength(50)]
        public string FirstName { get; set; } = string.Empty;


        [StringLength(13)]
        public string SocialSecurityNumber { get; set; } = string.Empty;

        [StringLength(40)]
        public string PhoneNumber { get; set; } = string.Empty;
        public int RoomNumber { get; set; }

        public DateTime DateTimeStart { get; set; }
        public DateTime DateTimeEnd { get; set; }
    }
}
