using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.CarParts;

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
        public EngineEnum EngineType => Engine.EngineType;
        public TransmissionEnum TransmissionType => Transmission.TransmissionType;
        public DrivenWheelsEnum DrivenWheels { get; set; }

        //car will have 1 or more of each of these
        /*
            1 Car Body
            1 Engine
            4 Brakes
            4 Tires
            2 Front Seats
            1 Rear Seat Group
            1 Front Console
            1 Transmission
            1 Front Windshield
            1 Rear Windshield
            2 Front Headlights
            2 Rear Headlights
            2 Side Mirrors
            2 or 4 Doors
         */
        public CarBody CarBody { get; set; }
        public Engine Engine { get; set; }
        public Brake[] Brakes = new Brake[4]; 
        public Tire[] Tires = new Tire[4];
        public FrontSeat[] FrontSeats = new FrontSeat[2];
        public RearSeatGroup RearSeatGroup { get; set; }
        public FrontConsole FrontConsole { get; set; }
        public Transmission Transmission { get; set; }
        public FrontWindshield FrontWindshield { get; set; }
        public RearWindshield RearWindshield { get; set; }
        public FrontHeadlight[] FrontHeadlights = new FrontHeadlight[2];
        public RearHeadlight[] RearHeadlights = new RearHeadlight[2];
        public SideMirror[] SideMirrors = new SideMirror[2];
        public IEnumerable<CarDoor> CarDoors;
    }
}
