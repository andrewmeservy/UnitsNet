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
    ///     Electric charge is the physical property of matter that causes it to experience a force when placed in an electromagnetic field.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Electric_charge
    /// </remarks>
    public struct  ElectricCharge
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ElectricChargeUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ElectricChargeUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public ElectricCharge(double value, ElectricChargeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of ElectricCharge, which is Second. All conversions go via this value.
        /// </summary>
        public static ElectricChargeUnit BaseUnit { get; } = ElectricChargeUnit.Coulomb;

        /// <summary>
        /// Represents the largest possible value of ElectricCharge.
        /// </summary>
        public static ElectricCharge MaxValue { get; } = new ElectricCharge(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of ElectricCharge.
        /// </summary>
        public static ElectricCharge MinValue { get; } = new ElectricCharge(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ElectricCharge Zero { get; } = new ElectricCharge(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.AmpereHour"/>
        /// </summary>
        public double AmpereHours => As(ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Coulomb"/>
        /// </summary>
        public double Coulombs => As(ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.KiloampereHour"/>
        /// </summary>
        public double KiloampereHours => As(ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Kilocoulomb"/>
        /// </summary>
        public double Kilocoulombs => As(ElectricChargeUnit.Kilocoulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MegaampereHour"/>
        /// </summary>
        public double MegaampereHours => As(ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Megacoulomb"/>
        /// </summary>
        public double Megacoulombs => As(ElectricChargeUnit.Megacoulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Microcoulomb"/>
        /// </summary>
        public double Microcoulombs => As(ElectricChargeUnit.Microcoulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.MilliampereHour"/>
        /// </summary>
        public double MilliampereHours => As(ElectricChargeUnit.MilliampereHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Millicoulomb"/>
        /// </summary>
        public double Millicoulombs => As(ElectricChargeUnit.Millicoulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Nanocoulomb"/>
        /// </summary>
        public double Nanocoulombs => As(ElectricChargeUnit.Nanocoulomb);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="ElectricChargeUnit.Picocoulomb"/>
        /// </summary>
        public double Picocoulombs => As(ElectricChargeUnit.Picocoulomb);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.AmpereHour"/>.
        /// </summary>
        public static ElectricCharge FromAmpereHours(double amperehours) => new ElectricCharge(amperehours, ElectricChargeUnit.AmpereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Coulomb"/>.
        /// </summary>
        public static ElectricCharge FromCoulombs(double coulombs) => new ElectricCharge(coulombs, ElectricChargeUnit.Coulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.KiloampereHour"/>.
        /// </summary>
        public static ElectricCharge FromKiloampereHours(double kiloamperehours) => new ElectricCharge(kiloamperehours, ElectricChargeUnit.KiloampereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Kilocoulomb"/>.
        /// </summary>
        public static ElectricCharge FromKilocoulombs(double kilocoulombs) => new ElectricCharge(kilocoulombs, ElectricChargeUnit.Kilocoulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MegaampereHour"/>.
        /// </summary>
        public static ElectricCharge FromMegaampereHours(double megaamperehours) => new ElectricCharge(megaamperehours, ElectricChargeUnit.MegaampereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Megacoulomb"/>.
        /// </summary>
        public static ElectricCharge FromMegacoulombs(double megacoulombs) => new ElectricCharge(megacoulombs, ElectricChargeUnit.Megacoulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Microcoulomb"/>.
        /// </summary>
        public static ElectricCharge FromMicrocoulombs(double microcoulombs) => new ElectricCharge(microcoulombs, ElectricChargeUnit.Microcoulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.MilliampereHour"/>.
        /// </summary>
        public static ElectricCharge FromMilliampereHours(double milliamperehours) => new ElectricCharge(milliamperehours, ElectricChargeUnit.MilliampereHour);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Millicoulomb"/>.
        /// </summary>
        public static ElectricCharge FromMillicoulombs(double millicoulombs) => new ElectricCharge(millicoulombs, ElectricChargeUnit.Millicoulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Nanocoulomb"/>.
        /// </summary>
        public static ElectricCharge FromNanocoulombs(double nanocoulombs) => new ElectricCharge(nanocoulombs, ElectricChargeUnit.Nanocoulomb);

        /// <summary>
        ///     Creates a <see cref="ElectricCharge"/> from <see cref="ElectricChargeUnit.Picocoulomb"/>.
        /// </summary>
        public static ElectricCharge FromPicocoulombs(double picocoulombs) => new ElectricCharge(picocoulombs, ElectricChargeUnit.Picocoulomb);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ElectricChargeUnit" /> to <see cref="ElectricCharge" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ElectricCharge unit value.</returns>
        public static ElectricCharge From(double value, ElectricChargeUnit fromUnit)
        {
            return new ElectricCharge(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(ElectricChargeUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this ElectricCharge to another ElectricCharge with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A ElectricCharge with the specified unit.</returns>
                public ElectricCharge ToUnit(ElectricChargeUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new ElectricCharge(convertedValue, unit);
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
                        ElectricChargeUnit.AmpereHour => _value * 3600,
                        ElectricChargeUnit.Coulomb => _value,
                        ElectricChargeUnit.KiloampereHour => (_value * 3600) * 1e3d,
                        ElectricChargeUnit.Kilocoulomb => (_value) * 1e3d,
                        ElectricChargeUnit.MegaampereHour => (_value * 3600) * 1e6d,
                        ElectricChargeUnit.Megacoulomb => (_value) * 1e6d,
                        ElectricChargeUnit.Microcoulomb => (_value) * 1e-6d,
                        ElectricChargeUnit.MilliampereHour => (_value * 3600) * 1e-3d,
                        ElectricChargeUnit.Millicoulomb => (_value) * 1e-3d,
                        ElectricChargeUnit.Nanocoulomb => (_value) * 1e-9d,
                        ElectricChargeUnit.Picocoulomb => (_value) * 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(ElectricChargeUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        ElectricChargeUnit.AmpereHour => baseUnitValue / 3600,
                        ElectricChargeUnit.Coulomb => baseUnitValue,
                        ElectricChargeUnit.KiloampereHour => (baseUnitValue / 3600) / 1e3d,
                        ElectricChargeUnit.Kilocoulomb => (baseUnitValue) / 1e3d,
                        ElectricChargeUnit.MegaampereHour => (baseUnitValue / 3600) / 1e6d,
                        ElectricChargeUnit.Megacoulomb => (baseUnitValue) / 1e6d,
                        ElectricChargeUnit.Microcoulomb => (baseUnitValue) / 1e-6d,
                        ElectricChargeUnit.MilliampereHour => (baseUnitValue / 3600) / 1e-3d,
                        ElectricChargeUnit.Millicoulomb => (baseUnitValue) / 1e-3d,
                        ElectricChargeUnit.Nanocoulomb => (baseUnitValue) / 1e-9d,
                        ElectricChargeUnit.Picocoulomb => (baseUnitValue) / 1e-12d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

