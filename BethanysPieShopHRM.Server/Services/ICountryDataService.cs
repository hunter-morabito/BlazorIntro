﻿using BethanysPieShopHRM.Shared;

namespace BethanysPieShopHRM.Server.Services
{
    public interface ICountryDataService
    {
        Task<IEnumerable<Country>> GetAllCountries();
        Task<Country> GetCountryById(int countryId);
    }
}
