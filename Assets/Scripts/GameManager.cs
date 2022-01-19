using System;
using System.Collections;
using UnityEngine;

public class GameManager : MonoBehaviour
{
	public static event Action OnPlay;
	public static event Action OnGameOver;
	private static event Action OnReadyNewState;
	private static GameManager _Instance;

	private void Awake() => _Instance = this;
	private void OnEnable() => OnGameOver += HandleGameOver;
	private void OnDisable() => OnGameOver -= HandleGameOver;
	private void Start() => OnPlay?.Invoke();
	private void HandleGameOver() => StartCoroutine(WaitUntilOutOfScreen());

	private static IEnumerator WaitUntilOutOfScreen()
	{
		yield return new WaitForSeconds(3);
		OnReadyNewState?.Invoke();
	}

	public static void GameOver() => OnGameOver?.Invoke();
}