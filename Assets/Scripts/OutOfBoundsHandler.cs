using UnityEngine;

public class OutOfBoundsHandler : MonoBehaviour
{
	private Camera _camera;
	private void Awake() => _camera = Camera.main;

	private void FixedUpdate()
	{
		var screenPos = _camera.WorldToScreenPoint(transform.position);
			 
		if (screenPos.x < 0)
		{
			screenPos.x = Screen.width;
			transform.position = _camera.ScreenToWorldPoint(screenPos);
		}
		else if ( screenPos.x > Screen.width)
		{
			screenPos.x = 0;
			transform.position = _camera.ScreenToWorldPoint(screenPos);
		}
	}
}