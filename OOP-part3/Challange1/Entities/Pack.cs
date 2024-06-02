using OOP_part3.Challange1.Entities.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_part3.Challange1.Entities
{
    internal class Pack(float maxWeight, float maxVolume, byte maxSize)
    {
        readonly private List<InventoryItem> items = [];
        public float MaxWeight { get; private set; } = maxWeight;
        public float MaxVolume { get; private set; } = maxVolume;
        public byte MaxCount { get; private set; } = maxSize;

        private float _currentWeight = 0;
        private float _currentVolume = 0;

        public void Add(InventoryItem item)
        {
            if (_currentWeight + item.Weight > MaxWeight)
                throw new ArgumentException("Weigth exceeds max value");

            if (_currentVolume + item.Volume > MaxVolume)
                throw new ArgumentException("Volume exceeds max value");

            if (items.Count == MaxCount)
                throw new ArgumentException("Count exceeds max value");

            items.Add(item);

            _currentWeight += item.Weight;
            _currentVolume += item.Volume;
        }

        public void DisplayPack()
        {
            _currentWeight = 0;
            _currentVolume = 0;

            foreach (var item in items)
            {
                _currentWeight += item.Weight;
                _currentVolume += item.Volume;
            }

            _currentVolume = (float)Math.Round(_currentVolume, 2);
            _currentWeight = (float)Math.Round(_currentWeight, 2);

            string output = $"Current pack has {items.Count} items (max: {MaxCount})\n"
                + $"{_currentWeight} kg weigth (max: {MaxWeight})\n"
                + $"{_currentVolume} volume (max: {MaxVolume})\n";

            Console.WriteLine(output);
        }

        public override string ToString()
        {
            return $"The Pack contains: {string.Join(", ", items)}";
        }
    }
}
