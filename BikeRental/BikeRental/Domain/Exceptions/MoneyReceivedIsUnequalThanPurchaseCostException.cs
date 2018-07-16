﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Domain.Exceptions
{
    public class MoneyReceivedIsUnequalThanPurchaseCostException : Exception
    {
        public MoneyReceivedIsUnequalThanPurchaseCostException(string message) : base(message)
        {
        }

    }
}
