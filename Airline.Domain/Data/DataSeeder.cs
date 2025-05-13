using Airline.Domain.Entity;
using System.Collections.Generic;

namespace Airline.Domain.Data;

/// <summary>
///  ????? ??? ?????????? ????????? ?????? ? ???????.
/// </summary>
public static class DataSeeder
{
	/// <summary>
	/// ?????? ??????, ????????? ? ???????.
	/// </summary>
	public static readonly List<Flight> Flights =
	[
		new() { Id = 1, Code = "AB0001", DeparturePoint = "??????", ArrivalPoint = "??????", DepartureDate = new DateTime(2025, 12, 10), ArrivalDate = new DateTime(2025, 12, 11), DepartureTime = TimeSpan.FromHours(10), TravelTime = TimeSpan.FromHours(2), AircraftType = "Airbus A320" },
		new() { Id = 2, Code = "AB0002", DeparturePoint = "??????", ArrivalPoint = "????", DepartureDate = new DateTime(2025, 3, 30), ArrivalDate = new DateTime(2025, 3, 31), DepartureTime = TimeSpan.FromHours(12), TravelTime = TimeSpan.FromHours(4), AircraftType = "Boeing 228" },
		new() { Id = 3, Code = "AB0003", DeparturePoint = "??????", ArrivalPoint = "??????", DepartureDate = new DateTime(2025, 10, 3), ArrivalDate = new DateTime(2023, 10, 3), DepartureTime = TimeSpan.FromHours(14), TravelTime = TimeSpan.FromHours(3), AircraftType = "Boeing 228" },
		new() { Id = 4, Code = "AB0004", DeparturePoint = "???????", ArrivalPoint = "??????", DepartureDate = new DateTime(2025, 5, 12), ArrivalDate = new DateTime(2025, 5, 12), DepartureTime = TimeSpan.FromHours(16), TravelTime = TimeSpan.FromHours(5), AircraftType = "Boeing 228" },
		new() { Id = 5, Code = "AB0005", DeparturePoint = "??????", ArrivalPoint = "???????????", DepartureDate = new DateTime(2025, 5, 13), ArrivalDate = new DateTime(2025, 5, 13), DepartureTime = TimeSpan.FromHours(18), TravelTime = TimeSpan.FromHours(2), AircraftType = "Boeing 228" },
		new() { Id = 6, Code = "FAB0006", DeparturePoint = "???????????", ArrivalPoint = "??????", DepartureDate = new DateTime(2025, 5, 13), ArrivalDate = new DateTime(2023, 5, 13), DepartureTime = TimeSpan.FromHours(20), TravelTime = TimeSpan.FromHours(4), AircraftType = "Boeing 228" },
		];

	/// <summary>
	/// ?????? ????????? ????????? ? ???????.
	/// </summary>
	public static readonly List<Aircraft> Aircrafts =
	[
		new() { Id = 1, Model = "Boeing 228", LoadCapacity = 1000, Performance = 300, MaxPassengers = 200 },
		new() { Id = 2, Model = "Airbus A320", LoadCapacity = 45000, Performance = 750, MaxPassengers = 180 }
	];

	/// <summary>
	/// ?????? ??????????, ?????????????????? ? ???????.
	/// </summary>
	public static readonly List<Passenger> Passengers =
	[
		new() { Id = 1, PassportNumber = "1111111111", FullName = "???????? ?.?." },
		new() { Id = 2, PassportNumber = "2222222222", FullName = "?????? ?.?." },
		new() { Id = 3, PassportNumber = "3333333333", FullName = "????????? ?.?." },
		new() { Id = 4, PassportNumber = "4444444444", FullName = "?????? ?.?." },
		new() { Id = 5, PassportNumber = "5555555555", FullName = "????? ?.?." }
	];

	/// <summary>
	/// ?????? ????????????, ????????? ???????????.
	/// </summary>
	public static readonly List<Booking> Bookings =
	[
		new() { Id = 1, FlightId = 1, PassengerId = 1, TicketNumber = "TIC1", SeatNumber = "Q1", BaggageWeight = 55 },
		new() { Id = 2, FlightId = 1, PassengerId = 2, TicketNumber = "TIC2", SeatNumber = "A22", BaggageWeight = 0 },
		new() { Id = 3, FlightId = 2, PassengerId = 3, TicketNumber = "TIC3", SeatNumber = "B1", BaggageWeight = 15 },
		new() { Id = 4, FlightId = 2, PassengerId = 4, TicketNumber = "TIC4", SeatNumber = "B2", BaggageWeight = 0 },
		new() { Id = 5, FlightId = 3, PassengerId = 5, TicketNumber = "TIC5", SeatNumber = "C1", BaggageWeight = 10 }
	];
}