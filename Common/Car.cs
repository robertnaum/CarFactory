using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.Common
{
    public abstract class Car
    {
        public string Make {get; set; }
        public string Model {get; set; }
        public int Year { get; set; } = DateTime.Now.Year;
        public string VIN { get; set; }
        public int Mileage { get; set; } = 0;
        public int MPGCity { get; set; }
        public int MPGHwy { get; set; }
        public int MaxGrossWeight { get; set; }
        public EngineEnum Engine { get; set; }
        public TransmissionEnum Transmission { get; set; }
        public DrivenWheelsEnum DrivenWheels { get; set; }
    }
}
