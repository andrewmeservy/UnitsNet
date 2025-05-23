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
    ///     The joule, symbol J, is a derived unit of energy, work, or amount of heat in the International System of Units. It is equal to the energy transferred (or work done) when applying a force of one newton through a distance of one metre (1 newton metre or N·m), or in passing an electric current of one ampere through a resistance of one ohm for one second. Many other units of energy are included. Please do not confuse this definition of the calorie with the one colloquially used by the food industry, the large calorie, which is equivalent to 1 kcal. Thermochemical definition of the calorie is used. For BTU, the IT definition is used.
    /// </summary>
    public struct  Energy
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly EnergyUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public EnergyUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        public Energy(double value, EnergyUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Energy, which is Second. All conversions go via this value.
        /// </summary>
        public static EnergyUnit BaseUnit { get; } = EnergyUnit.Joule;

        /// <summary>
        /// Represents the largest possible value of Energy.
        /// </summary>
        public static Energy MaxValue { get; } = new Energy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Energy.
        /// </summary>
        public static Energy MinValue { get; } = new Energy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Energy Zero { get; } = new Energy(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.BritishThermalUnit"/>
        /// </summary>
        public double BritishThermalUnits => As(EnergyUnit.BritishThermalUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Calorie"/>
        /// </summary>
        public double Calories => As(EnergyUnit.Calorie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.DecathermEc"/>
        /// </summary>
        public double DecathermsEc => As(EnergyUnit.DecathermEc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.DecathermImperial"/>
        /// </summary>
        public double DecathermsImperial => As(EnergyUnit.DecathermImperial);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.DecathermUs"/>
        /// </summary>
        public double DecathermsUs => As(EnergyUnit.DecathermUs);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.ElectronVolt"/>
        /// </summary>
        public double ElectronVolts => As(EnergyUnit.ElectronVolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Erg"/>
        /// </summary>
        public double Ergs => As(EnergyUnit.Erg);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.FootPound"/>
        /// </summary>
        public double FootPounds => As(EnergyUnit.FootPound);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.GigabritishThermalUnit"/>
        /// </summary>
        public double GigabritishThermalUnits => As(EnergyUnit.GigabritishThermalUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.GigaelectronVolt"/>
        /// </summary>
        public double GigaelectronVolts => As(EnergyUnit.GigaelectronVolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Gigajoule"/>
        /// </summary>
        public double Gigajoules => As(EnergyUnit.Gigajoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.GigawattDay"/>
        /// </summary>
        public double GigawattDays => As(EnergyUnit.GigawattDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.GigawattHour"/>
        /// </summary>
        public double GigawattHours => As(EnergyUnit.GigawattHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.HorsepowerHour"/>
        /// </summary>
        public double HorsepowerHours => As(EnergyUnit.HorsepowerHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Joule"/>
        /// </summary>
        public double Joules => As(EnergyUnit.Joule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.KilobritishThermalUnit"/>
        /// </summary>
        public double KilobritishThermalUnits => As(EnergyUnit.KilobritishThermalUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Kilocalorie"/>
        /// </summary>
        public double Kilocalories => As(EnergyUnit.Kilocalorie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.KiloelectronVolt"/>
        /// </summary>
        public double KiloelectronVolts => As(EnergyUnit.KiloelectronVolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Kilojoule"/>
        /// </summary>
        public double Kilojoules => As(EnergyUnit.Kilojoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.KilowattDay"/>
        /// </summary>
        public double KilowattDays => As(EnergyUnit.KilowattDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.KilowattHour"/>
        /// </summary>
        public double KilowattHours => As(EnergyUnit.KilowattHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.MegabritishThermalUnit"/>
        /// </summary>
        public double MegabritishThermalUnits => As(EnergyUnit.MegabritishThermalUnit);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Megacalorie"/>
        /// </summary>
        public double Megacalories => As(EnergyUnit.Megacalorie);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.MegaelectronVolt"/>
        /// </summary>
        public double MegaelectronVolts => As(EnergyUnit.MegaelectronVolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Megajoule"/>
        /// </summary>
        public double Megajoules => As(EnergyUnit.Megajoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.MegawattDay"/>
        /// </summary>
        public double MegawattDays => As(EnergyUnit.MegawattDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.MegawattHour"/>
        /// </summary>
        public double MegawattHours => As(EnergyUnit.MegawattHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Microjoule"/>
        /// </summary>
        public double Microjoules => As(EnergyUnit.Microjoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Millijoule"/>
        /// </summary>
        public double Millijoules => As(EnergyUnit.Millijoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Nanojoule"/>
        /// </summary>
        public double Nanojoules => As(EnergyUnit.Nanojoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Petajoule"/>
        /// </summary>
        public double Petajoules => As(EnergyUnit.Petajoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.TeraelectronVolt"/>
        /// </summary>
        public double TeraelectronVolts => As(EnergyUnit.TeraelectronVolt);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.Terajoule"/>
        /// </summary>
        public double Terajoules => As(EnergyUnit.Terajoule);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.TerawattDay"/>
        /// </summary>
        public double TerawattDays => As(EnergyUnit.TerawattDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.TerawattHour"/>
        /// </summary>
        public double TerawattHours => As(EnergyUnit.TerawattHour);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.ThermEc"/>
        /// </summary>
        public double ThermsEc => As(EnergyUnit.ThermEc);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.ThermImperial"/>
        /// </summary>
        public double ThermsImperial => As(EnergyUnit.ThermImperial);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.ThermUs"/>
        /// </summary>
        public double ThermsUs => As(EnergyUnit.ThermUs);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.WattDay"/>
        /// </summary>
        public double WattDays => As(EnergyUnit.WattDay);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="EnergyUnit.WattHour"/>
        /// </summary>
        public double WattHours => As(EnergyUnit.WattHour);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.BritishThermalUnit"/>.
        /// </summary>
        public static Energy FromBritishThermalUnits(double britishthermalunits) => new Energy(britishthermalunits, EnergyUnit.BritishThermalUnit);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Calorie"/>.
        /// </summary>
        public static Energy FromCalories(double calories) => new Energy(calories, EnergyUnit.Calorie);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.DecathermEc"/>.
        /// </summary>
        public static Energy FromDecathermsEc(double decathermsec) => new Energy(decathermsec, EnergyUnit.DecathermEc);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.DecathermImperial"/>.
        /// </summary>
        public static Energy FromDecathermsImperial(double decathermsimperial) => new Energy(decathermsimperial, EnergyUnit.DecathermImperial);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.DecathermUs"/>.
        /// </summary>
        public static Energy FromDecathermsUs(double decathermsus) => new Energy(decathermsus, EnergyUnit.DecathermUs);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.ElectronVolt"/>.
        /// </summary>
        public static Energy FromElectronVolts(double electronvolts) => new Energy(electronvolts, EnergyUnit.ElectronVolt);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Erg"/>.
        /// </summary>
        public static Energy FromErgs(double ergs) => new Energy(ergs, EnergyUnit.Erg);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.FootPound"/>.
        /// </summary>
        public static Energy FromFootPounds(double footpounds) => new Energy(footpounds, EnergyUnit.FootPound);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.GigabritishThermalUnit"/>.
        /// </summary>
        public static Energy FromGigabritishThermalUnits(double gigabritishthermalunits) => new Energy(gigabritishthermalunits, EnergyUnit.GigabritishThermalUnit);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.GigaelectronVolt"/>.
        /// </summary>
        public static Energy FromGigaelectronVolts(double gigaelectronvolts) => new Energy(gigaelectronvolts, EnergyUnit.GigaelectronVolt);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Gigajoule"/>.
        /// </summary>
        public static Energy FromGigajoules(double gigajoules) => new Energy(gigajoules, EnergyUnit.Gigajoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.GigawattDay"/>.
        /// </summary>
        public static Energy FromGigawattDays(double gigawattdays) => new Energy(gigawattdays, EnergyUnit.GigawattDay);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.GigawattHour"/>.
        /// </summary>
        public static Energy FromGigawattHours(double gigawatthours) => new Energy(gigawatthours, EnergyUnit.GigawattHour);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.HorsepowerHour"/>.
        /// </summary>
        public static Energy FromHorsepowerHours(double horsepowerhours) => new Energy(horsepowerhours, EnergyUnit.HorsepowerHour);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Joule"/>.
        /// </summary>
        public static Energy FromJoules(double joules) => new Energy(joules, EnergyUnit.Joule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.KilobritishThermalUnit"/>.
        /// </summary>
        public static Energy FromKilobritishThermalUnits(double kilobritishthermalunits) => new Energy(kilobritishthermalunits, EnergyUnit.KilobritishThermalUnit);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Kilocalorie"/>.
        /// </summary>
        public static Energy FromKilocalories(double kilocalories) => new Energy(kilocalories, EnergyUnit.Kilocalorie);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.KiloelectronVolt"/>.
        /// </summary>
        public static Energy FromKiloelectronVolts(double kiloelectronvolts) => new Energy(kiloelectronvolts, EnergyUnit.KiloelectronVolt);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Kilojoule"/>.
        /// </summary>
        public static Energy FromKilojoules(double kilojoules) => new Energy(kilojoules, EnergyUnit.Kilojoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.KilowattDay"/>.
        /// </summary>
        public static Energy FromKilowattDays(double kilowattdays) => new Energy(kilowattdays, EnergyUnit.KilowattDay);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.KilowattHour"/>.
        /// </summary>
        public static Energy FromKilowattHours(double kilowatthours) => new Energy(kilowatthours, EnergyUnit.KilowattHour);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.MegabritishThermalUnit"/>.
        /// </summary>
        public static Energy FromMegabritishThermalUnits(double megabritishthermalunits) => new Energy(megabritishthermalunits, EnergyUnit.MegabritishThermalUnit);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Megacalorie"/>.
        /// </summary>
        public static Energy FromMegacalories(double megacalories) => new Energy(megacalories, EnergyUnit.Megacalorie);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.MegaelectronVolt"/>.
        /// </summary>
        public static Energy FromMegaelectronVolts(double megaelectronvolts) => new Energy(megaelectronvolts, EnergyUnit.MegaelectronVolt);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Megajoule"/>.
        /// </summary>
        public static Energy FromMegajoules(double megajoules) => new Energy(megajoules, EnergyUnit.Megajoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.MegawattDay"/>.
        /// </summary>
        public static Energy FromMegawattDays(double megawattdays) => new Energy(megawattdays, EnergyUnit.MegawattDay);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.MegawattHour"/>.
        /// </summary>
        public static Energy FromMegawattHours(double megawatthours) => new Energy(megawatthours, EnergyUnit.MegawattHour);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Microjoule"/>.
        /// </summary>
        public static Energy FromMicrojoules(double microjoules) => new Energy(microjoules, EnergyUnit.Microjoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Millijoule"/>.
        /// </summary>
        public static Energy FromMillijoules(double millijoules) => new Energy(millijoules, EnergyUnit.Millijoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Nanojoule"/>.
        /// </summary>
        public static Energy FromNanojoules(double nanojoules) => new Energy(nanojoules, EnergyUnit.Nanojoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Petajoule"/>.
        /// </summary>
        public static Energy FromPetajoules(double petajoules) => new Energy(petajoules, EnergyUnit.Petajoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.TeraelectronVolt"/>.
        /// </summary>
        public static Energy FromTeraelectronVolts(double teraelectronvolts) => new Energy(teraelectronvolts, EnergyUnit.TeraelectronVolt);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.Terajoule"/>.
        /// </summary>
        public static Energy FromTerajoules(double terajoules) => new Energy(terajoules, EnergyUnit.Terajoule);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.TerawattDay"/>.
        /// </summary>
        public static Energy FromTerawattDays(double terawattdays) => new Energy(terawattdays, EnergyUnit.TerawattDay);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.TerawattHour"/>.
        /// </summary>
        public static Energy FromTerawattHours(double terawatthours) => new Energy(terawatthours, EnergyUnit.TerawattHour);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.ThermEc"/>.
        /// </summary>
        public static Energy FromThermsEc(double thermsec) => new Energy(thermsec, EnergyUnit.ThermEc);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.ThermImperial"/>.
        /// </summary>
        public static Energy FromThermsImperial(double thermsimperial) => new Energy(thermsimperial, EnergyUnit.ThermImperial);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.ThermUs"/>.
        /// </summary>
        public static Energy FromThermsUs(double thermsus) => new Energy(thermsus, EnergyUnit.ThermUs);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.WattDay"/>.
        /// </summary>
        public static Energy FromWattDays(double wattdays) => new Energy(wattdays, EnergyUnit.WattDay);

        /// <summary>
        ///     Creates a <see cref="Energy"/> from <see cref="EnergyUnit.WattHour"/>.
        /// </summary>
        public static Energy FromWattHours(double watthours) => new Energy(watthours, EnergyUnit.WattHour);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EnergyUnit" /> to <see cref="Energy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Energy unit value.</returns>
        public static Energy From(double value, EnergyUnit fromUnit)
        {
            return new Energy(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(EnergyUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Energy to another Energy with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Energy with the specified unit.</returns>
                public Energy ToUnit(EnergyUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new Energy(convertedValue, unit);
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
                        EnergyUnit.BritishThermalUnit => _value * 1055.05585262,
                        EnergyUnit.Calorie => _value * 4.184,
                        EnergyUnit.DecathermEc => (_value * 1.05505585262e8) * 1e1d,
                        EnergyUnit.DecathermImperial => (_value * 1.05505585257348e8) * 1e1d,
                        EnergyUnit.DecathermUs => (_value * 1.054804e8) * 1e1d,
                        EnergyUnit.ElectronVolt => _value * 1.602176634e-19,
                        EnergyUnit.Erg => _value * 1e-7,
                        EnergyUnit.FootPound => _value * 1.3558179483314004,
                        EnergyUnit.GigabritishThermalUnit => (_value * 1055.05585262) * 1e9d,
                        EnergyUnit.GigaelectronVolt => (_value * 1.602176634e-19) * 1e9d,
                        EnergyUnit.Gigajoule => (_value) * 1e9d,
                        EnergyUnit.GigawattDay => (_value * 24 * 3600d) * 1e9d,
                        EnergyUnit.GigawattHour => (_value * 3600d) * 1e9d,
                        EnergyUnit.HorsepowerHour => _value * 76.0402249 * 9.80665 * 3600,
                        EnergyUnit.Joule => _value,
                        EnergyUnit.KilobritishThermalUnit => (_value * 1055.05585262) * 1e3d,
                        EnergyUnit.Kilocalorie => (_value * 4.184) * 1e3d,
                        EnergyUnit.KiloelectronVolt => (_value * 1.602176634e-19) * 1e3d,
                        EnergyUnit.Kilojoule => (_value) * 1e3d,
                        EnergyUnit.KilowattDay => (_value * 24 * 3600d) * 1e3d,
                        EnergyUnit.KilowattHour => (_value * 3600d) * 1e3d,
                        EnergyUnit.MegabritishThermalUnit => (_value * 1055.05585262) * 1e6d,
                        EnergyUnit.Megacalorie => (_value * 4.184) * 1e6d,
                        EnergyUnit.MegaelectronVolt => (_value * 1.602176634e-19) * 1e6d,
                        EnergyUnit.Megajoule => (_value) * 1e6d,
                        EnergyUnit.MegawattDay => (_value * 24 * 3600d) * 1e6d,
                        EnergyUnit.MegawattHour => (_value * 3600d) * 1e6d,
                        EnergyUnit.Microjoule => (_value) * 1e-6d,
                        EnergyUnit.Millijoule => (_value) * 1e-3d,
                        EnergyUnit.Nanojoule => (_value) * 1e-9d,
                        EnergyUnit.Petajoule => (_value) * 1e15d,
                        EnergyUnit.TeraelectronVolt => (_value * 1.602176634e-19) * 1e12d,
                        EnergyUnit.Terajoule => (_value) * 1e12d,
                        EnergyUnit.TerawattDay => (_value * 24 * 3600d) * 1e12d,
                        EnergyUnit.TerawattHour => (_value * 3600d) * 1e12d,
                        EnergyUnit.ThermEc => _value * 1.05505585262e8,
                        EnergyUnit.ThermImperial => _value * 1.05505585257348e8,
                        EnergyUnit.ThermUs => _value * 1.054804e8,
                        EnergyUnit.WattDay => _value * 24 * 3600d,
                        EnergyUnit.WattHour => _value * 3600d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(EnergyUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        EnergyUnit.BritishThermalUnit => baseUnitValue / 1055.05585262,
                        EnergyUnit.Calorie => baseUnitValue / 4.184,
                        EnergyUnit.DecathermEc => (baseUnitValue / 1.05505585262e8) / 1e1d,
                        EnergyUnit.DecathermImperial => (baseUnitValue / 1.05505585257348e8) / 1e1d,
                        EnergyUnit.DecathermUs => (baseUnitValue / 1.054804e8) / 1e1d,
                        EnergyUnit.ElectronVolt => baseUnitValue / 1.602176634e-19,
                        EnergyUnit.Erg => baseUnitValue / 1e-7,
                        EnergyUnit.FootPound => baseUnitValue / 1.3558179483314004,
                        EnergyUnit.GigabritishThermalUnit => (baseUnitValue / 1055.05585262) / 1e9d,
                        EnergyUnit.GigaelectronVolt => (baseUnitValue / 1.602176634e-19) / 1e9d,
                        EnergyUnit.Gigajoule => (baseUnitValue) / 1e9d,
                        EnergyUnit.GigawattDay => (baseUnitValue / (24 * 3600d)) / 1e9d,
                        EnergyUnit.GigawattHour => (baseUnitValue / 3600d) / 1e9d,
                        EnergyUnit.HorsepowerHour => baseUnitValue / (76.0402249 * 9.80665 * 3600),
                        EnergyUnit.Joule => baseUnitValue,
                        EnergyUnit.KilobritishThermalUnit => (baseUnitValue / 1055.05585262) / 1e3d,
                        EnergyUnit.Kilocalorie => (baseUnitValue / 4.184) / 1e3d,
                        EnergyUnit.KiloelectronVolt => (baseUnitValue / 1.602176634e-19) / 1e3d,
                        EnergyUnit.Kilojoule => (baseUnitValue) / 1e3d,
                        EnergyUnit.KilowattDay => (baseUnitValue / (24 * 3600d)) / 1e3d,
                        EnergyUnit.KilowattHour => (baseUnitValue / 3600d) / 1e3d,
                        EnergyUnit.MegabritishThermalUnit => (baseUnitValue / 1055.05585262) / 1e6d,
                        EnergyUnit.Megacalorie => (baseUnitValue / 4.184) / 1e6d,
                        EnergyUnit.MegaelectronVolt => (baseUnitValue / 1.602176634e-19) / 1e6d,
                        EnergyUnit.Megajoule => (baseUnitValue) / 1e6d,
                        EnergyUnit.MegawattDay => (baseUnitValue / (24 * 3600d)) / 1e6d,
                        EnergyUnit.MegawattHour => (baseUnitValue / 3600d) / 1e6d,
                        EnergyUnit.Microjoule => (baseUnitValue) / 1e-6d,
                        EnergyUnit.Millijoule => (baseUnitValue) / 1e-3d,
                        EnergyUnit.Nanojoule => (baseUnitValue) / 1e-9d,
                        EnergyUnit.Petajoule => (baseUnitValue) / 1e15d,
                        EnergyUnit.TeraelectronVolt => (baseUnitValue / 1.602176634e-19) / 1e12d,
                        EnergyUnit.Terajoule => (baseUnitValue) / 1e12d,
                        EnergyUnit.TerawattDay => (baseUnitValue / (24 * 3600d)) / 1e12d,
                        EnergyUnit.TerawattHour => (baseUnitValue / 3600d) / 1e12d,
                        EnergyUnit.ThermEc => baseUnitValue / 1.05505585262e8,
                        EnergyUnit.ThermImperial => baseUnitValue / 1.05505585257348e8,
                        EnergyUnit.ThermUs => baseUnitValue / 1.054804e8,
                        EnergyUnit.WattDay => baseUnitValue / (24 * 3600d),
                        EnergyUnit.WattHour => baseUnitValue / 3600d,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}

