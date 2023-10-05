using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice5
{
    internal class Cart : Vehicle
    {
        private WhoCanPull _whoPull;
        private string _content;
        private int _maxWeight;

        public WhoCanPull WhoPull
        { 
            get => _whoPull; 
            set => _whoPull = value; 
        }

        public string Content { 
            get => _content; 
            set => _content = value; 
        }

        public int MaxWeight { 
            get => _maxWeight; 
            set => _maxWeight = value;
        }

        public Cart(int x, int y, int maxSpeed, int countOfWheels, string nameOfOwner, WhoCanPull whoPull, string content, int maxWeight) : base(x, y, maxSpeed, countOfWheels, nameOfOwner)
        {
            WhoPull = whoPull;
            Content = content;
            MaxWeight = maxWeight;
        }

        public override string ToString()
        {
            return $"Повозка:\nКто тянет повозку = {WhoPull}\nСодержимое = {Content}\nМаксимальный переносимый вес = {MaxWeight} {base.ToString()}";
        }

    }
}
