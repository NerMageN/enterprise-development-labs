using System.ComponentModel.DataAnnotations;

namespace Airline.Domain.Entity;

/// <summary>
/// Модель бронирования рейса
/// </summary>
public class Booking
{
    /// <summary>
    /// Уникальный идентификатор бронирования
    /// </summary>
    [Key]
    public required int Id { get; set; }

    /// <summary>
    /// Идентификатор связанного рейса
    /// </summary>
    public required int FlightId { get; set; }

    /// <summary>
    /// Идентификатор пассажира
    /// </summary>
    public required int PassengerId { get; set; }

    /// <summary>
    /// Номер билета (уникальный идентификатор)
    /// </summary>
    public required string TicketNumber { get; set; }

    /// <summary>
    /// Номер места в самолете
    /// </summary>
    public required string SeatNumber { get; set; }

    /// <summary>
    /// Общий вес багажа в килограммах
    /// </summary>
    public required double BaggageWeight { get; set; }
}