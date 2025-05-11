using RestaurantApp.Application.Dtos;
using RestaurantApp.Domain.Models;

namespace RestaurantApp.Application.Interfaces;

public interface IEventTypeService
{
    Task CreateAsync(CreateEventTypeDto createEventTypeDto);
    Task RemoveAsync(int id);
    Task<List<EventType>> GetAllAsync();
}