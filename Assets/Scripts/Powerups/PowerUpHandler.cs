using System;
using UnityEngine;

public class PowerUpHandler : MonoBehaviour
{
	public EntityStatus Status { get; private set; }

	private void Awake()
	{
		Status = GetComponent<EntityStatus>();
	}
}