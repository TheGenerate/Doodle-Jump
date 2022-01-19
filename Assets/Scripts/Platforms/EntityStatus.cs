using System.Collections;
using UnityEngine;

public class EntityStatus : MonoBehaviour
{
	[SerializeField] private Stats stats;
	public int Defence { get; private set; }

	private void Awake()
	{
		Defence = stats.Defence;
	}

	public void SetImmortalFor(float seconds)
	{
		StartCoroutine(Co_SetImmortal(seconds));
	}

	private IEnumerator Co_SetImmortal(float seconds)
	{
		var originalDefence = Defence;
		Defence = 100;
		yield return new WaitForSeconds(seconds);
		Defence = originalDefence;
	}
}