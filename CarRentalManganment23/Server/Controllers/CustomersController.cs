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
	public class CustomersController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public CustomersController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Customers
		[HttpGet]
		public async Task<IActionResult> GetCustomers()
		{
			var Customers = await _unitOfWork.Customers.GetAll();
			return Ok(Customers);
		}

		// GET: api/Customers/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetCustomer(int id)
		{
			var Customer = await _unitOfWork.Customers.Get(q => q.Id == id);
			if (Customer == null)
			{
				return NotFound();
			}

			return Ok(Customer);
		}

		// PUT: api/Customers/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutCustomer(int id, Customer Customer)
		{
			if (id != Customer.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Customers.Update(Customer);

			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await CustomerExists(id))
				{
					return NotFound();
				}
			}
			return NoContent();
		}

		// POST: api/Customers
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Customer>> PostCustomer(Customer Customer)
		{
			await _unitOfWork.Customers.Insert(Customer);
			await _unitOfWork.Save(HttpContext);

			// Return a proper ActionResult
			return CreatedAtAction(nameof(GetCustomer), new { id = Customer.Id }, Customer);
		}

		// DELETE: api/Customers/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCustomer(int id)
		{
			var Customer = await _unitOfWork.Customers.Get(q => q.Id == id);

			if (Customer == null)
			{
				return NotFound();
			}

			await _unitOfWork.Customers.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> CustomerExists(int id)
		{
			var Customer = await _unitOfWork.Customers.Get(q => q.Id == id);
			return Customer != null;
		}
	}
}
