﻿using BookStore.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.ViewModels
{
	public class ShoppingCartViewModel
	{
		public IEnumerable<ShoppingCart> CartItems { get; set; }
		public OrderHeader OrderHeader { get; set; }
	}
}
