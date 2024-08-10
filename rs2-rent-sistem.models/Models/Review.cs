namespace rs2_rent_sistem.models.Models
{
    public class Review
    {
        public int ID { get; set; }

        public DateTime? DateAdded { get; set; }

        public string? Description { get; set; }

        public decimal? NumberOfStars { get; set; }
        public virtual User? AddedByUser { get; set; }//todo:maybe just check if added by current user
    }
}
