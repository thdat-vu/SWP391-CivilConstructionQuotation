﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using SWP391.CHCQS.Model;

namespace SWP391.CHCQS.OurHomeWeb.Areas.Manager.ViewModels
{
	public class StandardQuotationViewModel
	{
		public StandardQuotation StandardQuotation { get; set; }

		[ValidateNever]
		public IEnumerable<SelectListItem> ConstructionTypeList { get; set; }
	}
}
