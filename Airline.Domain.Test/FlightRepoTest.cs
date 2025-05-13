using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Airline.Domain.Entity;
using Airline.Domain.Services.InMemory;
using Xunit;

namespace Airline.Domain.Tests;

public class FlightRepoTests
{
	[Fact]
	public async Task GetFlightsByRoute_Success()
	{
		var repo = new FlightInMemoryRepo();
		var flights = await repo.GetFlightsByRoute("Москва", "Санкт-Петербург");

		Assert.NotNull(flights);
		Assert.True(flights.Count > 0);
	}
	[Fact]
	public async Task GetTop5FlightsByPassengerCount_Success()
	{
		var repo = new FlightInMemoryRepo();
		var flights = await repo.GetTop5FlightsByPassengerCount();

		Assert.NotNull(flights);
		Assert.True(flights.Count <= 5); 
	}

	[Fact]
	public async Task GetFlightsWithMinTravelTime_Success()
	{
		var repo = new FlightInMemoryRepo();
		var flights = await repo.GetFlightsWithMinTravelTime();

		Assert.NotNull(flights);
		Assert.True(flights.Count > 0);

		var minTravelTime = flights.First().TravelTime;
		Assert.All(flights, f => Assert.Equal(minTravelTime, f.TravelTime)); 
	}

	[Fact]
	public async Task GetFlightLoadByDeparturePoint_Success()
	{
		var repo = new FlightInMemoryRepo();
		var result = await repo.GetFlightLoadByDeparturePoint("Санкт-Петербург");

		Assert.True(result.AverageLoad >= 0); 
		Assert.True(result.MaxLoad >= 0); 
	}

	[Fact]
	public async Task GetFlightLoadByDeparturePoint_NoFlights()
	{
		var repo = new FlightInMemoryRepo();
		var result = await repo.GetFlightLoadByDeparturePoint("вывы");

		Assert.Equal(0.0, result.AverageLoad); 
		Assert.Equal(0.0, result.MaxLoad);
	}

    [Fact]
    public async Task AddFlight_Success()
    {
        var repo = new FlightInMemoryRepository();
        var newFlight = new Flight
        {
            Id = 100,
            Code = "SU100",
            DeparturePoint = "Москва",
            ArrivalPoint = "Санкт-Петербург",
            DepartureDate = new DateTime(2023, 10, 10),
            ArrivalDate = new DateTime(2023, 10, 10),
            DepartureTime = TimeSpan.FromHours(10),
            TravelTime = TimeSpan.FromHours(2),
            AircraftType = "Boeing 737"
        };

        var addedFlight = await repo.Add(newFlight);
        var retrievedFlight = await repo.GetById(100);

        Assert.NotNull(retrievedFlight);
        Assert.Equal(newFlight.Code, retrievedFlight.Code);
    }

    [Fact]
    public async Task UpdateFlight_Success()
    {
        var repo = new FlightInMemoryRepo();
        var flightToUpdate = (await repo.GetFlightsByRoute("Москва", "Санкт-Петербург")).First();

        flightToUpdate.Code = "SU200";
        var updatedFlight = await repo.Update(flightToUpdate);

        var retrievedFlight = await repo.GetById(flightToUpdate.Id);

        Assert.NotNull(retrievedFlight);
        Assert.Equal("SU200", retrievedFlight.Code);
    }

    [Fact]
    public async Task DeleteFlight_Success()
    {
        var repo = new FlightInMemoryRepo();
        var flightToDelete = (await repo.GetFlightsByRoute("Москва", "Санкт-Петербург")).First();

        var deleteResult = await repo.Delete(flightToDelete.Id);
        var deletedFlight = await repo.GetById(flightToDelete.Id);

        Assert.True(deleteResult);
        Assert.Null(deletedFlight);
    }

    [Fact]
	public async Task GetAllFlights_Success()
	{
		var repo = new FlightInMemoryRepo();
		var flights = await repo.GetAll();

		Assert.NotNull(flights);
		Assert.True(flights.Count > 0);
	}

	[Fact]
	public async Task GetById_FlightExists()
	{
		var repo = new FlightInMemoryRepo();
		var flight = await repo.GetById(1); 

		Assert.NotNull(flight);
		Assert.Equal(1, flight.Id);
	}

	[Fact]
	public async Task GetById_FlightNotExists()
	{
		var repo = new FlightInMemoryRepo();
		var flight = await repo.GetById(-100); 

		Assert.Null(flight);
	}
}