using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Scripts.Items;
using Scripts.Items.Prefabs;


public class EntityManager : MonoBehaviour {
    /// <summary>
    ///  Clothing Prefabs
    /// </summary>
	public GameObject[] ClothingTypes;
	Dictionary<string, GameObject> ClothingPrefabDict;

    /// <summary>
    /// 
    /// </summary>
    public GameObject[] EquipableTypes;
    Dictionary<string, GameObject> EquipablePrefabDict;

    // Use this for initialization
    void Start () {
        SetUpDictionaries(ref ClothingPrefabDict, ref ClothingTypes);
        SetUpDictionaries(ref EquipablePrefabDict, ref EquipableTypes);
    }

    private void SetUpDictionaries(ref Dictionary<string, GameObject> dict, ref GameObject[] array)
    {
        dict = new Dictionary<string, GameObject>();
        foreach (GameObject obj in array)
        {
            print(obj.name);
            dict.Add(obj.name, obj);
        }
    } 

    // Update is called once per frame
    void Update () {

	}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Item">This is one of many types of Enums (ClothingItems, EquipableItem, TrinketItem, ConsumableItem, ContainerItem) </param>
    /// <param name="resourceType"></param>
    /// <param name="ItemType"></param>
    /// <returns></returns>
	public GameObject CreateCraftableItem(object Item, EnumResourceType resourceType, EnumItemTypes ItemType)
    {
        print("Creating Game Object ");
        GameObject item = null;

        switch (ItemType)
        {
            case EnumItemTypes.ClothingItem:
                item = CreateCraftableItem(Item, resourceType, ClothingPrefabDict);
                break;
            case EnumItemTypes.EquipableItem:
                item = CreateCraftableItem(Item, resourceType, EquipablePrefabDict);
                break;
            default:
                break;
        }
        return item;
            
	}

    /// <summary>
    /// Every Craftable Item is created through this function
    /// </summary>
    /// <param name="Item">This is one of many types of Enums (ClothingItems, EquipableItem, TrinketItem, ConsumableItem, ContainerItem)</param>
    /// <param name="resourceType"></param>
    /// <param name="itemDictionary"></param>
    /// <returns></returns>
    private GameObject CreateCraftableItem(object Item, EnumResourceType resourceType, Dictionary<string, GameObject> itemDictionary)
    {
        GameObject item = null;
        if (itemDictionary.ContainsKey(Item.ToString() + "Prefab"))
        {
            print("The prefab was found ");
            item = GameObject.Instantiate(itemDictionary[Item.ToString() + "Prefab"]);
            item.GetComponent<BasePrefabInterface>().constructor(Item);
            print(item.ToString());

            //Extract the prefab info to ensure right resourceType.
            if (item.GetComponent<BasePrefabInterface>().matDict.ContainsKey(resourceType.ToString()))
            {
                item.GetComponent<BasePrefabInterface>().InstantiateThis(resourceType);
            }
            else
            {
                print("Material does not match");
                Destroy(item);
            }
        }
        return item;
    }


    /// <summary>
    /// Every Non Cractable Item is created this way (It doesnt need a resource type
    /// </summary>
    /// <param name="resource"></param>
    /// <returns></returns>
    public GameObject CreateResource(EnumResourceType resource)
    {
        return null;
    }


	/*
    public bool CreateArmour(EnumArmourType ar, EnumMineralTypes mineral)
    {
        return false;
    }

    public bool CreateMetalWeapon(EnumWeaponType we, EnumMineralTypes mineral)
    {
        return false;
    }

    public bool CreateWoodWeapon(EnumWeap
    */
}