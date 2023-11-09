﻿using SalesProject.Data;
using SalesProject.Models;

namespace SalesProject.Services
{
    public class SellerService
    {

        private readonly SalesProjectContext _context;

        public SellerService(SalesProjectContext context) 
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
    }
}
