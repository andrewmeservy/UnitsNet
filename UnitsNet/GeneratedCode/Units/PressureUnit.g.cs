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

// ReSharper disable once CheckNamespace
namespace UnitsNet.Units
{
    // Disable missing XML comment warnings for the generated unit enums.
    #pragma warning disable 1591

    public enum PressureUnit
    {

        /// <summary>
        ///     The standard atmosphere (symbol: atm) is a unit of pressure defined as 101325 Pa. It is sometimes used as a reference pressure or standard pressure. It is approximately equal to Earth's average atmospheric pressure at sea level.
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Standard_atmosphere_(unit)</remarks>
        Atmosphere = 1,

        /// <summary>
        ///     The bar is a metric unit of pressure defined as 100,000 Pa (100 kPa), though not part of the International System of Units (SI). A pressure of 1 bar is slightly less than the current average atmospheric pressure on Earth at sea level (approximately 1.013 bar).
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Bar_(unit)</remarks>
        Bar = 2,
        Centibar = 3,
        CentimeterOfWaterColumn = 48,
        Decapascal = 4,
        Decibar = 5,
        DynePerSquareCentimeter = 6,
        FootOfHead = 8,
        Gigapascal = 9,
        Hectopascal = 10,

        /// <summary>
        ///     Inch of mercury (inHg and ″Hg) is a non-SI unit of measurement for pressure. It is used for barometric pressure in weather reports, refrigeration and aviation in the United States. It is the pressure exerted by a column of mercury 1 inch (25.4 mm) in height at the standard acceleration of gravity.
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Inch_of_mercury</remarks>
        InchOfMercury = 11,

        /// <summary>
        ///     Inches of water is a non-SI unit for pressure. It is defined as the pressure exerted by a column of water of 1 inch in height at defined conditions. At a temperature of 4 °C (39.2 °F) pure water has its highest density (1000 kg/m3). At that temperature and assuming the standard acceleration of gravity, 1 inAq is approximately 249.082 pascals (0.0361263 psi).
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Inch_of_water</remarks>
        InchOfWaterColumn = 12,
        Kilobar = 13,

        /// <summary>
        ///     A kilogram-force per centimetre square (kgf/cm2), often just kilogram per square centimetre (kg/cm2), or kilopond per centimetre square (kp/cm2) is a deprecated unit of pressure using metric units. It is not a part of the International System of Units (SI), the modern metric system. 1 kgf/cm2 equals 98.0665 kPa (kilopascals). It is also known as a technical atmosphere (symbol: at).
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Kilogram-force_per_square_centimetre</remarks>
        KilogramForcePerSquareCentimeter = 14,
        KilogramForcePerSquareMeter = 15,
        KilogramForcePerSquareMillimeter = 16,
        KilonewtonPerSquareCentimeter = 17,
        KilonewtonPerSquareMeter = 18,
        KilonewtonPerSquareMillimeter = 19,
        Kilopascal = 20,
        KilopoundForcePerSquareFoot = 21,
        KilopoundForcePerSquareInch = 22,
        KilopoundForcePerSquareMil = 23,
        Megabar = 24,
        MeganewtonPerSquareMeter = 25,
        Megapascal = 26,
        MeterOfHead = 28,

        /// <summary>
        ///     A centimetre of water is defined as the pressure exerted by a column of water of 1 cm in height at 4 °C (temperature of maximum density) at the standard acceleration of gravity, so that 1 cmH2O (4°C) = 999.9720 kg/m3 × 9.80665 m/s2 × 1 cm = 98.063754138 Pa, but conventionally a nominal maximum water density of 1000 kg/m3 is used, giving 98.0665 Pa.
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Centimetre_or_millimetre_of_water</remarks>
        MeterOfWaterColumn = 57,
        Microbar = 29,
        Micropascal = 30,
        Millibar = 31,

        /// <summary>
        ///     A millimetre of mercury is a manometric unit of pressure, formerly defined as the extra pressure generated by a column of mercury one millimetre high, and currently defined as exactly 133.322387415 pascals.
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Millimetre_of_mercury</remarks>
        MillimeterOfMercury = 32,
        MillimeterOfWaterColumn = 33,
        Millipascal = 34,
        NewtonPerSquareCentimeter = 35,
        NewtonPerSquareMeter = 36,
        NewtonPerSquareMillimeter = 37,
        Pascal = 38,
        PoundForcePerSquareFoot = 39,
        PoundForcePerSquareInch = 40,
        PoundForcePerSquareMil = 41,
        PoundPerInchSecondSquared = 42,

        /// <summary>
        ///     A kilogram-force per centimetre square (kgf/cm2), often just kilogram per square centimetre (kg/cm2), or kilopond per centimetre square (kp/cm2) is a deprecated unit of pressure using metric units. It is not a part of the International System of Units (SI), the modern metric system. 1 kgf/cm2 equals 98.0665 kPa (kilopascals). It is also known as a technical atmosphere (symbol: at).
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Kilogram-force_per_square_centimetre</remarks>
        TechnicalAtmosphere = 43,
        TonneForcePerSquareCentimeter = 44,
        TonneForcePerSquareMeter = 45,
        TonneForcePerSquareMillimeter = 46,

        /// <summary>
        ///     The torr (symbol: Torr) is a unit of pressure based on an absolute scale, defined as exactly 1/760 of a standard atmosphere (101325 Pa). Thus one torr is exactly 101325/760 pascals (≈ 133.32 Pa).
        /// </summary>
        /// <remarks>https://en.wikipedia.org/wiki/Torr</remarks>
        Torr = 47,
    }

    #pragma warning restore 1591
}
