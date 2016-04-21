using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Scripts.Items.Prefabs
{
    public abstract class BasePrefabInterface : MonoBehaviour
    {
        public Material[] renderableMaterials;
        public Dictionary<string, Material> matDict;

        public abstract void constructor(object type);

        /// <summary>
        /// HAS TO BE CALLED BY EVERY CONSTRUCTOR!
        /// </summary>
        public void setUpMaterialDictionary()
        {
            matDict = new Dictionary<string, Material>();
            foreach (Material mat in renderableMaterials)
            {
                matDict.Add(mat.name, mat);
            }
        }

		public abstract void InstantiateThis(EnumResourceType materialType);
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
