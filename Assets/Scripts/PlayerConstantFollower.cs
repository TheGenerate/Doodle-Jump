using UnityEngine;

internal class PlayerConstantFollower : IFollower
{
	private readonly Transform _transform;
	private readonly Transform _followTransform;

	public PlayerConstantFollower(Transform transform, Transform playerTransform)
	{
		_transform = transform;
		_followTransform = playerTransform;
	}

	public void UpdatePosition()
	{
		var pos = _transform.position;
		pos.y = _followTransform.position.y;
		_transform.position = pos;
	}
}