using UnityEngine;

public abstract class Target : MonoBehaviour
{
	private void OnTriggerEnter2D(Collider2D other)
	{
		var player = other.attachedRigidbody;
		if (player == null)
			return;
		if (!(player.velocity.y > 0))
			OnLand(player);
		else
			OnHit(player);
	}

	protected abstract void OnHit(Rigidbody2D player);

	protected abstract void OnLand(Rigidbody2D player);
}