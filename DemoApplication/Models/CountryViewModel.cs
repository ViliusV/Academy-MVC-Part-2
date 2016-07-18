using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DemoApplication.Models
{
	public class CountryViewModel
	{
		public string Title { get; set; }

		public string Capital { get; set; }

		public float Population { get; set; }
	}
}