using UnityEngine;
using System.Collections;

namespace Scripts.Character
{
    public enum EnumSkillTypes
    {
        None,
        Alchemy,
        Anatomy,
        AnimalLore,
        ArmsLore,
        Blacksmithy,
        Camping,
        Carpentry,
        Cooking,
        DetectHidden,
        Fishing,
        Fletching,
        Forensics,
        Healing,
        Herding,
        Hiding,
        Inscription,
        Knifesmanship,
        Lockpicking,
        Lumberjack,
        Mace,
        Marksmanship,
        Masonry,
        Meditation,
        Mining,
        Necromancy,
        Parrying,
        Pickpocket,
        Poisoning,
        Polearms,
        RemoveTrap,
        ResistSpells,
        Rituals,
        SpellCraft,
        SpiritSpeak,
        Stealth,
        Swordsmanship,
        Tactics,
        Tailoring,
        Taming,
        Tasting,
        Tinkering,
        Tracking,
        Traping,
        Vetinary,
        WeaponThrowing,
        Wrestling
    };

    public enum EnumSkillActionType
    {
        Passive, //modifiers like .. archery, swordsmanship etc
        TargetActive,//target object ie Healing - PlayerObject, Mining - GroundObject, Lumbering - EnvironmentObject
        Targetless //action just works! ie Hiding
    }

    /// <summary>
    /// Base Skill class, all skills derived from this.
    /// </summary>
    public abstract class Skill
    {
        private EnumSkillTypes skillType;
        public EnumSkillTypes SkillType
        { get { return skillType; } }

        private EnumSkillActionType actionType;
        public EnumSkillActionType ActionType
        {
            get { return actionType; }
        }

        protected float skilllevel;
        public float SkillLevel { get { return skilllevel; } }
        protected float SkillCap;

        public Skill(EnumSkillTypes skillType, EnumSkillActionType actionType)
        {
            this.skillType = skillType;
            this.actionType = actionType;
            SkillCap = 100;
            skilllevel = 0;
        }

        /// <summary>
        /// This will be called internally by each skill
        /// 
        /// </summary>
        /// <returns></returns>
        private bool skillIncrease()
        {
            float increase = (float)System.Math.Round((SkillCap - skilllevel) * 0.01f + 0.1f, 2);
            Character.printString("Level Increase from: " + skilllevel);
            skilllevel += increase;
            Character.printString("Level Increase to: " + skilllevel + ", Thats an increase by: " + increase);
            return true;
        }

        /// <summary>
        /// Simple check to see it this skill isnt maxed out
        /// </summary>
        /// <returns></returns>
        private bool IsNotCapped()
        {
            return SkillLevel < SkillCap;
        }

        /// <summary>
        ///               101 - (100-0) ==  0 - 1 
        ///               101 - (100-50) == 0 - 51
        ///               101 - (100-99) == 0 - 100
        /// </summary>
        /// <returns></returns>
        private bool LevelUpChance()
        {
            float range = (SkillCap + 2) - (SkillCap - skilllevel);
            int val = (int)Random.Range(0, range);
            return (val == 1);
        }

        /// <summary>
        /// This is the exposed function to all of the skill classes to initiate the level up process.
        /// 
        /// </summary>
        /// <returns></returns>
        protected bool SkillSuccess()
        {
            bool lvlupchance = LevelUpChance();
            Character.printString("level Up Chance is: " + lvlupchance);
            if (IsNotCapped() && lvlupchance)
            {
                return skillIncrease();
            }
            return false;
        }



        /// <summary>
        /// Needs to be implemented for each skill
        /// This does the skill action
        /// </summary>
        /// <param name="Player"></param>
        /// <param name="thing"></param>
        /// <returns></returns>
        public abstract bool InvokeAction(GameObject Player, object thing = null);

        /// <summary>
        /// This is just a check to see if the action CAN be invoked
        /// needs to be impplemented individually for each skill
        /// </summary>
        /// <returns></returns>
        public abstract bool CanInvokeAction();


    }

    /// <summary>
    /// Spellcraft Class
    /// </summary>
    public class SpellCraft : Skill
    {


        public SpellCraft() : base(EnumSkillTypes.SpellCraft, EnumSkillActionType.Passive)
        {
            skilllevel = 0;
        }

        public override bool InvokeAction(GameObject Player, object thing = null)
        {
            if (skilllevel < 10)
            {
                //Can only cast level 1 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel < 20)
            {
                //Can only cast level 2 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel < 30)
            {
                //Can only cast level 3 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel < 45)
            {
                //Can only cast level 4 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel < 60)
            {
                //Can only cast level 5 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel < (SkillCap - (SkillCap / 6)))
            {
                //Can only cast level 6 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            else if (skilllevel <= SkillCap)
            {
                //Can only cast level 7 spells
                //  if(((Spell)thing).GetLevel == 1)
                //  {
                //
                //  }
            }
            //etc etc

            ((GameObject)thing).SetActive(!((GameObject)thing).activeSelf);

            if (((GameObject)thing).activeSelf == true)
            {
                return SkillSuccess();
            }
            return true;
        }

        /// <summary>
        /// Might need this.. not sure how to implement yet
        /// </summary>
        /// <returns></returns>
        public override bool CanInvokeAction()
        {
            return false;
        }


    }

    /// <summary>
    /// SwordsmanShip Class
    /// </summary>
    public class Swordsmanship : Skill
    {
        public Swordsmanship() : base(EnumSkillTypes.Swordsmanship, EnumSkillActionType.Passive)
        {

        }

        public override bool InvokeAction(GameObject Player, object thing)
        {
            if (Player.GetComponent<MeshRenderer>().material.color != Color.red)
                Player.GetComponent<MeshRenderer>().material.color = Color.red;
            else
                Player.GetComponent<MeshRenderer>().material.color = Color.blue;

            return true;
        }

        /// <summary>
        /// Might need this.. not sure how to implement yet
        /// </summary>
        /// <returns></returns>
        public override bool CanInvokeAction()
        {
            return false;
        }

    }

}