using System.ComponentModel.DataAnnotations;

namespace rs2_rent_sistem.Model.Requests
{
    public class ReviewUpsertObject
    {
        [MaxLength(300, ErrorMessage = "The review can't be more than 300 characters.")]
        public string? Description { get; set; }
        public double NumberOfStars { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can not be empty.")]
        public int OrderItemID { get; set; }
    }
}
