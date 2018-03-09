﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGFlooring.Models.Responses
{
	public class AddOrderResponse
	{
		public bool Success { get; set; }
		public string Message { get; set; }
		public List<Order> AllOrders { get; set; }
	}
}
