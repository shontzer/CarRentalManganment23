using CarRentalManganment23.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
	public interface IUnitOfWork : IDisposable
	{
		Task Save(HttpContext httpContext);
		IGenericRepository<Make> Makes { get; }
		IGenericRepository<Model> Models { get; }
		IGenericRepository<Vehicle> Vehicles { get; }
		IGenericRepository<Color> Colours { get; }
		IGenericRepository<Booking> Bookings { get; }
		IGenericRepository<Customer> Customers { get; }
	}
}