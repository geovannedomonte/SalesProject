﻿using SalesProject.Models;
using SalesProject.Models.Enums;

namespace SalesProject.Data
{
    public class SeedingService
    {
        private SalesProjectContext _context;

        public SeedingService(SalesProjectContext context)
        {
            _context = context;
        }
        public void Seed() 
        {
            if (_context.Department.Any() ||
                    _context.Seller.Any() ||
                    _context.SalesRecord.Any())

            {
                return; // Test DB has been seeded
            }

            Department d1 = new Department(1, "Computers");
            Department d2 = new Department(2, "Electronics");
            Department d3 = new Department(3, "Fashion");
            Department d4 = new Department(4, "Books");

            Seller s1 = new Seller(1, "W Lenin", "wlenin@urss.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s2 = new Seller(2, "K Marx", "kmarx@manifesto.com", new DateTime(1998, 4, 21), 1000.0, d2);
            Seller s3 = new Seller(3, "C Marighela", "cmariga@luta.com", new DateTime(1998, 4, 21), 1000.0, d1);
            Seller s4 = new Seller(4, "L C Prestes", "lcprestes@pcb.com", new DateTime(1998, 4, 21), 1000.0, d4);
            Seller s5 = new Seller(5, "Rosa Luxemburgo", "rosaluxemburgo@urss.com", new DateTime(1998, 4, 21), 1000.0, d3);
            Seller s6 = new Seller(6, "Olga Benario", "obenario@revolucao.com", new DateTime(1998, 4, 21), 1000.0, d2);

            SallesRecord r1 = new SallesRecord(1, new DateTime(2022, 08, 25), 11000.0, SaleStatus.Billed, s1);
            SallesRecord r2 = new SallesRecord(2, new DateTime(2022, 08, 26), 7000.0, SaleStatus.Canceled, s2);
            SallesRecord r3 = new SallesRecord(3, new DateTime(2022, 08, 27), 1000.0, SaleStatus.Pending, s3);
            SallesRecord r4 = new SallesRecord(4, new DateTime(2022, 08, 28), 8000.0, SaleStatus.Billed, s4);
            SallesRecord r5 = new SallesRecord(5, new DateTime(2022, 08, 29), 31000.0, SaleStatus.Canceled, s5);
            SallesRecord r6 = new SallesRecord(6, new DateTime(2022, 08, 15), 2000.0, SaleStatus.Pending, s6);
            SallesRecord r7 = new SallesRecord(7, new DateTime(2022, 08, 15), 12000.0, SaleStatus.Billed, s2);
            SallesRecord r8 = new SallesRecord(8, new DateTime(2022, 08, 16), 21000.0, SaleStatus.Billed, s4);
            SallesRecord r9 = new SallesRecord(9, new DateTime(2022, 08, 17), 5000.0, SaleStatus.Pending, s3);
            SallesRecord r10 = new SallesRecord(10, new DateTime(2022, 08, 18), 6000.0, SaleStatus.Billed, s5);
            SallesRecord r11 = new SallesRecord(11, new DateTime(2022, 08, 19), 7000.0, SaleStatus.Billed, s1);
            SallesRecord r12 = new SallesRecord(12, new DateTime(2022, 08, 20), 8000.0, SaleStatus.Pending, s6);
            SallesRecord r13 = new SallesRecord(13, new DateTime(2022, 08, 21), 9000.0, SaleStatus.Billed, s5);
            SallesRecord r14 = new SallesRecord(14, new DateTime(2022, 08, 21), 10000.0, SaleStatus.Canceled, s4);
            SallesRecord r15 = new SallesRecord(15, new DateTime(2022, 08, 22), 11000.0, SaleStatus.Billed, s3);
            SallesRecord r16 = new SallesRecord(16, new DateTime(2022, 08, 23), 12000.0, SaleStatus.Canceled, s2);
            SallesRecord r17 = new SallesRecord(17, new DateTime(2022, 08, 22), 12000.0, SaleStatus.Billed, s1);
            SallesRecord r18 = new SallesRecord(18, new DateTime(2022, 08, 23), 13000.0, SaleStatus.Billed, s1);
            SallesRecord r19 = new SallesRecord(19, new DateTime(2022, 08, 24), 14000.0, SaleStatus.Billed, s2);
            SallesRecord r20 = new SallesRecord(20, new DateTime(2022, 08, 25), 13000.0, SaleStatus.Billed, s2);
            SallesRecord r21 = new SallesRecord(21, new DateTime(2022, 08, 02), 15000.0, SaleStatus.Billed, s3);
            SallesRecord r22 = new SallesRecord(22, new DateTime(2022, 08, 03), 15000.0, SaleStatus.Billed, s4);
            SallesRecord r23 = new SallesRecord(23, new DateTime(2022, 08, 04), 17000.0, SaleStatus.Billed, s4);
            SallesRecord r24 = new SallesRecord(24, new DateTime(2022, 08, 04), 19000.0, SaleStatus.Billed, s5);
            SallesRecord r25 = new SallesRecord(25, new DateTime(2022, 08, 06), 11000.0, SaleStatus.Billed, s6);
            SallesRecord r26 = new SallesRecord(26, new DateTime(2022, 08, 09), 10000.0, SaleStatus.Canceled, s6);
            SallesRecord r27 = new SallesRecord(27, new DateTime(2022, 08, 07), 15000.0, SaleStatus.Billed, s5);
            SallesRecord r28 = new SallesRecord(28, new DateTime(2022, 08, 10), 17000.0, SaleStatus.Billed, s4);
            SallesRecord r29 = new SallesRecord(29, new DateTime(2022, 08, 11), 16000.0, SaleStatus.Billed, s5);
            SallesRecord r30 = new SallesRecord(30, new DateTime(2022, 08, 12), 21000.0, SaleStatus.Pending, s2);

            _context.Department.AddRange(d1, d2, d3, d4);
            _context.Seller.AddRange(s1, s2, s3, s4, s5, s6);
            _context.SalesRecord.AddRange(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24, r25, r26, r27, r28, r29, r30);
            _context.SaveChanges();
        }
    }
}
