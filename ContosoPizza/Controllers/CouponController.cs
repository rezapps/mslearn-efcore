using ContosoPizza.Data;
using ContosoPizza.Models;
using ContosoPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContosoPizza.Controllers;

// Adding api/coupon endpoint to the Api

[ApiController]
[Route("[controller]")]
public class CouponController : ControllerBase
{
	PromotionsContext _context;

	public CouponController(PromotionsContext context)
	{
		_context = context;
	}

	[HttpGet]
	public IEnumerable<Coupon> Get()
	{
		return _context.Coupons
			.AsNoTracking()
			.ToList();
	}

}
