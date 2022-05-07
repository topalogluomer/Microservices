﻿using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservationa.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO
            {
                Id = new Random().Next(100),
                Amount = new Random().Next(10000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(7),
                CheckoutDate = DateTime.Now.Date.AddDays(14),
                BkgNumber = bkgNumber
            };
        }
    }
}
