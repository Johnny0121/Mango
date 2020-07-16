﻿using Mango.WEB.Entities.Stock;
using Mango.WEB.Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mango.WEB.Interfaces.Repositories.Stock
{
    public interface IStockRepository
    {
        Task<StockEntity> CreateAsync(StockEntity stock);
        Task<bool> DeleteAsync(Guid stockUID);
        Task<IList<StockEntity>> GetAsync(StockType filter = StockType.Unknown);
        Task<StockEntity> GetAsync(Guid stockUID);
        Task<bool> UpdateAsync(Guid stockUID, StockEntity updatedStock);
    }
}