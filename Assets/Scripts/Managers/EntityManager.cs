using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Scripts.Items;
using Scripts.Items.Prefabs;


public class EntityManager : MonoBehaviour {
	public GameObject[] ClothingTypes;
	Dictionary<string, GameObject> PrefabDict;
	// Use this for initialization
	void Start () {
		PrefabDict = new Dictionary<string, GameObject>();
		foreach (GameObject clothing in ClothingTypes)
		{
			print(clothing.name);
			PrefabDict.Add(clothing.name, clothing);
		}

	}

	// Update is called once per frame
	void Update () {

	}

	public GameObject CreateItem(object Item, EnumResourceType resourceType)
	{
		print ("Creating Game Object ");
		GameObject item = null;
		if (PrefabDict.ContainsKey(Item.ToString() + "Prefab"))
		{
			print ("The prefab was found ");
			item = GameObject.Instantiate(PrefabDict[Item.ToString() + "Prefab"]);
			item.GetComponent<ItemPrefab>().constructor(Item);
			print (item.ToString());

			//Extract the prefab info to ensure right resourceType.
			if (item.GetComponent<ItemPrefab> ().matDict.ContainsKey (resourceType.ToString ()))
			{
				item.GetComponent<ItemPrefab>().InstantiateThis(resourceType);
			} else
			{
				print ("Material does not match");
				Destroy (item);
			}
		}
		return item;
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