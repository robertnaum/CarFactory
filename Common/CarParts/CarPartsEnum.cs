using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.CarParts
{
    public enum CarPartsEnum
    {
        [Description("Car Body")] CarBody,
        [Description("Engine")] Engine,
        [Description("Brake")] Brake,
        [Description("Tire")] Tire,
        [Description("Front Seat")] FrontSeat,
        [Description("Rear Seat Group")] RearSeatGroup,
        [Description("Front Console")] FrontConsole,
        [Description("Transmission")] Transmission,
        [Description("Front Windshield")] FrontWindshield,
        [Description("Rear Windshield")] RearWindshield,
        [Description("Front Headlight")] FrontHeadlight,
        [Description("Rear Headlight")] RearHeadlight,
        [Description("Side Mirror")] SideMirror,
        [Description("Car Door")] CarDoor
    }
}
