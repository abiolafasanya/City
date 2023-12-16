using System.ComponentModel.DataAnnotations;

namespace RestApi.Models
{
    public class CityDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description {  get; set; }
        public int NumberOfInterests { get {  return Interests.Count; } }
        public List<InterestDto> Interests { get; set; } = new List<InterestDto>();
    }

    public class CityDtoEdit
    {
        [Required(ErrorMessage = "Name Field is required")]
        [MaxLength(50)]
        public string Name { get; set; } = string.Empty;
        [MaxLength(200)]
        public string? Description { get; set; }
    }
}
