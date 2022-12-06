using System;
using System.Collections.Generic;

namespace Garage
{
    public class GasStation : Station<IGasVehicle>, IStation<IGasVehicle>
    {
        public int Capacity { get; set; }
    }
}