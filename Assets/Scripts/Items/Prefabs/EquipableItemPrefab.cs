using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Scripts.Items;

namespace Scripts.Items.Prefabs
{
    public class EquipableItemPrefab : BasePrefabInterface
    {
        public EquipableItem blah;

        // Use this for initialization
        void Start()
        {

        }

        /// <summary>
        /// HAve already determined in the EntityManger that object is of type EnumClothingType, so dont need to check here
        /// </summary>
        /// <param name="type"></param>
        public override void constructor(object type)
        {
            setUpMaterialDictionary();

            print("Bp Made!");
        }

		public override void InstantiateThis(EnumResourceType materialType)
        {

			if (matDict.ContainsKey(materialType.ToString()))
            {
				gameObject.GetComponent<MeshRenderer>().material = matDict[materialType.ToString()];
            }
        }
            /* if (materialType.GetType() == typeof(EnumFabricTypes)) ETC
             {

             }*/
            

        // Update is called once per frame
        void Update()
        {

        }
    }
}
