using System;
using System.Threading.Tasks;
using CarFactory.Common;
using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void TestFordFocus()
        {
            FordAssemblyPlant fap = 
                new FordAssemblyPlant(new GeoCoordinate(22, 44));

          //  Car fordFocus = fap.CreateFocus();
          /*
            ModelSpecification ms;
            ms.Model = "Focus";
            ms.VIN = "293949030393";
            ms.MPGCity = 22;
            ms.MPGHwy = 29;
            ms.WeightLBS = 2900;
            */
            Task<FordFocus> fordFocus = fap.NewCarAsync<FordFocus>();
            
        }
    }
}
