using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManganment23.Server.Data;
using CarRentalManganment23.Shared.Domain;
using CarRentalManagement.Server.IRepository;

namespace CarRentalManganment23.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public BookingsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Bookingss
		[HttpGet]
		public async Task<IActionResult> GetBookingss()
		{
			var Bookingss = await _unitOfWork.Bookings.GetAll();
			return Ok(Bookingss);
		}

		// GET: api/Bookingss/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBookings(int id)
		{
			var Bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
			if (Bookings == null)
			{
				return NotFound();
			}

			return Ok(Bookings);
		}

		// PUT: api/Bookingss/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutBookings(int id, Booking Bookings)
		{
			if (id != Bookings.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Bookings.Update(Bookings);

			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await BookingsExists(id))
				{
					return NotFound();
				}
			}
			return NoContent();
		}

		// POST: api/Bookingss
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Booking>> PostBookings(Booking Bookings)
		{
			await _unitOfWork.Bookings.Insert(Bookings);
			await _unitOfWork.Save(HttpContext);

			// Return a proper ActionResult
			return CreatedAtAction(nameof(GetBookings), new { id = Bookings.Id }, Bookings);
		}

		// DELETE: api/Bookingss/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBookings(int id)
		{
			var Bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);

			if (Bookings == null)
			{
				return NotFound();
			}

			await _unitOfWork.Bookings.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> BookingsExists(int id)
		{
			var Bookings = await _unitOfWork.Bookings.Get(q => q.Id == id);
			return Bookings != null;
		}
	}
}
