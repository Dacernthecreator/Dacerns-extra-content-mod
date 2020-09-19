// Dacern.Items.Materials

using Microsoft.Xna.Framework;
using System.ComponentModel;
using System.Media;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Dacern.FriendlyNPC;
using Dacern.Items;
using Dacern.Enemies;
using Dacern.DacernWorld;
using Dacern.Projectiles;
//using Dacern.DacernPlayer;
using Dacern;
using System.Security.Cryptography.X509Certificates;


namespace Dacern.Items.Materials
{
	public class GolemSoul : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of the Golem");
			Tooltip.SetDefault("A soul of an ancient lihzahrd idol.");
		}

		public override void SetDefaults()
		{
			item.value = 1000;
			item.rare = 7;
			item.maxStack = 999;
		}

	}
	public class MatterManipulationPowder : ModItem
	{
		
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A powder capable of many things.");
		}
		public override void SetDefaults()
		{
			item.value = 15000;
			item.rare = 5;
			item.maxStack = 999;
		}
		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.PurificationPowder, 25);
			recipe.AddIngredient(ModContent.ItemType<VoidMaterial>(), 4);
			recipe.AddIngredient(ModContent.ItemType<SoulOfMidnight>(), 5);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
	public class Hilt : ModItem
	{
		public virtual void SetDefaults()
		{
			DisplayName.SetDefault("Hilt");
			Tooltip.SetDefault("Used for crafting basic weapons.");
			item.value = 0;
			item.rare = 0;
			item.maxStack = 1;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ClayBlock, 10);
			recipe.AddIngredient(ItemID.StoneBlock, 25);
			recipe.AddIngredient(ModContent.ItemType<ThickStick>(), 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class MajorUpgrade : ModItem
	{
		public override void SetDefaults()
		{
		
			item.value = 0;
			item.rare = 11;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 15);
			recipe.AddIngredient(ModContent.ItemType<LunarRod>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 5);
			recipe.AddIngredient(ModContent.ItemType<RainbowGemsword>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Imperfections>(), 1);
			recipe.AddIngredient(ModContent.ItemType<UniversalFragment>(), 2);
			recipe.AddIngredient(ModContent.ItemType<SoulOfMidnight>(), 20);
			recipe.AddIngredient(ModContent.ItemType<SoulOfDaylight>(), 20);
			recipe.AddIngredient(ModContent.ItemType<SoulOfTwilight>(), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}

	public class Imperfections : ModItem
	{
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = -1;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<SupressedMemory>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Nightmare>(), 1);
			recipe.AddIngredient(ModContent.ItemType<Sadness>(), 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class LargeGem : ModItem
	{
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = 5;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Ruby, 5);
			recipe.AddIngredient(ItemID.Emerald, 5);
			recipe.AddIngredient(ItemID.Sapphire, 5);
			recipe.AddIngredient(ItemID.Amethyst, 5);
			recipe.AddIngredient(ItemID.Topaz, 5);
			recipe.AddIngredient(ItemID.Amber, 5);
			recipe.AddIngredient(ItemID.Diamond, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
	}
	public class LunarRod : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An ingredient to making the most powerful weapons to ever exist.");
		}
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = 11;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Meowmere, 1);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.LastPrism, 1);
			recipe.AddIngredient(ItemID.MoonlordTurretStaff, 1);
			recipe.AddIngredient(ItemID.RainbowCrystalStaff, 1);
			recipe.AddIngredient(ItemID.FireworksLauncher, 1);
			recipe.AddIngredient(ItemID.LunarFlareBook, 1);
			recipe.AddIngredient(ItemID.Terrarian, 1);
			recipe.AddIngredient(ItemID.SDMG, 1);
			recipe.AddTile(TileID.LunarCraftingStation); 
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class MinorUpgrade : ModItem
	{
		public override void SetDefaults()
		{
			item.value = 0;
			item.maxStack = 999;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 5);
			recipe.AddIngredient(ItemID.MeteoriteBar, 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class SoulOfDaylight : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A soul that shines with the brightness of the sun.");
		}
		public override void SetDefaults()
		{
			
			item.value = 1000;
			item.rare = 5;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofLight, 7);
			recipe.AddIngredient(ItemID.SoulofSight, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class SupressedMemory : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The essence of a bad memory that has been supressed for so long that it has begun to damage your mind.");
		}
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = -1;
			item.maxStack = 999;
		}

	}

	public class Nightmare : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The essence of a horrid dream that scarred you for life.");
		}
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = -1;
			item.maxStack = 999;
		}

	}

	public class Sadness : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The essence of your deep sadness.");
		}
		public override void SetDefaults()
		{

			item.value = 0;
			item.rare = -1;
			item.maxStack = 999;
		}

	}
	public class Chemicals : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("An assortment of unknown chemicals used to combine certain objects together.");
		}
		public override void SetDefaults()
		{

			item.value = 10000;
			item.rare = 5;
			item.maxStack = 999;
		}

	}
	public class DarkGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This rough-surfaced crystal is emenating with energy from the depths of an otherworldly evil.");
		}
		public override void SetDefaults()
		{

			item.value = 50000;
			item.rare = 5;
			item.maxStack = 999;
		}

	}
	public class LightGem : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This smooth-surfaced crystal is emenating with energy from the depths of an otherworldly hallow.");
		}
		public override void SetDefaults()
		{

			item.value = 50000;
			item.rare = 5;
			item.maxStack = 999;
		}

	}
	public class SoulOfMidnight : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A soul that emenates constant darkness.");
		}
		public override void SetDefaults()
		{
			item.value = 1000;
			item.rare = 5;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 7);
			recipe.AddIngredient(ItemID.SoulofFright, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class SoulOfTwilight : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A soul that shimmers with the colors of twilight.");
		}
		public override void SetDefaults()
		{
			item.value = 1000;
			item.maxStack = 999;
			item.rare = 5;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TwilightHairDye, 1);
			recipe.AddIngredient(ItemID.SoulofLight, 1);
			recipe.AddIngredient(ItemID.SoulofNight, 1);
			recipe.AddIngredient(ItemID.SoulofFright, 1);
			recipe.AddIngredient(ItemID.SoulofSight, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class Stick : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used in basic crafting.");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 0;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 1);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}

	}
	public class ThickCloud : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A very dense cloud.");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 0;
			item.maxStack = 999;
		}

	}
	public class ThickStick : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Used in slightly less basic crafting.");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 0;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 20);
			recipe.AddIngredient(ModContent.ItemType<Stick>(), 3);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class UniversalFragment : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A fragment of the universe.");
		}
		public override void SetDefaults()
		{
			item.value = 75000;
			item.maxStack = 999;
			item.rare = 10;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FragmentNebula, 2);
			recipe.AddIngredient(ItemID.FragmentVortex, 2);
			recipe.AddIngredient(ItemID.FragmentSolar, 2);
			recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
			recipe.AddIngredient(ItemID.FragmentStardust, 2);
			recipe.AddIngredient(ItemID.LunarBar, 4);
			recipe.AddIngredient(ModContent.ItemType<LightGem>(), 20);
			recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 20);
			recipe.AddTile(TileID.LunarCraftingStation);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class Upgrade : ModItem
	{
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 8;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<GolemSoul>(), 2);
			recipe.AddIngredient(ItemID.ShroomiteBar, 10);
			recipe.AddIngredient(ItemID.SpectreBar, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		

	}
	public class VoidBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Densened power.");
		}
		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 5;
			item.maxStack = 999;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
			recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}
	public class VoidMaterial : ModItem
	{
		public override void SetStaticDefaults()
		{
			
			Tooltip.SetDefault("Black goo from a creature of the void.");
		}

		public override void SetDefaults()
		{
			item.value = 0;
			item.rare = 5;
			item.maxStack = 999;
		}

	}

	public class BladeFragment : ModItem
	{
		public override void SetStaticDefaults()
		{

			Tooltip.SetDefault("A small portion of a living sword.");
		}

		public override void SetDefaults()
		{
			item.value = 200;
			item.rare = 5;
			item.maxStack = 999;
			
		}

	}
	public class VoidStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Voidstone");
			Tooltip.SetDefault("A rock that reaches into the depths of the void.");
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 15;
			item.useTime = 10;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = mod.TileType("VoidStoneTile");
			item.width = 12;
			item.rare = 5;
			item.height = 12;
			item.value = 0;
		}
		 
		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)

			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<VoidMaterial>(), 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

	}

	public class Blaustein : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 10;
			item.useTime = 5;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = mod.TileType("BlausteinTile");
			item.width = 12;
			item.height = 12;
			item.value = 3000;
		}
	}
	public class BlausteinTile : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 559; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 999; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

		   ModTranslation name = CreateMapEntryName();
			name.SetDefault("Blaustein");
			AddMapEntry(new Color(0, 0, 99), name);

			dustType = 84;
			drop = mod.ItemType("Blaustein");
			soundType = SoundID.Tink;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 100;
		}
	}

	public class VoidStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 800; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 99999; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Voidstone");
			AddMapEntry(new Color(0, 0, 00), name);

			dustType = 84;
			drop = mod.ItemType("VoidStone");
			soundType = SoundID.Tink;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 200;
		}
	}









	public class SparklingStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			ItemID.Sets.SortingPriorityMaterials[item.type] = 58;
		}

		public override void SetDefaults()
		{
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTurn = true;
			item.useAnimation = 10;
			item.useTime = 5;
			item.autoReuse = true;
			item.maxStack = 999;
			item.consumable = true;
			item.createTile = mod.TileType("SparklingStoneTile");
			item.width = 12;
			item.height = 12;
			item.value = 30;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)

			var recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.ReflectiveDye, 1);
			recipe.AddIngredient(ItemID.StoneBlock, 500);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 500);
			recipe.AddRecipe();
		}
	}
	public class SparklingStoneTile : ModTile
	{
		public override void SetDefaults()
		{
			TileID.Sets.Ore[Type] = true;
			Main.tileSpelunker[Type] = true; // The tile will be affected by spelunker highlighting
			Main.tileValue[Type] = 1; // Metal Detector value, see https://terraria.gamepedia.com/Metal_Detector
			Main.tileShine2[Type] = true; // Modifies the draw color slightly.
			Main.tileShine[Type] = 60; // How often tiny dust appear off this tile. Larger is less frequently
			Main.tileMergeDirt[Type] = true;
			Main.tileSolid[Type] = true;
			Main.tileBlockLight[Type] = true;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Sparkling stone");
			AddMapEntry(new Color(190, 190, 190), name);

			dustType = 84;
			drop = mod.ItemType("SparklingStone");
			soundType = SoundID.Tink;
			soundStyle = 1;
			//mineResist = 4f;
			minPick = 0;
		}


	}

}
