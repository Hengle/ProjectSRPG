using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buff {
	public readonly int value = 0;

	public int turnsActive = 0;

	public readonly BuffType buffType;

	public bool BuffIsActive()
	{
		return turnsActive > 0;
	}
}
