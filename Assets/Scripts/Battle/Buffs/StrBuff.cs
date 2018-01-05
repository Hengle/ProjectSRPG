using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrBuff : Buff
{
	private int value = 1;

	private readonly BuffType buffType = BuffType.STRENGTH;

	public override int GetBuffValue()
	{
		return value;
	}
}
