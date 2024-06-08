using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part3.Challenge4
{
    internal enum Material
    {
        Wood = 1,
        Bronze,
        Iron,
        Steel,
        Binarium
    }

    internal enum Gemstone
    {
        None = 0,
        Emerald,
        Amber,
        Sapphire,
        Diamond,
        Bitstone
    }

    internal record Sword
    {
        public Material Material { get; init; }
        public Gemstone? Gemstone { get; init; } = null;

        public int Length { get; init; }
        public int CrossGuardW { get; init; }

        public Sword(Material material)
        {
            Material = material;
        }

        public override string ToString()
        {
            return $"Sword's material: {Material}, gemstone: {(Gemstone == null ? "None" : Gemstone)}, length: {Length}, Cross guard width: {CrossGuardW}";
        }
    }
}
