using UnityEngine;

[RequireComponent(typeof(PlatformCleaner))]
public abstract class PlatformEffector : Target
{
	protected override void OnHit(Rigidbody2D player) { }
}