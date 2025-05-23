﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.


using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class HeatFluxTests : HeatFluxTestsBase
    {
        protected override double BtusPerHourSquareFootInOneWattPerSquareMeter => 3.16998331e-1;
        protected override double BtusPerMinuteSquareFootInOneWattPerSquareMeter => 5.28330551e-3;
        protected override double BtusPerSecondSquareFootInOneWattPerSquareMeter => 8.80550918e-5;
        protected override double BtusPerSecondSquareInchInOneWattPerSquareMeter => 6.11493693e-7;
        protected override double CaloriesPerSecondSquareCentimeterInOneWattPerSquareMeter => 2.390057361376673e-05;
        protected override double CentiwattsPerSquareMeterInOneWattPerSquareMeter => 1e2;
        protected override double DeciwattsPerSquareMeterInOneWattPerSquareMeter => 1e1;
        protected override double KilocaloriesPerSecondSquareCentimeterInOneWattPerSquareMeter => 2.390057361376673e-8;
        protected override double KilocaloriesPerHourSquareMeterInOneWattPerSquareMeter => 0.8604206500956023;
        protected override double KilowattsPerSquareMeterInOneWattPerSquareMeter => 1e-3;
        protected override double MicrowattsPerSquareMeterInOneWattPerSquareMeter => 1e6;
        protected override double MilliwattsPerSquareMeterInOneWattPerSquareMeter => 1e3;
        protected override double NanowattsPerSquareMeterInOneWattPerSquareMeter => 1e9;
        protected override double WattsPerSquareFootInOneWattPerSquareMeter => 9.290304e-2;
        protected override double WattsPerSquareInchInOneWattPerSquareMeter => 6.4516e-4;
        protected override double WattsPerSquareMeterInOneWattPerSquareMeter => 1;
        protected override double PoundsForcePerFootSecondInOneWattPerSquareMeter => 6.852176585679176e-2;
        protected override double PoundsPerSecondCubedInOneWattPerSquareMeter => 2.204622621848776;

        [Fact]
        public void PowerDividedByAreaEqualsHeatFlux()
        {
           HeatFlux heatFlux = Power.FromWatts(12) / Area.FromSquareMeters(3);
           Assert.Equal(heatFlux, HeatFlux.FromWattsPerSquareMeter(4));
        }

        [Fact]
        public void HeatFluxTimesAreaEqualsPower()
        {
            Power power = HeatFlux.FromWattsPerSquareMeter(3) * Area.FromSquareMeters(4);
            Assert.Equal(power, Power.FromWatts(12));
        }

        [Fact]
        public void PowerDividedByHeatFluxEqualsArea()
        {
            Area area = Power.FromWatts(12) / HeatFlux.FromWattsPerSquareMeter(3);
            Assert.Equal(area, Area.FromSquareMeters(4));
        }
    }
}
