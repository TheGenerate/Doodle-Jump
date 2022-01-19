using UnityEngine;

public class PlatformCleaner : MonoBehaviour
{
	private void OnBecameInvisible() => Destroy(gameObject);
}