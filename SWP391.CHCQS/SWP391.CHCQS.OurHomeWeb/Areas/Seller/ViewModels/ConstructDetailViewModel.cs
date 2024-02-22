﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.CHCQS.Model;

namespace SWP391.CHCQS.OurHomeWeb.Areas.Seller.ViewModels
{
	public class ConstructDetailViewModel
	{
		public ConstructDetail ConstructDetail { get; set; }

		[ValidateNever]
		public IEnumerable<SelectListItem> Basement { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Construction { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Foundation { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Investment { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> Rooftop { get; set; }
	}
}