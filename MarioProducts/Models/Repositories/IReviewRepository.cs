﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarioProducts.Models
{
	public interface IReviewRepository
	{
		IQueryable<Review> Reviews { get; }
		IQueryable<Product> Products { get; }
		Review Save(Review review);
		Review Edit(Review review);
		void Remove(Review review);
	}
}