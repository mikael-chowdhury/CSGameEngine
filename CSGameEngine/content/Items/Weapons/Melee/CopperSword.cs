class CopperSword : Melee
{
    public CopperSword() : base("Copper Sword", "Items/Weapons/Melee/copper_sword.png", 5, ItemRarity.COMMON)
    {
        image.LoadedTexture.width = 75;
        image.LoadedTexture.height = 75;
    }

    public override void updateIngame(Player player)
    {
        base.updateIngame(player);
    }
}