using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GildedTros.App.Services
{
    public interface IItemStrategy
    {
        void UpdateQuality(Item item);
    }
}
