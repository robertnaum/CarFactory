using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarFactory.Common;

namespace Common.CarParts
{
    public class Engine : ICarPart
    {
        public EngineEnum EngineType { get; set; }
        public Engine(EngineEnum engineType)
        {
            EngineType = engineType;
        }
    }
}
