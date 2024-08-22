using System.ComponentModel.DataAnnotations;

namespace rs2_rent_sistem.Model.Requests
{
    public class EquipmentCategoryUpsertObject
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field can not be empty.")]
        [MinLength(2, ErrorMessage = "The category name can't be less than 2 characters.")]
        [MaxLength(100, ErrorMessage = "The category name can't be more than 100 characters.")]
        public string Name { get; set; }

        [MaxLength(200, ErrorMessage = "The description can't be more than 200 characters.")]
        public string Description { get; set; }
    }
}
