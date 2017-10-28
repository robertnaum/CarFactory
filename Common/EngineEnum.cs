using System.ComponentModel;

namespace CarFactory.Common
{
    public enum EngineEnum
    {
        [Description("4-Cylinder")] FourCylinder = 1,
        [Description("6-Cylinder")] SixCylinder = 2,
        [Description("8-Cylinder")] EightCylinder = 3
    }
}