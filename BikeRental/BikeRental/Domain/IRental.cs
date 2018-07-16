﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeRental.Domain
{
    public interface IRental : ISale
    {        
        RentalEmission Emission { get; }
        Bike Bike { get; }
        RentalModality Modality { get; }              
        RentalFinalization Finalization { get; set; }
        bool IsFinished();

    }
}
