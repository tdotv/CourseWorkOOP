﻿using Microsoft.AspNetCore.Mvc;
using WebCarRentalSystem.Models;

namespace WebCarRentalSystem.Interfaces
{
    public interface ICarRepository
    {
        Task<IEnumerable<Car>> GetAll();
        Task<IEnumerable<Car>> GetAllNoTracking();
        Task<Car> GetByIdAsync(int id);
        Task<Car> GetByIdAsyncNoTracking(int id);
        bool Add(Car car);
        bool Edit(Car car);
        bool Delete(Car car);
        bool Save();
    }
}
