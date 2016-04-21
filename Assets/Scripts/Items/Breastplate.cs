using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Scripts.Items
{
    class Breastplate : ClothingItem
    {
        
        public Breastplate(int weight, int value, string description, EnumItemTypes name, GameObject it) : base(weight, value, description, name)
        {
            //renderableObject = Instantiate()
          //  renderableObject = it;
        }
    }
}
