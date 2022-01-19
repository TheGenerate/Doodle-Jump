using UnityEngine;

public class EnemyPlatformEffector : JumpPlatformEffector
{
	protected override void OnHit(Rigidbody2D player)
	{
		GameManager.GameOver();
	}
}