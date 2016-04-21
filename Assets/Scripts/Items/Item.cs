using System;
using System.Collections.Generic;
using UnityEngine;


namespace Scripts.Items
{

    public enum EnumItemTypes
    {
        ResourceItem,
        ClothingItem,
        ConsumableItem,
        EquipableItem,
        TrinketItem,
        ContainerItem,
        PlaceableItem
    }

    public enum EnumClothingItems
    {
        PlateBreast,
        PlateLeggings,
        PlateHelm,
        PlateGloves,
        PlateGorget
    }

    public enum EnumEquipableItems
    {
        Longsword
    }

    public enum EnumResourceType
    {
        Iron,
        LavaRock,
        Oak,
        BloodOak
    }

    [System.Serializable]
    public class Item
    {
        public int weight;

        public int value;

        public GameObject renderableObject;
        public Sprite BackPackobject;

        protected string description;
        public string Description { get { return description; } }

        public EnumItemTypes type;

        public Item(int weight, int value, string description, EnumItemTypes name)
        {
            //renderableObject = gameObject;
            this.description = description;
            this.value = value;
            this.weight = weight;
            type = name;
        }

    }

    /// <summary>
    /// Used for creation of other things... wood, minerals, plants.. Have no effect on player stats.
    /// </summary>
    /// 
    [System.Serializable]
    public class ResourceItem : Item
    {
        //enum resource type
        public ResourceItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }

    /// <summary>
    /// These are items can be equipped onto the body. ie armour
    /// </summary>
    /// 
    [System.Serializable]
    public class ClothingItem : Item
    {
        //enum clothing type
        public ClothingItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {
        }
    }


    /// <summary>
    /// These items are consumable, food, potions, have effect on players stats.  
    /// Might need to refine plants to reagents.. reagents being consumable.
    /// </summary>
    /// 
    [System.Serializable]
    public class ConsumableItem : Item
    {
        //enum consumable type
        public ConsumableItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }

    /// <summary>
    /// These are items that a player would equip into their hand, IE sword, pickaxe, shovel
    /// </summary>
    /// 
    [System.Serializable]
    public class EquipableItem : Item
    {
        //enum equipable type
        public EquipableItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }

    /// <summary>
    /// This would be all the different rings and necklaces and stuff
    /// </summary>
    /// 
    [System.Serializable]
    public class TrinketItem : Item
    {
        //enum trinket type
        public TrinketItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }

    /// <summary>
    /// These reside in the backpack or placeable containers
    /// </summary>
    [System.Serializable]
    public class ContainerItem : Item
    {
        public ContainerItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }



    /// <summary>
    /// These items can be placed INTO the game world .. IE a statue
    /// Some of these items might be chests, or.. placeable bags
    /// </summary>
    public abstract class PlaceableItem : Item
    {
        //enum placeable type
        public PlaceableItem(int weight, int value, string description, EnumItemTypes name) : base(weight, value, description, name)
        {

        }
    }
}
