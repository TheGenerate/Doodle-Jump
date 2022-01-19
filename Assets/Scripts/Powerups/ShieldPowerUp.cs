public class ShieldPowerUp : PowerUp
{
	public override void Activate(PowerUpHandler player)
	{
		player.Status.SetImmortalFor(5);
	}
}