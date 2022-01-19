using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
	[SerializeField] private float horizontalSpeed;
	[SerializeField] private int jumpForce = 10;
	private Rigidbody2D _rigidbody;

	private void Awake() => _rigidbody = GetComponent<Rigidbody2D>();

	private IEnumerator Start()
	{
		while (_rigidbody.velocity.y >= 0)
			yield return null;
		_rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
	}

	private void Update() => _rigidbody.velocity = new Vector2(Input.GetAxis("Horizontal") * horizontalSpeed, _rigidbody.velocity.y);
}


