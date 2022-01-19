using UnityEngine;

public abstract class PowerUpItem : MonoBehaviour
{
	[SerializeField] private PowerUp powerUp;

	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PowerUpHandler>() is {} player)
			powerUp.Activate(player);
	}

}