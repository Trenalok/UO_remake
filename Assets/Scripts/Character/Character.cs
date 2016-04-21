using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Scripts.Character.Skills;
using Scripts.Items;
using UnityEngine.UI;

namespace Scripts.Character
{
    public class Character : MonoBehaviour
    {
        Dictionary<EnumSkillTypes, Skill> skills;
        private Backpack Mypackpack;
        public GameObject a;
        //THis is a test
		//public Canvas button;


        float MaxTime = 2.0f;
        float timeCounter = 0.0f;
        int Fire = 0;
        int DeltaFire = 0;

        Dictionary<string, GameObject> MyItems;

        // Use this for initialization
        void Start()
        {
            skills = new Dictionary<EnumSkillTypes, Skill>();
            skills.Add(EnumSkillTypes.SpellCraft, new SpellCraft());
            skills.Add(EnumSkillTypes.Swordsmanship, new Swordsmanship());
            /// Mypackpack = new Backpack();
            /// 
            MyItems = new Dictionary<string, GameObject>();
        }

        // Update is called once per frame
        void Update()
        {

            timeCounter += Time.deltaTime;
            if (timeCounter > MaxTime)
            {
                //BagItem blah = new BagItem();
                //blah.packLocation = new Vector2(0, 0);
                // print("my new item is: "  + blah.item.name);
                // Mypackpack.Items.Add(blah);
              //  if (!MyItems.ContainsKey("BP"))
             /*   {
					GameObject BP = GameObject.Find("EntityManager").GetComponent<EntityManager>().CreateItem(EnumClothingItems.PlateBreast, EnumResourceType.LavaRock);
                    MyItems.Add("BP", BP);
                }
                if (!MyItems.ContainsKey("Helm"))
                {
					GameObject Helm = GameObject.Find("EntityManager").GetComponent<EntityManager>().CreateItem(EnumClothingItems.PlateHelm, EnumResourceType.LavaRock);
                    MyItems.Add("Helm", Helm);
                }
                 //Mypackpack.Items.Add()
                 //skills[EnumSkillTypes.SpellCraft].InvokeAction(gameObject, a);
                 timeCounter = 0;
             //   Mypackpack.PrintAllItems();
            */}

            DeltaFire = Fire;
            Fire = (int)Input.GetAxis("Fire1");

            //  print("FireDown = " + GetAxisDown());
            //  print("FireUp = " + GetAxisUp());
            //  print("Firing = " + Fire);
            GetAxisDown();
            GetAxisUp();
        }

        private void GetAxisDown()
        {
            if (DeltaFire == 0 && Fire == 1)
                print("FireDown = true");

        }

        private void GetAxisUp()
        {
            if (DeltaFire == 1 && Fire == 0)
                print("FireUp = true");

        }

        public static void printString(string blah)
        {
            print(blah);
        }

    }
}

