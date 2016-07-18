using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DemoApplication.Models
{
	public class DemoPersonViewModel
	{
		
		[Required(ErrorMessage = "Please enter First Name")]	
		[MinLength(2)]
		[Display(Name = "First Name")]
		public string FirstName { get; set; }

		[Required]
		[MinLength(2)]
		[Display(Name = "Last Name")]
		public string LastName { get; set; }

		[Required]
		[Range(19, 26)]
		public int Age { get; set; }

		public CountryViewModel Country { get; set; }
	}
}