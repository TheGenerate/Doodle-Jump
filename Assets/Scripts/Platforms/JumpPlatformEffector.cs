using UnityEngine;

public class JumpPlatformEffector : PlatformEffector
{
	[SerializeField] private float jumpSpeed;
	protected override void OnLand(Rigidbody2D player)
	{
		player.velocity = new Vector2(player.velocity.x, jumpSpeed);
	}
}