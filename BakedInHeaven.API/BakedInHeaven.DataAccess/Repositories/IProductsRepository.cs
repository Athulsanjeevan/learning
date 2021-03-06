﻿using System.Collections.Generic;
using BakedInHeaven.DataAccess.Entities;

namespace BakedInHeaven.DataAccess.Repositories
{
    public interface IProductsRepository
    {
        List<Products> GetAllProducts();
        void Add(Products productEntity);
    }
       
}