using System.ComponentModel;

namespace CarFactory.Common
{
    public enum DrivenWheelsEnum
    {
        FWD,
        RWD,
        AWD,
        [Description("4WD")] FourWD
    }
}