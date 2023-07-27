using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DesingPatternsASP.Models.ViewModels
{
	public class FormBeerViewModel
	{
		[Required]
		[Display(Name = "Name")]
		public string? Name { get; set; }

		[Required]
		[DisplayName("Style")]
		public string? Style { get; set; }

		[Display(Name = "Brand")]		
		
		public Guid? BrandId { get; set; }

		[Display(Name = "Other Brand")]
		public string? otherBrand { get; set; }
	}
}
