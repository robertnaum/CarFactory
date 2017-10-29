using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Common;

namespace Common.CarParts
{
    public class Transmission : ICarPart
    {
        public TransmissionEnum TransmissionType { get; set; }
        public Transmission(TransmissionEnum transmissionType)
        {
            TransmissionType = transmissionType;
        }
    }
}
