﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ArgicultureInventorySystem.Models;

namespace ArgicultureInventorySystem.ViewModel
{
    public class UcBookingStockViewModel
    {
        //public UniversityCommunity UniversityCommunity { get; set; }

        public IList<Stock> Stocks { get; set; }

        public IEnumerable<Booking> Bookings { get; set; }

        public virtual BookingDate BookingDate { get; set; }

        // Get Booking by BookingDate
        public IEnumerable<BookingDate> BookingDates { get; set; }

        public ApplicationUser ApplicationUser { get; set; }

        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
    }
}