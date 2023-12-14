namespace WebApplication01.Models
{
    public class HangHoaVM
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class HangHoa : HangHoaVM
    {
        public Guid MaHangHoa { get; set; }

    }
}
