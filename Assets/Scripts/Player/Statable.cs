using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Statable: MonoBehaviour
{
	private int constitution;

	private int strength;

	private int agility;

	private int intellect;

	private int charisma;

	private List<Buff> buffs;

	/// <summary>
	/// Get base constitution of this object, no modifiers applied.
	/// </summary>
	/// <returns></returns>
	public int GetBaseConstitution()
	{
		return constitution;
	}

	/// <summary>
	/// Get buffed constitution
	/// </summary>
	/// <returns></returns>
	public int GetBuffedConstitution()
	{
		int buffedConstitution = constitution;
		foreach (Buff buff in buffs)
		{
			if (buff.buffType == BuffType.CONSTITUTION)
			{
				buffedConstitution += buff.value;
			}

		}
		return buffedConstitution;
	}

	

	
}
