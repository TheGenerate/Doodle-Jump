using UnityEngine;

internal class PlayerPlayFollower : IFollower
{
	private readonly Transform _transform;
	private readonly Transform _followTransform;
	private float _currentHighest;

	public PlayerPlayFollower(Transform transform, Transform playerTransform)
	{
		_transform = transform;
		_followTransform = playerTransform;
	}

	public void UpdatePosition()
	{
		if (!(_followTransform.position.y > _currentHighest))
			return;
		var posY = _followTransform.position.y;
		var position = _transform.position;
		position.y = posY;
		_transform.position = position;
		_currentHighest = posY;
	}
}