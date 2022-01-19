using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	private IFollower _gameOverFollower;
	private IFollower _follower;
	private IFollower _playFollower;

	private void Awake()
	{
		var playerTransform = FindObjectOfType<PlayerMovement>()?.transform;
		_gameOverFollower = new PlayerConstantFollower(transform, playerTransform);
		_playFollower = new PlayerPlayFollower(transform, playerTransform);
	}

	private void OnEnable()
	{
		GameManager.OnGameOver += HandleGameOver;
		GameManager.OnPlay += HandleOnPlay;
	}

	private void OnDisable()
	{
		GameManager.OnGameOver -= HandleGameOver;
		GameManager.OnPlay -= HandleOnPlay;
	}

	private void HandleOnPlay() => _follower = _playFollower;

	private void HandleGameOver() => _follower = _gameOverFollower;

	private void Start() => _follower.UpdatePosition();

	private void Update() => _follower.UpdatePosition();

}