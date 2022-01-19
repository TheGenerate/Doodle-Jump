using UnityEngine;

public class DestructiblePlatformEffector : PlatformEffector
{
	protected override void OnLand(Rigidbody2D player)
	{
		Destroy(gameObject);
	}
}

