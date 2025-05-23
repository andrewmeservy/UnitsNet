﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MolarFlowTests : MolarFlowTestsBase
    {
        protected override double KilomolesPerHourInOneMolePerSecond => 3.6;

        protected override double KilomolesPerMinuteInOneMolePerSecond => 0.06;

        protected override double KilomolesPerSecondInOneMolePerSecond => 0.001;

        protected override double PoundMolesPerHourInOneMolePerSecond => 7.93664143866;

        protected override double PoundMolesPerMinuteInOneMolePerSecond => 0.132277357311;

        protected override double PoundMolesPerSecondInOneMolePerSecond => 2.2046226218488e-3;

        protected override double MolesPerHourInOneMolePerSecond => 3600;

        protected override double MolesPerMinuteInOneMolePerSecond => 60;

        protected override double MolesPerSecondInOneMolePerSecond => 1.0;

        [Fact]
        public void MolarFlowTimesTimeSpanEqualsAmountOfSubstance()
        {
            AmountOfSubstance amount = MolarFlow.FromMolesPerSecond(20) * TimeSpan.FromSeconds(2);
            Assert.Equal(AmountOfSubstance.FromMoles(40), amount);
        }

        [Fact]
        public void MolarFlowTimesDurationEqualsAmountOfSubstance()
        {
            AmountOfSubstance amount = MolarFlow.FromMolesPerSecond(20) * Duration.FromSeconds(2);
            Assert.Equal(AmountOfSubstance.FromMoles(40), amount);
        }

        [Fact]
        public void MolarFlowTimesMolarMassEqualsMassFlow()
        {
            MassFlow massFlow = MolarFlow.FromMolesPerSecond(2) * MolarMass.FromKilogramsPerMole(3);
            Assert.Equal(MassFlow.FromKilogramsPerSecond(6), massFlow);
        }

        [Fact]
        public void MolarFlowOverMolarityEqualsVolumeFlow()
        {
            VolumeFlow volumeFlow = MolarFlow.FromMolesPerSecond(6) / Molarity.FromMolesPerCubicMeter(3);
            Assert.Equal(VolumeFlow.FromCubicMetersPerSecond(2), volumeFlow);
        }

    }
}
