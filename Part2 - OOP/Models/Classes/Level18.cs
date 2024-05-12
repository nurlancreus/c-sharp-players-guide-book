using Part2___OOP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___OOP.Models.Classes
{
    public enum ArrowHead { Steel, Wood, Obsidian }
    public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
    public class Arrow
    {
        private ArrowHead _arrowHead;
        private Fletching _fletching;
        private float _shaft;
        public Arrow()
        {

        }
        public Arrow(ArrowHead arrowHead, Fletching fletching, float shaft)
        {
            ArrowHead = arrowHead;
            Fletching = fletching;
            Shaft = shaft;
        }
        public ArrowHead ArrowHead
        {
            get => _arrowHead;
            init
            {
                if (Enum.IsDefined(typeof(ArrowHead), value.EnumFirstCharToUpper())) _arrowHead = value;
                else throw new Exception("Please, choose the correct arrow head");
            }
        }
        public Fletching Fletching
        {
            get => _fletching;
            init
            {
                if (Enum.IsDefined(typeof(Fletching), value.EnumFirstCharToUpper())) _fletching = value;
                else throw new Exception("Please, choose the correct fletching options");

            }
        }

        public float Shaft
        {
            get { return _shaft; }
            init
            {
                if (value >= 60 && value <= 100) _shaft = value;
                else throw new ArgumentOutOfRangeException("Shaft must be between in 60 - 100 range");
            }
        }

        public float Cost
        {
            get
            {
                float arrowheadCost = ArrowHead switch
                {
                    ArrowHead.Steel => 10,
                    ArrowHead.Wood => 3,
                    ArrowHead.Obsidian => 5,
                    _ => throw new NotImplementedException()
                };

                float fletchingCost = Fletching switch
                {
                    Fletching.Plastic => 10,
                    Fletching.TurkeyFeathers => 5,
                    Fletching.GooseFeathers => 3,
                    _ => throw new NotImplementedException()
                };

                float shaftCost = 0.05f * Shaft;

                return arrowheadCost + fletchingCost + shaftCost;
            }
        }

        public static Arrow CreateEliteArrow() => new(ArrowHead.Steel, Fletching.Plastic, 95);
        public static Arrow CreateBeginnerArrow() => new(ArrowHead.Wood, Fletching.GooseFeathers, 75);
        public static Arrow CreateMarksmanArrow() => new(ArrowHead.Steel, Fletching.GooseFeathers, 65);


        public string DisplayArrow()
        {
            return $"Head: {ArrowHead} - Fletch: {Fletching} - Shaft: {Shaft} - Cost: {String.Format("{0:C}", Cost)}";
        }
    }
}
