//------------------------------------------------------------------------------
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

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     In photometry, luminous flux or luminous power is the measure of the perceived power of light.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Luminous_flux
    /// </remarks>
    public struct  LuminousFlux
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly LuminousFluxUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public LuminousFluxUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public LuminousFlux(double value, LuminousFluxUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of LuminousFlux, which is Second. All conversions go via this value.
        /// </summary>
        public static LuminousFluxUnit BaseUnit { get; } = LuminousFluxUnit.Lumen;

        /// <summary>
        /// Represents the largest possible value of LuminousFlux.
        /// </summary>
        public static LuminousFlux MaxValue { get; } = new LuminousFlux(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of LuminousFlux.
        /// </summary>
        public static LuminousFlux MinValue { get; } = new LuminousFlux(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static LuminousFlux Zero { get; } = new LuminousFlux(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="LuminousFluxUnit.Lumen"/>
        /// </summary>
        public double Lumens => As(LuminousFluxUnit.Lumen);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="LuminousFlux"/> from <see cref="LuminousFluxUnit.Lumen"/>.
        /// </summary>
        public static LuminousFlux FromLumens(double lumens) => new LuminousFlux(lumens, LuminousFluxUnit.Lumen);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="LuminousFluxUnit" /> to <see cref="LuminousFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>LuminousFlux unit value.</returns>
        public static LuminousFlux From(double value, LuminousFluxUnit fromUnit)
        {
            return new LuminousFlux(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(LuminousFluxUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this LuminousFlux to another LuminousFlux with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A LuminousFlux with the specified unit.</returns>
                public LuminousFlux ToUnit(LuminousFluxUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new LuminousFlux(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        LuminousFluxUnit.Lumen => _value,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(LuminousFluxUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        LuminousFluxUnit.Lumen => baseUnitValue,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

