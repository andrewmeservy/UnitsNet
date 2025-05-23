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
    ///     
    /// </summary>
    public struct  Jerk
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly JerkUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public JerkUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Jerk(double value, JerkUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Jerk, which is Second. All conversions go via this value.
        /// </summary>
        public static JerkUnit BaseUnit { get; } = JerkUnit.MeterPerSecondCubed;

        /// <summary>
        /// Represents the largest possible value of Jerk.
        /// </summary>
        public static Jerk MaxValue { get; } = new Jerk(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Jerk.
        /// </summary>
        public static Jerk MinValue { get; } = new Jerk(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Jerk Zero { get; } = new Jerk(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.CentimeterPerSecondCubed"/>
        /// </summary>
        public double CentimetersPerSecondCubed => As(JerkUnit.CentimeterPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.DecimeterPerSecondCubed"/>
        /// </summary>
        public double DecimetersPerSecondCubed => As(JerkUnit.DecimeterPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.FootPerSecondCubed"/>
        /// </summary>
        public double FeetPerSecondCubed => As(JerkUnit.FootPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.InchPerSecondCubed"/>
        /// </summary>
        public double InchesPerSecondCubed => As(JerkUnit.InchPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.KilometerPerSecondCubed"/>
        /// </summary>
        public double KilometersPerSecondCubed => As(JerkUnit.KilometerPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.MeterPerSecondCubed"/>
        /// </summary>
        public double MetersPerSecondCubed => As(JerkUnit.MeterPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.MicrometerPerSecondCubed"/>
        /// </summary>
        public double MicrometersPerSecondCubed => As(JerkUnit.MicrometerPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.MillimeterPerSecondCubed"/>
        /// </summary>
        public double MillimetersPerSecondCubed => As(JerkUnit.MillimeterPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.MillistandardGravitiesPerSecond"/>
        /// </summary>
        public double MillistandardGravitiesPerSecond => As(JerkUnit.MillistandardGravitiesPerSecond);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.NanometerPerSecondCubed"/>
        /// </summary>
        public double NanometersPerSecondCubed => As(JerkUnit.NanometerPerSecondCubed);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="JerkUnit.StandardGravitiesPerSecond"/>
        /// </summary>
        public double StandardGravitiesPerSecond => As(JerkUnit.StandardGravitiesPerSecond);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.CentimeterPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromCentimetersPerSecondCubed(double centimeterspersecondcubed) => new Jerk(centimeterspersecondcubed, JerkUnit.CentimeterPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.DecimeterPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromDecimetersPerSecondCubed(double decimeterspersecondcubed) => new Jerk(decimeterspersecondcubed, JerkUnit.DecimeterPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.FootPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromFeetPerSecondCubed(double feetpersecondcubed) => new Jerk(feetpersecondcubed, JerkUnit.FootPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.InchPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromInchesPerSecondCubed(double inchespersecondcubed) => new Jerk(inchespersecondcubed, JerkUnit.InchPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.KilometerPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromKilometersPerSecondCubed(double kilometerspersecondcubed) => new Jerk(kilometerspersecondcubed, JerkUnit.KilometerPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.MeterPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromMetersPerSecondCubed(double meterspersecondcubed) => new Jerk(meterspersecondcubed, JerkUnit.MeterPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.MicrometerPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromMicrometersPerSecondCubed(double micrometerspersecondcubed) => new Jerk(micrometerspersecondcubed, JerkUnit.MicrometerPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.MillimeterPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromMillimetersPerSecondCubed(double millimeterspersecondcubed) => new Jerk(millimeterspersecondcubed, JerkUnit.MillimeterPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.MillistandardGravitiesPerSecond"/>.
        /// </summary>
        public static Jerk FromMillistandardGravitiesPerSecond(double millistandardgravitiespersecond) => new Jerk(millistandardgravitiespersecond, JerkUnit.MillistandardGravitiesPerSecond);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.NanometerPerSecondCubed"/>.
        /// </summary>
        public static Jerk FromNanometersPerSecondCubed(double nanometerspersecondcubed) => new Jerk(nanometerspersecondcubed, JerkUnit.NanometerPerSecondCubed);

        /// <summary>
        ///     Creates a <see cref="Jerk"/> from <see cref="JerkUnit.StandardGravitiesPerSecond"/>.
        /// </summary>
        public static Jerk FromStandardGravitiesPerSecond(double standardgravitiespersecond) => new Jerk(standardgravitiespersecond, JerkUnit.StandardGravitiesPerSecond);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="JerkUnit" /> to <see cref="Jerk" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Jerk unit value.</returns>
        public static Jerk From(double value, JerkUnit fromUnit)
        {
            return new Jerk(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(JerkUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Jerk to another Jerk with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Jerk with the specified unit.</returns>
                public Jerk ToUnit(JerkUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Jerk(convertedValue, unit);
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
                        JerkUnit.CentimeterPerSecondCubed => (_value) * 1e-2d,
                        JerkUnit.DecimeterPerSecondCubed => (_value) * 1e-1d,
                        JerkUnit.FootPerSecondCubed => _value * 0.304800,
                        JerkUnit.InchPerSecondCubed => _value * 0.0254,
                        JerkUnit.KilometerPerSecondCubed => (_value) * 1e3d,
                        JerkUnit.MeterPerSecondCubed => _value,
                        JerkUnit.MicrometerPerSecondCubed => (_value) * 1e-6d,
                        JerkUnit.MillimeterPerSecondCubed => (_value) * 1e-3d,
                        JerkUnit.MillistandardGravitiesPerSecond => (_value * 9.80665) * 1e-3d,
                        JerkUnit.NanometerPerSecondCubed => (_value) * 1e-9d,
                        JerkUnit.StandardGravitiesPerSecond => _value * 9.80665,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(JerkUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        JerkUnit.CentimeterPerSecondCubed => (baseUnitValue) / 1e-2d,
                        JerkUnit.DecimeterPerSecondCubed => (baseUnitValue) / 1e-1d,
                        JerkUnit.FootPerSecondCubed => baseUnitValue / 0.304800,
                        JerkUnit.InchPerSecondCubed => baseUnitValue / 0.0254,
                        JerkUnit.KilometerPerSecondCubed => (baseUnitValue) / 1e3d,
                        JerkUnit.MeterPerSecondCubed => baseUnitValue,
                        JerkUnit.MicrometerPerSecondCubed => (baseUnitValue) / 1e-6d,
                        JerkUnit.MillimeterPerSecondCubed => (baseUnitValue) / 1e-3d,
                        JerkUnit.MillistandardGravitiesPerSecond => (baseUnitValue / 9.80665) / 1e-3d,
                        JerkUnit.NanometerPerSecondCubed => (baseUnitValue) / 1e-9d,
                        JerkUnit.StandardGravitiesPerSecond => baseUnitValue / 9.80665,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

