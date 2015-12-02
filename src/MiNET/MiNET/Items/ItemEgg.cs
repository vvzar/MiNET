using MiNET.Entities;
using MiNET.Utils;
using MiNET.Worlds;

namespace MiNET.Items
{
	public class ItemEgg : Item
	{
		public ItemEgg(short metadata) : base(344, metadata)
		{
			MaxStackSize = 16;
		}

		public override void UseItem(Level world, Player player, BlockCoordinates blockCoordinates)
		{
			if (player.GameMode != GameMode.Creative)
			{
				ItemStack itemStackInHand = player.Inventory.GetItemInHand();
				itemStackInHand.Count--;

				if (itemStackInHand.Count <= 0)
				{
					// set empty
					player.Inventory.Slots[player.Inventory.Slots.IndexOf(itemStackInHand)] = new ItemStack();
				}
			}

			float force = 1.5f;

			Egg egg = new Egg(null, world);
			egg.KnownPosition = (PlayerLocation) player.KnownPosition.Clone();
			egg.KnownPosition.Y += 1.62f;
			egg.Velocity = egg.KnownPosition.GetDirection()*(force);
			egg.BroadcastMovement = false;
			egg.DespawnOnImpact = true;
			egg.SpawnEntity();
		}
	}
}