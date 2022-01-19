using UnityEngine;

public class EnemyPlatformEffector : JumpPlatformEffector
{
	protected override void OnHit(Rigidbody2D player)
	{
		if(player.GetComponent<EntityStatus>().Defence < 5)
			GameManager.GameOver();
		else
			Destroy(gameObject);
	}
}