using UnityEngine;

public abstract class PowerUp : ScriptableObject
{
	public abstract void Activate(PowerUpHandler player);
}