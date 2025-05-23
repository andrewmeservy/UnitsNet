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
    ///     The area density of a two-dimensional object is calculated as the mass per unit area. For paper this is also called grammage.
    /// </summary>
    public struct  AreaDensity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AreaDensityUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public AreaDensityUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public AreaDensity(double value, AreaDensityUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of AreaDensity, which is Second. All conversions go via this value.
        /// </summary>
        public static AreaDensityUnit BaseUnit { get; } = AreaDensityUnit.KilogramPerSquareMeter;

        /// <summary>
        /// Represents the largest possible value of AreaDensity.
        /// </summary>
        public static AreaDensity MaxValue { get; } = new AreaDensity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of AreaDensity.
        /// </summary>
        public static AreaDensity MinValue { get; } = new AreaDensity(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static AreaDensity Zero { get; } = new AreaDensity(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AreaDensityUnit.GramPerSquareMeter"/>
        /// </summary>
        public double GramsPerSquareMeter => As(AreaDensityUnit.GramPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AreaDensityUnit.KilogramPerSquareMeter"/>
        /// </summary>
        public double KilogramsPerSquareMeter => As(AreaDensityUnit.KilogramPerSquareMeter);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="AreaDensityUnit.MilligramPerSquareMeter"/>
        /// </summary>
        public double MilligramsPerSquareMeter => As(AreaDensityUnit.MilligramPerSquareMeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="AreaDensity"/> from <see cref="AreaDensityUnit.GramPerSquareMeter"/>.
        /// </summary>
        public static AreaDensity FromGramsPerSquareMeter(double gramspersquaremeter) => new AreaDensity(gramspersquaremeter, AreaDensityUnit.GramPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="AreaDensity"/> from <see cref="AreaDensityUnit.KilogramPerSquareMeter"/>.
        /// </summary>
        public static AreaDensity FromKilogramsPerSquareMeter(double kilogramspersquaremeter) => new AreaDensity(kilogramspersquaremeter, AreaDensityUnit.KilogramPerSquareMeter);

        /// <summary>
        ///     Creates a <see cref="AreaDensity"/> from <see cref="AreaDensityUnit.MilligramPerSquareMeter"/>.
        /// </summary>
        public static AreaDensity FromMilligramsPerSquareMeter(double milligramspersquaremeter) => new AreaDensity(milligramspersquaremeter, AreaDensityUnit.MilligramPerSquareMeter);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AreaDensityUnit" /> to <see cref="AreaDensity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>AreaDensity unit value.</returns>
        public static AreaDensity From(double value, AreaDensityUnit fromUnit)
        {
            return new AreaDensity(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(AreaDensityUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this AreaDensity to another AreaDensity with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A AreaDensity with the specified unit.</returns>
                public AreaDensity ToUnit(AreaDensityUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new AreaDensity(convertedValue, unit);
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
                        AreaDensityUnit.GramPerSquareMeter => _value / 1000,
                        AreaDensityUnit.KilogramPerSquareMeter => _value,
                        AreaDensityUnit.MilligramPerSquareMeter => _value / 1000000,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(AreaDensityUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        AreaDensityUnit.GramPerSquareMeter => baseUnitValue * 1000,
                        AreaDensityUnit.KilogramPerSquareMeter => baseUnitValue,
                        AreaDensityUnit.MilligramPerSquareMeter => baseUnitValue * 1000000,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

