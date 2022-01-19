using UnityEngine;

public class PlayerDieHandler : MonoBehaviour
{
	private Collider2D _collider;

	private void Awake() => _collider = GetComponent<Collider2D>();
	private void OnEnable() => GameManager.OnGameOver += PlayerDie;
	private void OnDisable() => GameManager.OnGameOver -= PlayerDie;
	private void PlayerDie() => _collider.enabled = false;
	private void OnBecameInvisible() => GameManager.GameOver();
}
