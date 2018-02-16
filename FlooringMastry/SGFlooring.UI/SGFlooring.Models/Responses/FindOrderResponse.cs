﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Models.Responses
{
	public class FindOrderResponse
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public Order OriginalOrder { get; set; }
		public Order CopyOrder { get; set; }
	}
}
