using UnityEngine;
using System.Collections;

namespace Scripts.Character.Spells
{
	public enum EnumSpells
	{
		None,
		MagicMissile,
		Hide,
		Incognito,
		Lightning,
		Spark,
		Shock,
		Stoneskin,
		Ironskin,
	}

	public enum FirstCirleSpells
	{
		Spark,
	}
	public enum SecondCirleSpells
	{
		Shock,
	}
	public enum ThirdCirleSpells
	{
		MagicMissile,
		Incognito,
		Stoneskin,

	}
	public enum FourthCirleSpells
	{
		Lightning,
		Hide,
		Ironskin,

	}
	public enum FithCirleSpells
	{

	}
	public enum SixthCirleSpells
	{

	}
	public enum SeventhCirleSpells
	{

	}

	public enum EnumSpellType
	{
		TargetSelf, //Target self spells like Incognito.
		TargetActive,//target player/ground/NPC Direct damage spells/Calls "wall"/Summon direwolf etc
		Targetless //Aura kind of spells. AoE spells around caster, bounus stats etc
	}

	public abstract class Spell
	{

		public bool castSpell(EnumSpellType spellType)
		{
			switch(spellType)
			{
				case EnumSpellType.TargetActive:
					TargetActive ();
					break;
				case EnumSpellType.TargetSelf:
					TargetSelf ();
					break;
				case EnumSpellType.Targetless:
					TargetLess ();
					break;
			}
			return true;
		}

		public abstract bool TargetSelf ();

		public abstract bool TargetActive ();

		public abstract bool TargetLess ();
	}
}
