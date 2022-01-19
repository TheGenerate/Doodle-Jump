using UnityEngine;

[CreateAssetMenu(menuName = "Create Stats", fileName = "Stats", order = 0)]
public class Stats : ScriptableObject
{
	[SerializeField] private int defence;
	public int Defence => defence;
}