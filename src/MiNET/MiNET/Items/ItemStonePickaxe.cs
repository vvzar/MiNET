namespace MiNET.Items
{
	public class ItemStonePickaxe : Item
	{
		public ItemStonePickaxe(short metadata) : base(274, metadata)
		{
			ItemMaterial = ItemMaterial.Stone;
			ItemType = ItemType.Pickaxe;
		}
	}
}
