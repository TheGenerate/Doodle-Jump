using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.GetComponent<PlayerMovement>() is {} player)
			OnHit(player);
	}

	protected abstract void OnHit(PlayerMovement playerMovement);
}