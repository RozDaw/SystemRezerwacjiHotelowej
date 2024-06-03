using System.ComponentModel.DataAnnotations;

namespace SystemRezerwacjiHotelowej.Components
{
    public class Reservation
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataMeldunku { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataWymeldowania { get; set; }
        public bool CzyOplacona { get; set; }
        public bool CzyZameldowany { get; set; }
        public bool Parking { get; set; }
        public bool Animator { get; set; }
        public int LiczbaOsob { get; set; }
        public int Cena { get; set; }
    }
}
