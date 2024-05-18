using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2___Catacombs_of_theClass.Models.Entities
{
    internal enum CardColor
    {
        Red,
        Green,
        Blue,
        Yellow
    }

    //internal enum CardSymbol
    //{
    //    Dollar,
    //    Percent,
    //    Caret,
    //    Ampersand
    //}

    internal enum CardRank
    {
        One = 1,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        DollarSign,
        Percent,
        Caret,
        Ampersand
    }


    internal class Card
    {
        private CardColor? _color = null;
        private CardRank? _rank = null;

        public Card(CardColor color, CardRank rank)
        {
            Color = color;
            Rank = rank;
        }

        public CardColor? Color
        {
            get => _color;
            init
            {
                if (Enum.IsDefined(typeof(CardColor), value!))
                {
                    _color = value;
                }
                else throw new ArgumentException($"Color you provide must be from {String.Join(", ", Enum.GetNames(typeof(CardColor)))}");
            }
        }

        public CardRank? Rank
        {
            get => _rank;
            init
            {

                if (Enum.IsDefined(typeof(CardRank), value!))
                {
                    _rank = value;
                }
                else throw new ArgumentException($"Rank you provide must be from {String.Join(", ", Enum.GetValues(typeof(CardRank)))}");
            }
        }

        public bool IsSymbol => Rank == CardRank.DollarSign || Rank == CardRank.Ampersand || Rank == CardRank.Caret || Rank == CardRank.Percent;
        public bool IsNumber => !IsSymbol;
        public override string ToString()
        {
            return $"The {Color} {Rank}";
        }
    }
}
