/* Generated SBE (Simple Binary Encoding) message codec */

#pragma warning disable 1591 // disable warning on missing comments
using System;
using Misakai.Storage.Sbe;

namespace Misakai.Storage.Sbe.Tests.Generated
{
    [Flags]
    public enum SettlPriceType : byte
    {
        Final = 1,
        Actual = 2,
        Rounded = 4,
        ReservedBits = 8,
        NullValue = 128,
    }
}
