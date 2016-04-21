using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Scripts.Items
{
    class Helmet : ClothingItem
    {
        
        public Helmet(int weight, int value, string description, EnumItemTypes name, GameObject it) : base(weight, value, description, name)
        {
            //renderableObject = Instantiate()
            renderableObject = it;
        }
    }
}
