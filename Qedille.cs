
using Microsoft.Xna.Framework;
using System.ComponentModel;
using System.Media;
using Terraria;
using Terraria.ID;
using Terraria.DataStructures;
using Terraria.ObjectData;
using Terraria.ModLoader;
using Dacern.FriendlyNPC;
using Dacern.Items.Materials;
using static Terraria.ModLoader.ModContent;
using Dacern.Enemies;
using Dacern.Projectiles;
//using Dacern.DacernPlayer;
using Dacern;
using System.Security.Cryptography.X509Certificates;
//using Dacern.misc;

//item.useTurn = true;

namespace Dacern.Items
{

    public class Qedille : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The first item ever created by dacern.");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 1;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 5;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofSight, 1);
            recipe.AddIngredient(ItemID.SoulofMight, 1);
            recipe.AddIngredient(ItemID.SoulofFright, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 30);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Ugxilsch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Tear through your enemies with an overwhelming spray of bullets.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 5000000;
            item.rare = 11;
            item.UseSound = SoundID.Item96;
            item.autoReuse = true;
            item.shoot = 503;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 10 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(90)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FragmentVortex, 100);
            recipe.AddIngredient(ItemID.FragmentSolar, 100);
            recipe.AddIngredient(ItemID.FragmentNebula, 100);
            recipe.AddIngredient(ItemID.FragmentStardust, 100);
            recipe.AddIngredient(ItemID.SDMG, 1);
            recipe.AddIngredient(ItemID.TacticalShotgun, 1);
            recipe.AddIngredient(ItemID.LunarBar, 50);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 3);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PurpleSlimyShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots waves of explosive black bolts.");
        }
        public override void SetDefaults()
        {

            item.damage = 50;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 5000000;
            item.rare = 11;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.noUseGraphic = true;
            item.shoot = ProjectileID.BlackBolt;
            item.shootSpeed = 5f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 7 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class Shard : ModItem
    {

        public virtual void SetDefaults()
        {
            item.damage = 50000;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 50000;
            item.rare = 11;
            item.UseSound = SoundID.Item96;
            item.autoReuse = true;
            item.shoot = 10;
            item.shootSpeed = 10f;
            item.useAmmo = AmmoID.Bullet;
        }


    }

    public class DarkStaff : ModItem
    {
        public virtual void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Qedille"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Destroy your enemies with rapid fire explosive shards.");
        }
        public override void SetDefaults()
        {
            item.damage = 75;
            item.magic = true;
            item.width = 20;
            item.height = 40;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 100000;
            item.rare = 7;
            item.mana = 3;
            item.UseSound = SoundID.Item88;
            item.autoReuse = true;
            item.shoot = 661;
            item.shootSpeed = 10f;
        }





        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 4);
            recipe.AddIngredient(ItemID.LaserRifle, 1);
            recipe.AddIngredient(ItemID.OnyxBlaster, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
                recipe.AddIngredient(ItemID.OnyxBlaster, 1);
                recipe.AddIngredient(ItemID.ChlorophyteBar, 4);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }




    }

    public class OversizedBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Looks lazily created.");
        }
        public override void SetDefaults()

        {


            item.damage = 150;
            item.ranged = true;
            item.width = 200;
            item.height = 200;
            item.useTime = 250;
            item.useAnimation = 250;
            item.crit = 75;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 100;
            item.value = 200000;
            item.rare = 8;
            item.UseSound = SoundID.Item102;
            item.autoReuse = false;
            item.shoot = 1;
            item.shootSpeed = 50f;
            item.useAmmo = AmmoID.Arrow;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 9990);
            recipe.AddIngredient(ModContent.ItemType<CompactBow>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 3);
            recipe.AddIngredient(ItemID.SpectreBar, 20);
            recipe.AddTile(TileID.TinkerersWorkbench);
            recipe.SetResult(this);
            recipe.AddRecipe();

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<CompactBow>(), 1);
                recipe.AddIngredient(ItemID.SpectreBar, 5);
                recipe.AddIngredient(ItemID.WoodenArrow, 1998);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    [AutoloadEquip(EquipType.Head)]
    public class VoidstoneHelm : ModItem
    {
        public virtual void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            Tooltip.SetDefault("Unbelievably broken.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 10;
            item.defense = 30;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.statManaMax2 += 20;
            player.maxMinions++;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 1);
            recipe.AddIngredient(ModContent.ItemType<UniversalFragment>(), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class VoidstonePlate : ModItem
    {
        public virtual void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Voidstone chestplate");
            Tooltip.SetDefault("Unbelievably broken.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 10;
            item.defense = 20;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Venom] = true;
            player.statManaMax2 += 400;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 1);
            recipe.AddIngredient(ModContent.ItemType<UniversalFragment>(), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    [AutoloadEquip(EquipType.Legs)]
    public class VoidstoneLegs : ModItem
    {
        public override void SetStaticDefaults()
        {
            base.SetStaticDefaults();
            DisplayName.SetDefault("Voidstone greaves");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 50000;
            item.rare = 10;
            item.defense = 50;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<UniversalFragment>(), 1);
            recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class StarGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It may deal less damage than the star cannon and take a while for the magic to form, but it shoots multiple projectiles and doesn't take ammo.");
        }
        public override void SetDefaults()
        {

            item.damage = 30;
            item.magic = true;
            item.width = 1;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            item.value = 7500;
            item.rare = 3;
            item.UseSound = SoundID.Item72;
            item.autoReuse = true;
            item.shoot = 12;
            item.shootSpeed = 100f;
            item.mana = 0;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 4;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.StarCannon, 1);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class CommunismGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Blyat");
        }
        public override void SetDefaults()
        {

            item.damage = 500;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 5000000;
            item.rare = 11;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Communism>();
            item.shootSpeed = 50f;
            item.mana = 1;
            item.UseSound = SoundID.Item71;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(50)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class killblast : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You have lost life privaleges.");
        }
        public override void SetDefaults()
        {

            item.damage = 500000;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 150;
            item.useAnimation = 150;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 5000000;
            item.rare = 11;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Deth>();
            item.shootSpeed = 50f;
            item.mana = 100;
            item.UseSound = (SoundID.Item17.WithVolume(5f));
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 30;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class Hellwrath : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fun, but poorly sprited.");
        }
        public override void SetDefaults()
        {

            item.damage = 25;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 7500;
            item.rare = 3;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = 15;
            item.shootSpeed = 25f;
            item.mana = 17;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlowerofFire, 1);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DacernFunItem : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Having a wonderful time!");
        }
        public override void SetDefaults()
        {

            item.damage = 50;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 750000;
            item.rare = -1;
            item.UseSound = SoundID.Item115;
            item.autoReuse = true;
            item.shoot = 132;
            item.shootSpeed = 25f;
            item.mana = 17;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 15 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class Starstorm : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("1 damage, but lives up to its name.");
        }
        public override void SetDefaults()
        {

            item.damage = 1;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 4;
            item.useAnimation = 4;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 7500;
            item.rare = 3;
            item.UseSound = SoundID.Item32;
            item.autoReuse = true;
            item.shoot = 9;
            item.shootSpeed = 25f;
            item.mana = 1;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 20 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    //  public class LaserSword : ModItem
    // {

    //     public override void SetDefaults()
    //    {
    //
    //        item.damage = 100;
    //        item.ranged = true;
    //         item.width = 100;
    //       item.height = 50;
    //       item.useStyle = ItemUseStyleID.HoldingOut;
    //        item.useTime = 7;
    //        item.useAnimation = 7;
    //       item.useStyle = 5;
    //       item.noMelee = true;
    //       item.knockBack = 4;
    //       item.value = 5000000;
    //      item.rare = 11;
    //      item.autoReuse = true;
    //       item.shoot = ModContent.ProjectileType<("Laser");
    //         item.shootSpeed = 50f;
    //         item.mana = 5;
    //         item.UseSound = SoundID.Item12;
    //    }

    //   public override void AddRecipes()
    //   {
    //       ModRecipe recipe = new ModRecipe(mod);
    //       recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
    //        recipe.AddIngredient(ItemID.FragmentNebula, 10);
    //        recipe.AddTile(TileID.LunarCraftingStation);

    //         recipe.SetResult(this);
    //         recipe.AddRecipe();
    //    }
    //}

    public class SlimeSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Sticky.");
        }

        public override void SetDefaults()
        {
            item.damage = 27;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = 5000;
            item.rare = 2;
            item.UseSound = SoundID.Item7;
            item.autoReuse = false;
            item.shoot = 440;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SlimeBlock, 50);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.AddIngredient(ItemID.PinkGel, 5);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Solidifier);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DemonWrath : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Five times the scythes is five times the fun!");
        }
        public override void SetDefaults()
        {

            item.damage = 35;
            item.magic = true;
            item.width = 28;
            item.height = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 3;
            item.UseSound = SoundID.Item32;
            item.autoReuse = true;
            item.shoot = 45;
            item.shootSpeed = 25f;
            item.mana = 14;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemonScythe, 3);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
                recipe.AddIngredient(ItemID.DemonScythe, 2);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }

    }

    public class AverageFlintlock : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Just an upgraded flintlock pistol.");
        }
        public override void SetDefaults()
        {

            item.damage = 20;
            item.ranged = true;
            item.width = 36;
            item.height = 22;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 16;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 5000000;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = false;
            item.shoot = ModContent.ProjectileType<GunGun>();
            item.shootSpeed = 5f;
            item.mana = 0;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlintlockPistol, 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Shredder : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Destroys your world. Not for combat. You have been warned.");
        }
        public override void SetDefaults()
        {

            item.damage = 0;
            item.magic = true;
            item.width = 36;
            item.height = 22;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 341;
            item.shootSpeed = 30f;
            item.mana = 0;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 10 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FireworksLauncher, 1);
            recipe.AddIngredient(ItemID.RocketIV, 250);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Coin : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Get rich.");
        }
        public override void SetDefaults()
        {

            item.damage = 0;
            item.magic = true;
            item.width = 140;
            item.height = 160;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 500;
            item.useAnimation = 19;
            item.useStyle = 2;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0;
            item.rare = 11;
            item.UseSound = SoundID.Item16;
            item.autoReuse = false;
            item.shoot = 518;
            item.shootSpeed = 25f;
            item.mana = 400;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 25;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 10);
            recipe.AddIngredient(ItemID.CoinGun, 1);
            recipe.AddIngredient(ItemID.PlatinumCoin, 100);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DaybreakTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Having trouble aiming? Good.");

        }
        public override void SetDefaults()
        {

            item.damage = 150;
            item.melee = true;
            item.width = 28;
            item.height = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 16;
            item.useAnimation = 16;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 100000;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = 636;
            item.shootSpeed = 20f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 10 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(180)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DayBreak, 4);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BladeOfTheGiants : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A huge sword used by baby giants.");
        }

        public override void SetDefaults()
        {
            item.damage = 400;
            item.melee = true;
            item.width = 100;
            item.height = 100;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 100000;
            item.rare = 5;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.BreakerBlade, 1);
                recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 3);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 5);
                recipe.AddIngredient(ModContent.ItemType<BladeFragment>(), 40);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class Bladestorm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rain swords upon your opponent.");
        }
        public override void SetDefaults()
        {

            item.damage = 50;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 20;      //The size of the width of the hitbox in pixels.
            item.height = 17;      //The size of the height of the hitbox in pixels.
            item.useTime = 5;     //How fast the Weapon is used.
            item.useAnimation = 5;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 3;  //The knockback stat of your Weapon.      
            item.value = 1000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 3;//How many mana this weapon use
            item.UseSound = SoundID.Item8; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.

            item.shoot = ModContent.ProjectileType<Bladecast>();
            item.shootSpeed = 40f;    //This defines the projectile speed when shoot
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, 0, 10, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<RainCloud>(), 1);
                recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 3);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 5);
                recipe.AddIngredient(ModContent.ItemType<BladeFragment>(), 40);
                recipe.AddTile(TileID.Bookcases);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
    public class Bladecaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A book that summons swords that stick to your cursor.");
        }

        public override void SetDefaults()
        {
            item.damage = 65;
            item.magic = true;
            item.mana = 5;
            item.width = 26;
            item.height = 26;
            item.useTime = 5;
            item.autoReuse = true;
            item.useAnimation = 5;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.noMelee = true;
            item.channel = true; //Channel so that you can held the weapon [Important]
            item.knockBack = 1;
            item.value = Item.sellPrice(silver: 50);
            item.rare = ItemRarityID.Cyan;
            item.UseSound = SoundID.Item9;
            item.shoot = ModContent.ProjectileType<Bladecast>();
            item.shootSpeed = 10f;
        }

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SpellTome, 1);
                recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 3);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 5);
                recipe.AddIngredient(ModContent.ItemType<BladeFragment>(), 40);
                recipe.AddTile(TileID.Bookcases);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }
    public class RapidBoltTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Magical.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.magic = true;
            item.width = 28;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 11;
            item.UseSound = SoundID.Item78;
            item.autoReuse = true;
            item.shoot = 459;
            item.shootSpeed = 30f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 5);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddTile(TileID.LunarCraftingStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class TornadoStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Don't tell anyone, but you just put the Tomes together and covered it with painted cardboard.");
        }
        public override void SetDefaults()
        {

            item.damage = 64;
            item.magic = true;
            item.width = 96;
            item.height = 96;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 10000;
            item.rare = 11;
            item.UseSound = SoundID.Item72;
            item.autoReuse = true;
            item.shoot = 704;
            item.shootSpeed = 35f;
            item.mana = 20;
            item.reuseDelay = 14;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BookStaff, 4);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class TomeOfUndyingFury : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoot out 13 projectiles in a high power blast of fury to eliminate all enemies standing in your way.");
        }
        public override void SetDefaults()
        {
            item.damage = 575;
            item.magic = true;
            item.mana = 10;
            item.width = 28;
            item.height = 32;
            item.useTime = 125;
            item.useAnimation = 125;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 3000000;
            item.rare = 11;
            item.UseSound = SoundID.Item88;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 85;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.WaterBolt, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Meowmere, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.VenomArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MagnetSphereBall, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Stynger, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.VampireKnife, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ChlorophyteBullet, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MolotovCocktail, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Skull, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BoulderStaffOfEarth, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DeathSickle, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ToxicFlask, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.LightDisc, damage, knockBack, player.whoAmI);
            return true;
        }










        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBolt, 1);
            recipe.AddIngredient(ItemID.MagnetSphere, 1);
            recipe.AddIngredient(ItemID.Stynger, 1);
            recipe.AddIngredient(ItemID.VampireKnives, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBullet, 1);
            recipe.AddIngredient(ItemID.MolotovCocktail, 1);
            recipe.AddIngredient(ItemID.BookofSkulls, 1);
            recipe.AddIngredient(ItemID.StaffofEarth, 1);
            recipe.AddIngredient(ItemID.DeathSickle, 1);
            recipe.AddIngredient(ItemID.ToxicFlask, 1);
            recipe.AddIngredient(ItemID.LightDisc, 1);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 1);
            recipe.AddIngredient(ItemID.Meowmere, 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class GameBreaker : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Lags your computer.");
        }
        public override void SetDefaults()
        {

            item.damage = 1;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 500;
            item.useAnimation = 500;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = -1;
            item.UseSound = SoundID.Item78;
            item.autoReuse = true;
            item.shoot = 451;
            item.shootSpeed = 30f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 999;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class GameDestroyer : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Lags your computer. A lot.");
        }
        public override void SetDefaults()
        {

            item.damage = 500;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 500;
            item.useAnimation = 500;
            item.useStyle = 1;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 0;
            item.rare = -1;
            item.UseSound = SoundID.Item78;
            item.autoReuse = true;
            item.shoot = 466;
            item.shootSpeed = 1f;
            item.mana = 200;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 999999;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class FamiliarBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oddly familiar...");
        }
        public override void SetDefaults()

        {


            item.damage = 40;
            item.ranged = true;
            item.width = 60;
            item.height = 60;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 15;
            item.value = 200000;
            item.rare = 8;
            item.UseSound = SoundID.Item61;
            item.autoReuse = false;
            item.shoot = ModContent.ProjectileType<FamiliarArrow>();
            item.shootSpeed = 50f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CobaltBar, 10);
            recipe.AddIngredient(ItemID.WoodenBow, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }

    public class OverchargedOversizedBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's just a red oversized bo- HOLY...");
        }
        public override void SetDefaults()

        {


            item.damage = 100;
            item.ranged = true;
            item.width = 200;
            item.height = 200;
            item.useTime = 2;
            item.useAnimation = 2;
            item.crit = 75;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 100;
            item.value = 200000;
            item.rare = 8;
            item.UseSound = SoundID.Item102;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 50f;
            item.useAmmo = AmmoID.Arrow;

        }


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 5);
            recipe.AddIngredient(ModContent.ItemType<OverchargedBow>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 25);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 50);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 50);
            recipe.AddIngredient(ModContent.ItemType<OversizedBow>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


        }
    }

    public class LaunchStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Knockback's pretty cool.");
        }
        public override void SetDefaults()
        {
            item.damage = 5;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = false;
            item.knockBack = 2000;
            item.value = 10000;
            item.rare = 4;
            item.mana = 15;
            item.UseSound = SoundID.Item101;
            item.autoReuse = false;
            item.shoot = 494;
            item.shootSpeed = 5f;
        }





        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalVileShard, 1);
            recipe.AddIngredient(ItemID.PalladiumBar, 10);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }




    }

    public class TestGun1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Test item.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0;
            item.rare = 0;
            item.UseSound = SoundID.Item118;
            item.autoReuse = true;
            item.shootSpeed = 100f;
            item.shoot = ModContent.ProjectileType<Proj1>();
            item.mana = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class TestGun2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Powerful test item.");
        }
        public override void SetDefaults()
        {

            item.damage = 500;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0;
            item.rare = 0;
            item.UseSound = SoundID.Item118;
            item.autoReuse = true;
            item.shootSpeed = 100f;
            item.shoot = ModContent.ProjectileType<Proj1>();
            item.mana = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class TestGun3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Ultra powerful test item.");
        }
        public override void SetDefaults()
        {

            item.damage = 1000;
            item.ranged = true;
            item.width = 42;
            item.height = 30;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 0;
            item.rare = 0;
            item.UseSound = SoundID.Item118;
            item.autoReuse = true;
            item.shootSpeed = 100f;
            item.shoot = ModContent.ProjectileType<Proj1>();
            item.mana = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 10;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class LuminiteShortsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throughout your journey, you have forgotten how to use a shortsword.");
        }

        public override void SetDefaults()
        {
            item.damage = 425;
            item.melee = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 3;
            item.knockBack = 4;
            item.value = 300000;
            item.rare = 10;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LunarBar, 3);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class LongSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("will knock enemies that are directly above and below you far back. Works great as a barrier, and texture is located incorrectly.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 1;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.height = 9854;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 3;
            item.knockBack = 30;
            item.value = 3000;
            item.rare = 5;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.BreathingReed, 1);
            recipe.AddIngredient(ItemID.BreakerBlade, 1);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PhoenixTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oh, cool, I'm deaf.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 28;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 700;
            item.shootSpeed = 30f;
            item.mana = 40;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 50;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class ShockwaveTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots out a large shockwave.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 684;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DefenderMedal, 35);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ShadowThrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("As dark as the void");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 30;
            item.height = 26;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage = 75;
            item.rare = ItemRarityID.White;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.shoot = ModContent.ProjectileType<Shadowyoyo>();
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.AddIngredient(ItemID.Obsidian, 50);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class SpiritYoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots lost souls at your cursor");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 30;
            item.height = 26;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 0.5f;
            item.damage = 95;
            item.rare = ItemRarityID.Red;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.shoot = ModContent.ProjectileType<Ghostyoyo>();
        }
    }
    public class SpaceGodsYoyo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots lasers at your cursor");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 30;
            item.height = 26;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2.5f;
            item.damage =235;
            item.rare = ItemRarityID.Cyan;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = 10000;
            item.shoot = ModContent.ProjectileType<Spaceyoyo>();
        }
    }

    public class PyroStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("For pyromaniacs.");
        }
        public override void SetDefaults()
        {
            item.damage = 75;
            item.magic = true;
            item.mana = 0;
            item.width = 100;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 3000000;
            item.rare = 11;
            item.UseSound = SoundID.Item88;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 85;

        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Flamethrower, 3);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Flamethrower, 1);
                recipe.AddIngredient(ItemID.Wood, 100);
                recipe.AddTile(TileID.Anvils);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
    }

    public class GreenBlast : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Vortex explosion's better.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.magic = true;
            item.width = 32;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 11;
            item.UseSound = SoundID.Item107;
            item.autoReuse = true;
            item.shoot = 604;
            item.shootSpeed = 50f;
            item.mana = 0;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Terrarian, 1);
            recipe.AddIngredient(ItemID.RedRocket, 500);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class VortexExplosion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("kablewies.");
        }
        public override void SetDefaults()
        {

            item.damage = 80;
            item.magic = true;
            item.width = 66;
            item.height = 28;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 20000;
            item.rare = 11;
            item.UseSound = SoundID.Item78;
            item.autoReuse = true;
            item.shoot = 616;
            item.shootSpeed = 50f;
            item.mana = 0;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.VortexBeater, 1);
            recipe.AddIngredient(ItemID.LunarOre, 1);
            recipe.AddIngredient(ItemID.RedRocket, 500);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 3);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 5);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 5);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BoxingGlove : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Right click to quick jab!");
        }

        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 32;
            item.useAnimation = 10;
            item.value = 30000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.damage = 50;
            item.width = 40;
            item.useStyle = 2;
            item.knockBack = 6;
        }


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 4;
                item.knockBack = 5;
                item.width = 10;
                item.useTime = 5;
                item.damage = 50;
            }
            else
            {
                item.useStyle = 2;
                item.knockBack = 0;
                item.width = 10;
                item.useTime = 24;
                item.damage = 100;
                item.autoReuse = false;
            }
            return base.CanUseItem(player);
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TitanGlove, 1);
            recipe.AddIngredient(ItemID.WarriorEmblem, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DirtyDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Right click to autoswing with less damage and knockback.");
        }

        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 10;
            item.useAnimation = 10;
            item.value = 0;
            item.rare = 0;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.damage = 5;
            item.useStyle = 1;
            item.knockBack = 1;
            item.width = 10;
            item.useTime = 10;
        }


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 1;
                item.knockBack = 1;
                item.damage = 3;
            }
            else
            {
                item.useStyle = 4;
                item.knockBack = 10;
                item.damage = 6;
            }
            return base.CanUseItem(player);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DirtyDaggerPlus : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Right click to autoswing with less damage and knockback.");
        }

        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 100;
            item.useAnimation = 10;
            item.value = 0;
            item.rare = 8;
            item.useStyle = 1;
            item.knockBack = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.damage = 250;
            item.width = 100;
            item.useTime = 10;
            item.shoot = ModContent.ProjectileType<Dirt>();
            item.shootSpeed = 30f;
        }


        public override bool AltFunctionUse(Player player)
        {
            return true;
        }

        public override bool CanUseItem(Player player)
        {
            if (player.altFunctionUse == 2)
            {
                item.useStyle = 1;
                item.knockBack = 10;
                item.damage = 200;
            }
            else
            {
                item.useStyle = 4;
                item.knockBack = 19;
                item.damage = 250;
            }
            return base.CanUseItem(player);
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DirtyDagger>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class TripleInfernoFork : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It looks so stupid.");
        }
        public override void SetDefaults()
        {

            item.damage = 80;
            item.magic = true;
            item.width = 60;
            item.height = 60;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 19;
            item.useAnimation = 19;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 180000;
            item.rare = 9;
            item.UseSound = SoundID.Item45;
            item.autoReuse = true;
            item.shoot = 295;
            item.shootSpeed = 25f;
            item.mana = 20;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.InfernoFork, 3);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class NonupleInfernoFork : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Now that's taking it too far.");
        }
        public override void SetDefaults()
        {

            item.damage = 120;
            item.magic = true;
            item.width = 180;
            item.height = 180;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 15;
            item.value = 740000;
            item.rare = 10;
            item.UseSound = SoundID.Item45;
            item.autoReuse = true;
            item.shoot = 295;
            item.shootSpeed = 35f;
            item.mana = 30;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 10;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<TripleInfernoFork>(), 3);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Merchant : ModItem
    {

        public override void SetStaticDefaults()
        {




            Tooltip.SetDefault("MERCHANT YOYO");

            // These are all related to gamepad controls and don't seem to affect anything else
            ItemID.Sets.Yoyo[item.type] = true;
            ItemID.Sets.GamepadExtraRange[item.type] = 15;
            ItemID.Sets.GamepadSmartQuickReach[item.type] = true;
        }

        public override void SetDefaults()
        {
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.width = 89;
            item.crit = 30;
            item.height = 150;
            item.useAnimation = 25;
            item.useTime = 25;
            item.shootSpeed = 16f;
            item.knockBack = 2f;
            item.damage = 120;
            item.rare = ItemRarityID.White;

            item.melee = true;
            item.channel = true;
            item.noMelee = true;
            item.noUseGraphic = true;

            item.UseSound = SoundID.Item1;
            item.value = 100000;
            item.shoot = ModContent.ProjectileType<Merchantyoyo>();
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GuideVoodooDoll, 1);
            recipe.AddIngredient(ItemID.GoldCoin, 50);
            recipe.AddIngredient(ItemID.Rope, 100);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class UnstableSpellbook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("tons of damage, and a chance to instantly kill you.");
        }
        public override void SetDefaults()
        {
            item.damage = 2500;
            item.magic = true;
            item.mana = 10;
            item.width = 28;
            item.height = 32;
            item.useTime = 100;
            item.useAnimation = 100;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = 30000;
            item.crit = 50;
            item.rare = 11;
            item.UseSound = SoundID.Item47;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 10;


        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            type = Main.rand.Next(new int[] { ProjectileID.VenomArrow, ProjectileID.VampireKnife, ProjectileID.WaterBolt, ProjectileID.PhantasmArrow,
                ProjectileID.GoldenBullet, ProjectileID.WaterBolt, ProjectileID.PoisonedKnife, ProjectileID.QuarterNote,
                  ProjectileID.Flames, ProjectileID.Boulder, ProjectileID.LightDisc, ProjectileID.ChlorophyteOrb, ProjectileID.MagnetSphereBall,
                 ProjectileID.DeathSickle, ProjectileID.FlamingScythe, ProjectileID.NorthPoleSpear, ProjectileID.PulseBolt, ProjectileID.MolotovCocktail,
                  ProjectileID.Flairon, ProjectileID.ElectrosphereMissile, ProjectileID.CursedDart, ProjectileID.Daybreak,
                ProjectileID.ChlorophyteBullet, ProjectileID.Meowmere,  });
            return true;
        }












        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 1);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BaseballBat : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Go long! Touchdown! Other... baseball realted things. Wait, those aren't for baseball?");
        }

        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 120;
            item.value = 10000000;
            item.useAnimation = 3;
            item.crit = 100;
            item.rare = 11;
            item.useStyle = 1;
            item.knockBack = 0;
            item.UseSound = SoundID.Item118;
            item.autoReuse = true;
            item.damage = 9999999;
            item.width = 120;
            item.useTime = 5;
            item.shoot = ModContent.ProjectileType<Baseball>();
            item.shootSpeed = 200f;
        }


    }

    public class OldMan : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An interesting weapon, to say the least.");
        }

        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 29;
            item.value = 10000000;
            item.useAnimation = 10;
            item.rare = 11;
            item.useStyle = 4;
            item.knockBack = 0;
            item.UseSound = SoundID.Item16;
            item.autoReuse = false;
            item.damage = 60;
            item.width = 40;
            item.useTime = 50;
            item.shoot = 228;
            item.shootSpeed = 20f;
        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddIngredient(ItemID.WhoopieCushion, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BowlOfAlphabetSoup : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The letters are spelling something! It says NDOHEQCXL.");
        }
        public override void SetDefaults()
        {
            item.damage = 7;
            item.melee = true;
            item.width = 32;
            item.height = 14;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 5;
            item.crit = 17;
            item.value = 1000;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
            item.shootSpeed = 25f;
            item.shoot = ModContent.ProjectileType<LetterO>();





        }



        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, Main.rand.Next(new int[] { ModContent.ProjectileType<LetterA>(), ModContent.ProjectileType<LetterB>(), ModContent.ProjectileType<LetterC>(),
                ModContent.ProjectileType<LetterX>(),ModContent.ProjectileType<LetterT>(),ModContent.ProjectileType<LetterP>(),ModContent.ProjectileType<LetterM>(),ModContent.ProjectileType<LetterJ>(),ModContent.ProjectileType<LetterG>(),ModContent.ProjectileType<LetterD>(),
                ModContent.ProjectileType<LetterY>(),ModContent.ProjectileType<LetterU>(),ModContent.ProjectileType<LetterQ>(),ModContent.ProjectileType<LetterN>(),ModContent.ProjectileType<LetterK>(),ModContent.ProjectileType<LetterH>(),ModContent.ProjectileType<LetterE>(),
                ModContent.ProjectileType<LetterZ>(),ModContent.ProjectileType<LetterV>(),ModContent.ProjectileType<LetterR>(),ModContent.ProjectileType<LetterO>(),ModContent.ProjectileType<LetterL>(),ModContent.ProjectileType<LetterI>(),ModContent.ProjectileType<LetterF>(),
                ModContent.ProjectileType<LetterW>(),ModContent.ProjectileType<LetterS>()}), damage, knockBack, player.whoAmI);
            }
            return false;
        }

















        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bowl, 1);
            recipe.AddIngredient(ItemID.Mushroom, 15);
            recipe.AddIngredient(ItemID.Book, 5);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class FirebloomSpellbook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("summons blasts of fire.");
        }
        public override void SetDefaults()
        {
            item.damage = 500;
            item.magic = true;
            item.mana = 10;
            item.width = 28;
            item.height = 32;
            item.useTime = 75;
            item.useAnimation = 75;
            item.useStyle = 5;
            item.knockBack = 10;
            item.value = 30000;
            item.crit = 0;
            item.rare = 8;
            item.UseSound = SoundID.Item88;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 85;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;


        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ItemID.FlowerofFire, 1);
            recipe.AddIngredient(ItemID.Sunflower, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class CryoStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Do you wanna see something OVERPOWERED?.");
        }
        public override void SetDefaults()
        {
            item.damage = 90;
            item.magic = true;
            item.mana = 0;
            item.width = 100;
            item.height = 32;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 25;
            item.value = 30000;
            item.rare = 5;
            item.UseSound = SoundID.Item30;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.crit = 0;
            item.shoot = 359;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FlowerofFrost, 1);
            recipe.AddIngredient(ItemID.FrostStaff, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Crossbow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a high velocity arrow.");
        }
        public override void SetDefaults()

        {


            item.damage = 160;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 100;
            item.useAnimation = 100;
            item.useStyle = 5;
            item.crit = 80;
            item.noMelee = true;
            item.knockBack = 50;
            item.value = 2000;
            item.rare = 3;
            item.UseSound = SoundID.Item102;
            item.autoReuse = false;
            item.shoot = 117;
            item.shootSpeed = 400f;
            item.mana = 0;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenBow, 1);
            recipe.AddIngredient(ItemID.HermesBoots, 1);
            recipe.AddIngredient(ItemID.WhiteString, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    public class SuperflameTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("rain flames upon your opponent.");
        }
        public override void SetDefaults()
        {

            item.damage = 75;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 20;     //How fast the Weapon is used.
            item.useAnimation = 20;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 5;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 5;//How many mana this weapon use
            item.UseSound = SoundID.Item21; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 95;  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 10f;    //This defines the projectile speed when shoot
            item.crit = 8;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CursedFlames, 1);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class RainCloud : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Now the rain shall never go away.");
        }
        public override void SetDefaults()
        {

            item.damage = 45;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 20;      //The size of the width of the hitbox in pixels.
            item.height = 17;      //The size of the height of the hitbox in pixels.
            item.useTime = 5;     //How fast the Weapon is used.
            item.useAnimation = 5;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 5;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 3;//How many mana this weapon use
            item.UseSound = SoundID.Item8; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 239;  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 40f;    //This defines the projectile speed when shoot
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, 0, 10, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cloud, 10);
            recipe.AddIngredient(ItemID.NimbusRod, 1);
            recipe.AddIngredient(ItemID.RainCloud, 25);
            recipe.AddIngredient(ModContent.ItemType<ThickCloud>(), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    /* public class CondensedDarkness : ModItem
     {
         public override void SetStaticDefaults()
         {
             Tooltip.SetDefault("Summons the supreme void.");
         }
         public override void SetDefaults()
         {


             item.width = 20;      //The size of the width of the hitbox in pixels.
             item.height = 17;      //The size of the height of the hitbox in pixels.
             item.useTime = 30;     //How fast the Weapon is used.
             item.useAnimation = 30;    //How long the Weapon is used for.
             item.useStyle = 3;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
             item.noMelee = true;   //The knockback stat of your Weapon.      
             item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
             item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
             item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again
             item.consumable = true;
         }
         public override bool UseItem(Player player)
         {
             NPC.SpawnOnPlayer(player.whoAmI, mod.NPCType("SupremeVoid"));
             Main.PlaySound(15, (int)player.position.X, (int)player.position.Y, 0);
         }

         public override void AddRecipes()
         {
             ModRecipe recipe = new ModRecipe(mod);
             recipe.AddIngredient(ModContent.ItemType<SoulofTwilight>(), 3);
             recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
             recipe.AddIngredient(ModContent.ItemType<SoulofMidnight>(), 10);
             recipe.AddTile(TileID.Anvils);
             recipe.SetResult(this);
             recipe.AddRecipe();
         }
     }*/

    public class InfusedLesserHealingPotion : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 1;
            item.healLife = 100; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = 10000;
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = 100;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LesserHealingPotion, 5);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 1);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }

    public class InfusedHealingPotion : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 26;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 2;
            item.healLife = 200; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = 1000;
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = 200;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.HealingPotion, 5);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }

    public class InfusedGreaterHealingPotion : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 28;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 5;
            item.healLife = 300; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = 100000;
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = 300;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GreaterHealingPotion, 5);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }

    public class InfusedSuperHealingPotion : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 10;
            item.healLife = 400; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = 1000000;
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = 400;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuperHealingPotion, 5);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 1);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }

    public class GrandmastersHealingPotion : ModItem
    {

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 30;
            item.useStyle = ItemUseStyleID.EatingUsing;
            item.useAnimation = 17;
            item.useTime = 17;
            item.useTurn = true;
            item.UseSound = SoundID.Item3;
            item.maxStack = 30;
            item.consumable = true;
            item.rare = 9;
            item.healLife = 50000; // While we change the actual healing value in GetHealLife, item.healLife still needs to be higher than 0 for the item to be considered a healing item
            item.potion = true; // Makes it so this item applies potion sickness on use and allows it to be used with quick heal
            item.value = 1000000;
        }

        public override void GetHealLife(Player player, bool quickHeal, ref int healValue)
        {
            // Make the item heal half the player's max health normally, or one fourth if used with quick heal
            healValue = 50000;
        }
    }

    public class VoidEliminator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Great for those pesky void creatures.");
        }
        public override void SetDefaults()
        {

            item.damage = 1;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.crit = 100;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 25000000;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 14;
            item.shootSpeed = 70f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 20 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Megashark, 1);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 5);
            recipe.AddIngredient(ModContent.ItemType<SoulOfMidnight>(), 7);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class BlockShot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots streams of mud.");
        }
        public override void SetDefaults()
        {
            item.damage = 0;
            item.magic = true;
            item.mana = 2;
            item.width = 28;
            item.height = 32;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = SoundID.Item47;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 10;


        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            type = Main.rand.Next(new int[] { ProjectileID.MudBall });
            return true;


        }








        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MudBlock, 1998);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class EnergyStorageCapsule : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Imagine how many phones this capsule could charge.");
        }
        public override void SetDefaults()
        {

            item.damage = 75;
            item.magic = true;
            item.width = 64;
            item.mana = 5;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 50000;
            item.rare = 8;
            item.UseSound = SoundID.Item93;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<UnleashedEnergy>();
            item.shootSpeed = 30f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.InfluxWaver, 2);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 2);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class IronTomahawk : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throw a powerful iron tomahawk.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 10f;
            item.damage = 20;
            item.knockBack = 5f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.crit = 20;
            item.maxStack = 999;
            item.rare = 1;

            item.consumable = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.value = 100;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<IronTomahawkp>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 2);
            recipe.AddIngredient(ItemID.Cobweb, 10);
            recipe.AddIngredient(ModContent.ItemType<Stick>(), 20);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }

    public class LeadTomahawk : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throw a tomahawk that can cause lead poisoning.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 10f;
            item.damage = 20;
            item.knockBack = 3f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.rare = 1;

            item.consumable = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.value = 100;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<LeadTomahawkp>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LeadBar, 2);
            recipe.AddIngredient(ItemID.Cobweb, 10);
            recipe.AddIngredient(ModContent.ItemType<Stick>(), 20);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this, 20);
            recipe.AddRecipe();
        }
    }

    /*public class VoidPotion : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Regenerates your health at increadible speeds.");
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item3;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 30;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = 500;
            item.rare = 1;
            item.buffType = mod.BuffType("PowerOfDarkness");    //this is where you put your Buff name
            item.buffTime = 2000;    //this is the buff duration        20000 = 6 min
            return;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ModContent.ItemType<VoidMaterial>(), 14);
            recipe.AddTile(TileID.AlchemyTable);

            recipe.SetResult(this, 2);
            recipe.AddRecipe();
        }
    }*/


    public class Yekz0al : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Uppercut! emphesis on the cut.");
        }

        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 64;
            item.height = 10;
            item.useTime = 50;
            item.useAnimation = 35;
            item.useStyle = 2;
            item.knockBack = 30;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrimtaneBar, 5);
            recipe.AddIngredient(ItemID.TissueSample, 5);
            recipe.AddIngredient(ItemID.BloodButcherer, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Yekz0el : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Uppercut! emphesis on the cut.");
        }


        public override void SetDefaults()
        {
            item.damage = 60;
            item.melee = true;
            item.width = 64;
            item.height = 10;
            item.useTime = 50;
            item.useAnimation = 35;
            item.useStyle = 2;
            item.knockBack = 30;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DemoniteBar, 5);
            recipe.AddIngredient(ItemID.ShadowScale, 5);
            recipe.AddIngredient(ItemID.LightsBane, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ExceptionallyLongStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It is very long. A great choice as a starter's item.");
        }


        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 240;
            item.height = 140;
            item.useTime = 60;
            item.useAnimation = 50;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 0;
            item.rare = 1;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Stick>(), 50);
            recipe.AddIngredient(ItemID.Gel, 15);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Slingshot : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a rock.");
        }

        public override void SetDefaults()

        {


            item.damage = 10;
            item.ranged = true;
            item.width = 20;
            item.height = 33;
            item.useTime = 25;
            item.useAnimation = 25;
            item.crit = 13;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 200;
            item.rare = 1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shoot = ModContent.ProjectileType<StoneProj>();
            item.shootSpeed = 25f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Cobweb, 3);
            recipe.AddIngredient(ModContent.ItemType<Stick>(), 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }


    }

    public class FieryLandscapeCrate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This crate is fished up in lava near the beach. Opening in hardmode can give you useful items.");
        }

        public override void SetDefaults()
        {

            item.maxStack = 999;     //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once opened
            item.width = 34;  //The size in width of the sprite in pixels.
            item.height = 34;    //The size in height of the sprite in pixels.      
            item.rare = 4; //The color the title of your Weapon when hovering over it ingame  
            item.useAnimation = 10; //How long the item is used for.
            item.useTime = 10;  //How fast the item is used.
            item.useStyle = 1; //The way your item will be used, 1 is the regular sword swing for example


        }
        public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }

        public override void RightClick(Player player)  //this make so when you right click this item, then one of these items will drop
        {


            if (Main.hardMode) // if it's hardmode this itams will drop  
            {
                int Choose = Main.rand.Next(4);      //so there are 5 items to choose from, but only one will drop  ,  if you want to add more drops change the num 5 with how many items you want and below add another  if (Choose == number)      
                if (Choose == 0)                                                  // 1 item
                {
                    player.QuickSpawnItem(mod.ItemType("FlameSword")); //this is an example of how to add a modded item, change customSentryItem with your modded item name
                }
                if (Choose == 1)                                                    //2 item
                {
                    player.QuickSpawnItem(mod.ItemType("FireblastTome"));
                }
                if (Choose == 2)                                                   // 3 item
                {
                    player.QuickSpawnItem(mod.ItemType("FlamebiterBow"));
                }
                if (Choose == 3)                                                   // 4 item
                {
                    player.QuickSpawnItem(mod.ItemType("HeavyFireball"), 100);
                }
                //if you wnat to add more then add if (Choose == 5) etc.

                //and these are items that will drop 100% + the one itam from the top
                player.QuickSpawnItem(ItemID.SilverCoin, Main.rand.Next(50, 200));        //this is an example of how to add a vanilla terraria itam, Change ItemID.GoldCoin with what item u want

            }
            else        //else if it's prehard mode then only this items will drop
            {

                player.QuickSpawnItem(mod.ItemType("CopperCoin"));




            }
        }
    }

    public class FlameSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("shoots a fireball.");
        }


        public override void SetDefaults()
        {

            item.melee = true;
            item.height = 64;
            item.value = 1000;
            item.useAnimation = 10;
            item.crit = 10;
            item.rare = 4;
            item.useStyle = 1;
            item.reuseDelay = 14;
            item.knockBack = 5;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.damage = 45;
            item.width = 64;
            item.useTime = 10;
            item.shoot = 15;
            item.shootSpeed = 30f;
        }



    }

    public class FireblastTome : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("thicc fireball.");
        }


        public override void SetDefaults()
        {

            item.magic = true;
            item.height = 73;
            item.value = 1000;
            item.mana = 10;
            item.useAnimation = 40;
            item.crit = 0;
            item.rare = 4;
            item.useStyle = 5;
            item.knockBack = 0;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.damage = 35;
            item.width = 73;
            item.useTime = 40;
            item.shoot = 15;
            item.shootSpeed = 70f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < 17; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (16))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }


    }

    public class FlamebiterBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Converts wooden arrows into a special arrow. Also can't seem to get positioned correctly.");
        }

        public override void SetDefaults()

        {


            item.damage = 80;
            item.ranged = true;
            item.width = 28;
            item.height = 46;
            item.useTime = 35;
            item.useAnimation = 35;
            item.useStyle = 35;
            item.noMelee = true;
            item.crit = 33;
            item.knockBack = 10;
            item.value = 2000;

            item.rare = 4;
            item.UseSound = SoundID.Item102;
            item.autoReuse = false;
            item.shoot = ModContent.ProjectileType<Hellarrow>();
            item.shootSpeed = 75f;


        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (type == ProjectileID.WoodenArrowFriendly) // or ProjectileID.WoodenArrowFriendly
            {
                type = ModContent.ProjectileType<Hellarrow>(); // or ProjectileID.FireArrow;
            }
            return true; // return true to allow tmodloader to call Projectile.NewProjectile as normal
        }


    }

    public class HeavyFireball : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Logic? What's that?");
        }

        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 15f;
            item.damage = 45;
            item.knockBack = 2f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.crit = 5;
            item.maxStack = 999;
            item.rare = 4;

            item.consumable = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.value = 25;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<Hfireball>();
        }
    }

    public class UltrabrightOrb : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Legend says it once made a whole city blind. Legend wasn't a very smart man. ");
        }

        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 15f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 30;
            item.height = 30;
            item.maxStack = 999;
            item.rare = 2;

            item.consumable = true;
            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.thrown = true;

            item.UseSound = SoundID.Item1;
            item.value = 25;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<LightOrb>();
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.UltrabrightTorch, 5);
            recipe.AddIngredient(ItemID.DiamondGemsparkBlock, 20);
            recipe.AddTile(TileID.AlchemyTable);

            recipe.SetResult(this, 10);
            recipe.AddRecipe();
        }
    }

    public class DarkRepulserAndElucidator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Broken lol.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 35f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 25;
            item.useTime = 25;
            item.width = 64;
            item.height = 64;
            item.maxStack = 1;
            item.rare = 11;
            item.consumable = false;
            item.noUseGraphic = false;
            item.noMelee = false;
            item.autoReuse = true;

            item.UseSound = SoundID.Item1;
            item.value = 25;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<Elucidator>();
        }
    }

    public class HoneyHeavenCrate : ModItem
    {
        public virtual void SetStaticDefaults()
        {
            // DisplayName.SetDefault("Qedille"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("A very rare crate that can be fished up in honey near a meteor. Opening will get you honey related items and lots of money. may not work");
        }
        public override void SetDefaults()
        {

            item.maxStack = 999;     //This defines the items max stack
            item.consumable = true;  //Tells the game that this should be used up once opened
            item.width = 34;  //The size in width of the sprite in pixels.
            item.height = 34;    //The size in height of the sprite in pixels.      
            item.rare = 5; //The color the title of your Weapon when hovering over it ingame  
            item.useAnimation = 10; //How long the item is used for.
            item.useTime = 10;  //How fast the item is used.
            item.useStyle = 1; //The way your item will be used, 1 is the regular sword swing for example


        }
        public override bool CanRightClick() //this make so you can right click this item
        {
            return true;
        }

        public override void RightClick(Player player)  //this make so when you right click this item, then one of these items will drop
        {


            //  if (Main.hardMode) // if it's hardmode this itams will drop  
            //  {
            int Choose = Main.rand.Next(6);      //so there are 5 items to choose from, but only one will drop  ,  if you want to add more drops change the num 5 with how many items you want and below add another  if (Choose == number)      
            if (Choose == 0)                                                  // 1 item
            {
                player.QuickSpawnItem(ItemID.MeteoriteBar, 22); //this is an example of how to add a modded item, change customSentryItem with your modded item name
            }
            if (Choose == 1)                                                    //2 item
            {
                player.QuickSpawnItem(mod.ItemType("SoulOfDaylight"), 3);
            }
            if (Choose == 2)                                                   // 3 item
            {
                player.QuickSpawnItem(ItemID.SoulofFlight, 20);
            }
            if (Choose == 3)                                                   // 4 item
            {
                player.QuickSpawnItem(ItemID.GiantHarpyFeather, 1);
            }
            if (Choose == 4)                                                  //5 item
            {
                player.QuickSpawnItem(mod.ItemType("PhoenixTome"), 3);
            }
            if (Choose == 5)                                                  //5 item
            {
                player.QuickSpawnItem(ItemID.FallenStar, 50);      //this is how to add another item
            }
            //if you wnat to add more then add if (Choose == 5) etc.

            //and these are items that will drop 100% + the one itam from the top
            player.QuickSpawnItem(ItemID.HoneyBucket, Main.rand.Next(0, 25));
            player.QuickSpawnItem(ItemID.HoneyBlock, Main.rand.Next(0, 30));//this is an example of how to add a vanilla terraria itam, Change ItemID.GoldCoin with what item u want
            player.QuickSpawnItem(ItemID.CrispyHoneyBlock, Main.rand.Next(0, 45));
            player.QuickSpawnItem(ItemID.GoldCoin, Main.rand.Next(0, 500));
        }
        //  else        //else if it's prehard mode then only this items will drop
        //   {

        //5 item
        //       {
        //           player.QuickSpawnItem(ItemType("SilverCoin"), 50);      //this is how to add another item
        //       }




        //  }

    }

    [AutoloadEquip(EquipType.Head)]
    public class LihzahrdHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very heavy.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 0;
            item.rare = 9;
            item.defense = 45;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.moveSpeed -= 0.3f; //movement speed
            player.noKnockback = true;
            player.meleeSpeed -= 0.1f; //melee speed of the player
            player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(33, 30, true); //add a buff (buff ID,time)
            player.AddBuff(95, 30, true); //add a buff (buff ID,time)

            player.AddBuff(115, 30, true); //add a buff (buff ID,time)
            player.AddBuff(22, 30, true); //add a buff (buff ID,time)
            player.AddBuff(13, 30, true); //add a buff (buff ID,time)

            player.AddBuff(1, 30, true); //add a buff (buff ID,time)
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 200);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class LihzahrdBreastplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very heavy.");
        }



        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 9;
            item.defense = 45;
        }

        public override void UpdateEquip(Player player)
        {
            player.moveSpeed -= 0.3f; //movement speed
            player.meleeSpeed -= 0.1f; //melee speed of the player
            player.noKnockback = true;
            player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(33, 30, true); //add a buff (buff ID,time)
            player.AddBuff(95, 30, true); //add a buff (buff ID,time)
            player.AddBuff(115, 30, true); //add a buff (buff ID,time)
            player.AddBuff(22, 30, true); //add a buff (buff ID,time)
            player.AddBuff(13, 30, true); //add a buff (buff ID,time)
            player.AddBuff(1, 30, true); //add a buff (buff ID,time)
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 200);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    [AutoloadEquip(EquipType.Legs)]
    public class LihzahrdLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Very heavy.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 9;
            item.defense = 45;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed -= 0.3f; //movement speed
            player.noKnockback = true;
            player.meleeSpeed -= 0.1f; //melee speed of the player
            player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(22, 30, true); //add a buff (buff ID,time)
            player.AddBuff(33, 30, true); //add a buff (buff ID,time)
            player.AddBuff(95, 30, true); //add a buff (buff ID,time)
            player.AddBuff(115, 30, true); //add a buff (buff ID,time)
            player.AddBuff(13, 30, true); //add a buff (buff ID,time)
            player.AddBuff(1, 30, true); //add a buff (buff ID,time)
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LihzahrdBrick, 200);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    [AutoloadEquip(EquipType.Head)]
    public class HolyHelm : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Allows super fast healing in exchange for 8 defense. Combining with the cactus coverings and swift sneakers increases defense.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 111111;
            item.rare = 8;
            item.defense -= 8;
        }


        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ModContent.ItemType<CactusCoverings>() && legs.type == ModContent.ItemType<SwiftSneakers>();
            
        }

        public override void UpdateArmorSet(Player player)
        {
            player.allDamage += 0.2f;
            player.armorPenetration += 5;
            player.statDefense += 54;
            
            /* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
        }

        public override void UpdateEquip(Player player)
        {
            player.AddBuff(2, 30, true); //add a buff (buff ID,time)
            player.AddBuff(48, 30, true); //add a buff (buff ID,time)
            player.AddBuff(58, 30, true); //add a buff (buff ID,time)
            player.AddBuff(87, 30, true); //add a buff (buff ID,time)
            player.AddBuff(89, 30, true); //add a buff (buff ID,time)
            player.AddBuff(113, 30, true); //add a buff (buff ID,time)
            player.AddBuff(175, 30, true); //add a buff (buff ID,time)
        }

    }

    [AutoloadEquip(EquipType.Head)]
    public class BaldCap : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("bald, baLd, BALD, BALD, BALD!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 999999999;
            item.rare = 8;
        }


        public override void UpdateEquip(Player player)
        {
            player.maxTurrets += 100;

            /* Here are the individual weapon class bonuses.
			player.meleeDamage -= 0.2f;
			player.thrownDamage -= 0.2f;
			player.rangedDamage -= 0.2f;
			player.magicDamage -= 0.2f;
			player.minionDamage -= 0.2f;
			*/
        }


    }
    /* public class RoboticArm : ModItem
     {
         public override void SetStaticDefaults()
         {
             Tooltip.SetDefault("Increases melee speed.");
         }
         public override void SetDefaults()
         {
             item.width = 24;
             item.height = 28;
             item.value = 0;
             item.rare = 1;
             item.accessory = true;
         }
         public override void UpdateEquip(Player player)
         {
             player.meleeSpeed += 0.5f; //melee speed of the player
         }


         public override void AddRecipes()
         {
             ModRecipe recipe = new ModRecipe(mod);
             recipe.AddIngredient(ItemID.SoulofFright, 10);
             recipe.AddIngredient(ItemID.HallowedBar, 30);
             recipe.AddTile(TileID.AlchemyTable);

             recipe.SetResult(this, 1);
             recipe.AddRecipe();
         }
     }*/

    public class FletchingBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots tons of arrows, but is magic now? Weird.");
        }
        public override void SetDefaults()
        {
            item.damage = 130;
            item.magic = true;
            item.mana = 13;
            item.width = 28;
            item.height = 32;
            item.useTime = 75;
            item.useAnimation = 75;
            item.useStyle = 5;
            item.knockBack = 10;
            item.value = 3000;
            item.rare = 9;
            item.UseSound = SoundID.Item102;
            item.autoReuse = false;
            item.shootSpeed = 30f;
            item.shoot = 1;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.VenomArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.HolyArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.CursedArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.IchorArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BoneArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BeeArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.UnholyArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ChlorophyteArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.PhantasmArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FrostArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FrostburnArrow, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Hellwing, damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ShadowFlameArrow, damage, knockBack, player.whoAmI);
            return true;
        }










        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ItemID.Tsunami, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class ParticalSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 699;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 12;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class FireblastSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 668;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 12;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class LunarSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");

        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 645;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 35;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class SeekingSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 635;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 12;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class CursedSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 478;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class ElectricSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 442;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 12;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class BladeSphere : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Visual.");
        }
        public override void SetDefaults()
        {

            item.damage = 60;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = 157;
            item.shootSpeed = 50f;
            item.mana = 15;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 12;
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class BiomeBlaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Please be careful.");
        }
        public override void SetDefaults()
        {
            item.damage = 0;
            item.magic = true;
            item.mana = 3;
            item.width = 28;
            item.height = 32;
            item.useTime = 4;
            item.useAnimation = 4;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 30000;
            item.crit = 0;
            item.rare = 4;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = 10;


        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            type = Main.rand.Next(new int[] { ProjectileID.HolyWater, ProjectileID.UnholyWater, ProjectileID.BloodWater, ProjectileID.PureSpray,
                ProjectileID.CrimsonSpray, ProjectileID.MushroomSpray, ProjectileID.CorruptSpray, ProjectileID.HallowSpray});
            return true;
        }












        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PurpleSolution, 100);
            recipe.AddIngredient(ItemID.BlueSolution, 100);
            recipe.AddIngredient(ItemID.GreenSolution, 100);
            recipe.AddIngredient(ItemID.RedSolution, 100);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 15);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 3);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 3);
            recipe.AddIngredient(ItemID.DarkBlueSolution, 100);
            recipe.AddIngredient(ItemID.HolyWater, 100);
            recipe.AddIngredient(ItemID.UnholyWater, 100);
            recipe.AddIngredient(ItemID.BloodWater, 100);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

   /* public class IronMace : ModItem
    {
        public override void SetDefaults()
        {
            item.damage = 59;    //The damage stat for the Weapon.
            item.melee = true;     //This defines if it does Melee damage and if its effected by Melee increasing Armor/Accessories.
            item.width = 80;    //The size of the width of the hitbox in pixels.
            item.height = 80;    //The size of the height of the hitbox in pixels.
            item.useTime = 10;   //How fast the Weapon is used.
            item.useAnimation = 10;     //How long the Weapon is used for.
            item.channel = true;
            item.UseSound = SoundID.Item1;
            item.useStyle = 100;    //The way your Weapon will be used, 1 is the regular sword swing for example
            item.knockBack = 8f;    //The knockback stat of your Weapon.
            item.value = Item.buyPrice(0, 10, 0, 0); // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 11;   //The color the title of your Weapon when hovering over it ingame                    
            item.shoot = ModContent.ProjectileType<("IMP");  //This defines what type of projectile this weapon will shoot  
            item.noUseGraphic = true; // this defines if it does not use graphic
        }

        public override bool UseItemFrame(Player player)     //this defines what frame the player use when this weapon is used
        {
            player.bodyFrame.Y = 3 * player.bodyFrame.Height;
            return true;
        }
    }
   */
    public class BoulderBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's raining cats and dogs.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 20;     //How fast the Weapon is used.
            item.useAnimation = 5;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 5;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 5;//How many mana this weapon use
            item.UseSound = SoundID.Item5; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 99;  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 10f;    //This defines the projectile speed when shoot
            item.crit = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 10 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 10);
            recipe.AddIngredient(ItemID.SpellTome, 1);
            recipe.AddIngredient(ItemID.Boulder, 100);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 15);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
   
    public class BigBoyBoulderBook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's raining MORE than just cats and dogs now!");
        }
        public override void SetDefaults()
        {

            item.damage = 2500;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 84;      //The size of the width of the hitbox in pixels.
            item.height = 96;      //The size of the height of the hitbox in pixels.
            item.useTime = 20;     //How fast the Weapon is used.
            item.useAnimation = 5;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 500;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 9;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 5;//How many mana this weapon use
            item.UseSound = SoundID.Item5; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 99;  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 10f;    //This defines the projectile speed when shoot
            item.crit = 0;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 15 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
    }

    [AutoloadEquip(EquipType.Head)]
    public class BoulderMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It looks great!");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 0;
            item.rare = 3;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Boulder, 1);
            recipe.AddIngredient(ItemID.StoneBlock, 999);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Charger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Low battery");
        }

        public override void SetDefaults()
        {

            item.magic = true;
            item.height = 73;
            item.value = 1000;
            item.mana = 10;
            item.useAnimation = 40;
            item.crit = 0;
            item.rare = 4;
            item.useStyle = 5;
            item.knockBack = 0;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.damage = 50;
            item.width = 73;
            item.useTime = 40;
            item.shoot = 79;
            item.shootSpeed = 70f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float rotation = MathHelper.ToRadians(360);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < 17; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (16))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }


    }

    public class sgmg : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("golem gun Golem Gun GOLEM GUN!");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 50000;
            item.rare = 10;
            item.UseSound = SoundID.Item96;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Golem>();
            item.shootSpeed = 10f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SDMG, 1);
            recipe.AddIngredient(ModContent.ItemType<GolemSoul>(), 10);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 20);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class sbcmlmg : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Uuuuuuuhhhh..... I can explain.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 50000;
            item.rare = 10;
            item.UseSound = SoundID.Item96;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<MLP>();
            item.shootSpeed = 10f;
        }
    }

    public class WaterBomber : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Do you have a water obsession or something?");
        }
        public override void SetDefaults()
        {

            item.damage = 90;
            item.magic = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 15;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 7;
            item.value = 5000;
            item.rare = 8;
            item.UseSound = SoundID.Item21;
            item.mana = 8;
            item.autoReuse = true;
            item.shoot = 27;
            item.crit = 10;
            item.shootSpeed = 7f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(180)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<WaterBlast>(), 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class WaterBlast : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The waterbolt is no longer early hardmode!");
        }
        public override void SetDefaults()
        {

            item.damage = 30;
            item.magic = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 17;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 5;
            item.value = 5000;
            item.rare = 3;
            item.UseSound = SoundID.Item21;
            item.mana = 9;
            item.autoReuse = true;
            item.shoot = 27;
            item.crit = 4;
            item.shootSpeed = 5.2f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBolt, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class WaterBeacon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Have you ever taken a shower? Well you have now!");
        }
        public override void SetDefaults()
        {

            item.damage = 345;
            item.magic = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 7;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 50000;
            item.rare = 11;
            item.UseSound = SoundID.Item21;
            item.mana = 5;
            item.autoReuse = true;
            item.shoot = 27;
            item.crit = 10;
            item.shootSpeed = 7f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 8 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(70)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MajorUpgrade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<WaterBomber>(), 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class PiranhaMachineGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rapid fire shoots piranhas that stick to your opponents");
        }
        public override void SetDefaults()
        {
            item.damage = 38;
            item.ranged = true;
            item.mana = 0;
            item.width = 100;
            item.height = 32;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.crit = 4;
            item.knockBack = 1;
            item.value = 20000;
            item.rare = 10;
            item.UseSound = SoundID.Item21;
            item.autoReuse = true;
            item.shootSpeed = 15f;
            item.shoot = ModContent.ProjectileType<MechaPiranha>();
            item.channel = true;
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 100;
        }
       // public override void AddRecipes()
       // {

        //    if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
         //   {
         //       ModRecipe recipe = new ModRecipe(mod);
         //       recipe.AddIngredient(ItemID.PiranhaGun, 1);
        //        recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
         //       recipe.AddTile(TileID.TinkerersWorkbench);

        //        recipe.SetResult(this);
        //        recipe.AddRecipe();
          //  }
        //}
    }

    public class BallistaSpray : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Broken lol");
        }
        public override void SetDefaults()
        {

            item.damage = 50;
            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 750000;
            item.rare = -1;
            item.UseSound = SoundID.Item5;
            item.autoReuse = true;
            item.shoot = 679;
            item.shootSpeed = 5f;
            item.mana = 0;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 15 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class BallistaShot : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Broken lol");
        }
        public override void SetDefaults()
        {
            item.damage = 60;  //The damage stat for the Weapon.
            item.mana = 20;      //this defines how many mana this weapon use
            item.width = 56;    //The size of the width of the hitbox in pixels.
            item.height = 56;     //The size of the height of the hitbox in pixels.
            item.useTime = 2;   //How fast the Weapon is used.
            item.useAnimation = 2;    //How long the Weapon is used for.
            item.useStyle = 1;  //The way your Weapon will be used, 1 is the regular sword swing for example
            item.noMelee = true; //so the item's animation doesn't do damage
            item.knockBack = 2f;  //The knockback stat of your Weapon.
            item.value = 1; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = -1;   //The color the title of your Weapon when hovering over it ingame  
            item.UseSound = SoundID.Item44;   //The sound played when using your Weapon
            item.autoReuse = true;   //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 679;   //This defines what type of projectile this weapon will shot
            item.summon = true;    //This defines if it does Summon damage and if its effected by Summon increasing Armor/Accessories.
            item.sentry = true; //tells the game that this is a sentry
        }
    }

    [AutoloadEquip(EquipType.Head)]
    public class SpeedyHelmMelee : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("quintuples melee speed.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 20000000;
            item.rare = 11;
            item.defense = -1;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed += 5f; //melee speed of the player
        }

    }

    public class OverchargedBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Big pew.");
        }
        public override void SetDefaults()

        {


            item.damage = 1;
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 4;
            item.useAnimation = 4;
            item.crit = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 200;
            item.rare = 8;
            item.UseSound = SoundID.Item102;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 50f;
            item.useAmmo = AmmoID.Arrow;

        }


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 5;
            float rotation = MathHelper.ToRadians(45);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<OverchargedShortbow>(), 2);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class OverchargedShortbow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Mega rapid shooting.");
        }
        public override void SetDefaults()

        {


            item.damage = 1;
            item.ranged = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 2;
            item.useAnimation = 2;
            item.crit = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 200;
            item.rare = 8;
            item.UseSound = SoundID.Item102;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 50f;
            item.useAmmo = AmmoID.Arrow;

        }



        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sapphire, 25);
            recipe.AddIngredient(ItemID.BorealWoodBow, 57);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class CursedDartShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The lands shall be coated in waves of devstating flames!");
        }
        public override void SetDefaults()
        {

            item.damage = 25;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.crit = 50;
            item.knockBack = 3;
            item.value = 5000;
            item.rare = 5;
            item.UseSound = SoundID.Item99;
            item.autoReuse = true;
            item.shoot = 478;
            item.shootSpeed = 20f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DartRifle, 5);
            recipe.AddIngredient(ItemID.CursedDart, 500);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 4);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class CrystalDartShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Don't you just hate missing?");
        }
        public override void SetDefaults()
        {

            item.damage = 25;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 5000;
            item.rare = 5;
            item.crit = 50;
            item.UseSound = SoundID.Item99;
            item.autoReuse = true;
            item.shoot = 477;
            item.shootSpeed = 20f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DartRifle, 5);
            recipe.AddIngredient(ItemID.CrystalDart, 500);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 4);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class IchorDartShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a shockwave of ichor darts. This item is for those who want to create a barrier against their opponents.");
        }
        public override void SetDefaults()
        {

            item.damage = 20;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 5000;
            item.rare = 5;
            item.UseSound = SoundID.Item99;
            item.autoReuse = true;
            item.crit = 50;
            item.shoot = 479;
            item.shootSpeed = 20f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DartRifle, 5);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.IchorDart, 500);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 4);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }


    public class SupernovaShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Launches bullets with the power of a small supernova.");
        }
        public override void SetDefaults()
        {

            item.damage = 200;
            item.magic = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 50;
            item.useAnimation = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 50000;
            item.rare = 8;
            item.crit = 0;
            item.autoReuse = false;
            item.shootSpeed = 30f;
            item.shoot = ModContent.ProjectileType<NovaBullet>();
            item.mana = 10;
            item.UseSound = SoundID.Item73;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8)); // 30 degree spread.
                                                                                                               // If you want to randomize the speed to stagger the projectiles
                                                                                                               // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                               // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 7);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 2);
            recipe.AddIngredient(ModContent.ItemType<SoulOfTwilight>(), 1);
            recipe.AddIngredient(ModContent.ItemType<LargeGem>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class CrystalDartSpreadfireGun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Just let me have this.");
        }
        public override void SetDefaults()
        {

            item.damage = 25;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 5000;
            item.rare = 5;
            item.crit = 50;
            item.UseSound = SoundID.Item99;
            item.autoReuse = true;
            item.shoot = 477;
            item.shootSpeed = 50f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 15 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
    public class BlackholeBlaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Forged from... some random anvil i guess?");
        }
        public override void SetDefaults()
        {

            item.damage = 35;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 50000;
            item.rare = 5;
            item.crit = 50;
            item.autoReuse = true;
            item.shoot = 635;
            item.shootSpeed = 15f;
            item.mana = 3;
            item.UseSound = SoundID.Item12;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(15)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.ChainGun, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.AddIngredient(ItemID.Amethyst, 10);
            recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 1);
            recipe.AddIngredient(ItemID.ChlorophyteBar, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class RoyalScimitar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A scimitar coated in a nearly invisible substance that can mess with matter around it.");
        }

        public override void SetDefaults()
        {
            item.damage = 43;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 18;
            item.crit = 17;
            item.useAnimation = 18;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 30000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.NextBool(10))
            {
                target.AddBuff(BuffID.Chilled, 1000);
                target.AddBuff(BuffID.OnFire, 300);
                target.AddBuff(BuffID.Poisoned, 500);
            }

        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DyeTradersScimitar, 5);
            recipe.AddIngredient(ModContent.ItemType<LargeGem>(), 1);
            recipe.AddIngredient(ItemID.IceBlock, 100);
            recipe.AddIngredient(ItemID.Stinger, 5);
            recipe.AddIngredient(ItemID.Fireblossom, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        public class TEST : ModItem
        {
            public override void SetStaticDefaults()
            {
                Tooltip.SetDefault("Forged from... some random anvil i guess?");
            }
            public override void SetDefaults()
            {

                item.damage = 50;
                item.ranged = true;
                item.width = 64;
                item.height = 32;
                item.useStyle = ItemUseStyleID.HoldingOut;
                item.useTime = 10;
                item.useAnimation = 10;
                item.useStyle = 5;
                item.noMelee = true;
                item.knockBack = 1;
                item.value = 50000;
                item.rare = 5;
                item.crit = 50;
                item.autoReuse = true;
                item.shoot = ModContent.ProjectileType<BlackholeBlaste>();
                item.shootSpeed = 10f;
                item.mana = 3;
                item.UseSound = SoundID.Item12;
            }

        }
    }
    public class TrueHeroSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sword forged by one of the most powerful men to ever exist, who was killed by an ancient lunar beast.");
        }

        public override void SetDefaults()
        {
            item.damage = 155;
            item.melee = true;
            item.width = 56;
            item.height = 64;
            item.useTime = 20;
            item.crit = 10;
            item.useAnimation = 20;
            item.shoot = ModContent.ProjectileType<Swordp>();
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 300000;
            item.rare = 10;
            item.shootSpeed = 4f;

            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(25)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.NextBool(3))
            {
                target.AddBuff(BuffID.Ichor, 500);
            }
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<GreatSakuraSaber>(), 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 5);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 5);
            recipe.AddIngredient(ItemID.FragmentSolar, 10);
            recipe.AddIngredient(ItemID.BrokenHeroSword, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Estocade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Covered in so many feathers it may as well be a bird.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 18;
            item.useTime = 24;
            item.shootSpeed = 3.7f;
            item.knockBack = 6.5f;
            item.width = 32;
            item.height = 32;
            item.scale = 1f;
            item.rare = ItemRarityID.Pink;
            item.value = Item.sellPrice(silver: 10);

            item.melee = true;
            item.noMelee = true; // Important because the spear is actually a projectile instead of an item. This prevents the melee hitbox of this item.
            item.noUseGraphic = true; // Important, it's kind of wired if people see two spears at one time. This prevents the melee animation of this item.
            item.autoReuse = true; // Most spears don't autoReuse, but it's possible when used in conjunction with CanUseItem()

            item.UseSound = SoundID.Item1;
            item.shoot = ModContent.ProjectileType<Estocadep>();
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<Estocadep>(), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<Estobolt>(), damage, knockBack, player.whoAmI);
            return true;
        }
        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }
    }
    public class SakuraBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sword as pink as blossoming sakura.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 56;
            item.height = 64;
            item.useTime = 23;
            item.crit = 30;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.AddIngredient(ItemID.StaffofRegrowth, 1);
            recipe.AddIngredient(ItemID.Fireblossom, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class GreatSakuraSaber : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A pink blade that reminds you of a sakura tree in full bloom.");
        }

        public override void SetDefaults()
        {
            item.damage = 140;
            item.melee = true;
            item.width = 56;
            item.height = 64;
            item.useTime = 23;
            item.crit = 30;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 3000;
            item.rare = 3;
            item.shoot = ModContent.ProjectileType<SakuraPetal>();
            item.shootSpeed = 15f;

            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SakuraBlade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<SoulOfDaylight>(), 20);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 2);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ItemID.TerraBlade, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class EndlessLuminiteArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's time for the REAL fun to begin now...");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3.5f;
            item.shoot = 639;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.EndlessQuiver, 1);
        recipe.AddIngredient(ItemID.MoonlordArrow, 3996);
        recipe.AddTile(TileID.Anvils);
        recipe.SetResult(this);
        recipe.AddRecipe();
        }

    }
    public class EndlessCursedArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I appear to have burst into cursed flames.");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 103;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.CursedArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessIchorArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Infinite pee arrows");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 278;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.25f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.IchorArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessHellfireArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The demolitionist will be happy.");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 8f;
            item.shoot = 41;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 6.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.HellfireArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessVenomArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pain.");
        }

        public override void SetDefaults()
        {
            item.damage = 19;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.2f;
            item.shoot = 282;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.3f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.VenomArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessBeeArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("BEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEES.");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 469;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 8f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.HoneyComb, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.Hive, 250);
            recipe.AddIngredient(ItemID.BeesKnees, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessHolyArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oh no.");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2f;
            item.shoot = 91;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.HolyArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessChlorophyteArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bouncy.");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3.5f;
            item.shoot = 225;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.ChlorophyteArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessAerialArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("None shall fly around this item, and those daring enough shall be struck down.");
        }

        public override void SetDefaults()
        {
            item.damage = 11;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.5f;
            item.shoot = 710;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 11f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.DD2BetsyBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessChlorophyteBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oh, this will be fun.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.5f;
            item.shoot = 207;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
   /* public class EndlessVoidBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oh, this will be fun.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 0f;

            item.shoot = ModContent.ProjectileType<("VoidBullet");   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 25f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
         //   recipe.AddIngredient(ItemID.ChlorophyteBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }*/
    public class EndlessLuminiteBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Line 'em up and knock 'em down, forever.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 638;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 2f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.MoonlordBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessCrystalBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Great for making your mom think you broke something.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1f;
            item.shoot = 89;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.CrystalBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessIchorBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("endless pee bullets.");
        }

        public override void SetDefaults()
        {
            item.damage = 13;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4f;
            item.shoot = 279;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5.25f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.IchorBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessCursedBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("r/cursedimages");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4f;
            item.shoot = 104;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.CursedBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessPartyBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Celebrate the parties in a F U N way.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 5f;
            item.shoot = 284;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5.1f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.PartyBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessExplosiveBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The demolitionist looks upon this item with great happiness.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 6.6f;
            item.shoot = 286;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.7f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.ExplodingBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessVenomBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Turn your enemies into poisoned swiss cheese.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.1f;
            item.shoot = 283;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 5.3f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.VenomBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessHighVelocityBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Zoom.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4f;
            item.shoot = 242;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.HighVelocityBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessGoldenBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Murder with this to get rich! NOT A SCAM!");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3.6f;
            item.shoot = 287;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.6f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.GoldenBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessNanoBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Use this and enemies will make sure to run away.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3.6f;
            item.shoot = 285;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4.6f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.NanoBullet, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessMeteorBulletPouch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("One of the most fun bullets.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1f;
            item.shoot = 36;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Bullet;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessMusketPouch, 1);
            recipe.AddIngredient(ItemID.MeteorShot, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessUnholyArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("These arrows need some jesus.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 4;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3.4f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.UnholyArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessJesterArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("What kind of jester would use these?");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4f;
            item.shoot = 5;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 0.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.JestersArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessFlamingArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I appear to have burst into flames.");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2f;
            item.shoot = 2;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.FlamingArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EnergizedQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can create pulses of energy on command.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = 357;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 23f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.PulseBow, 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessFrostburnArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I appear to have burst into frozen flames.");
        }

        public override void SetDefaults()
        {
            item.damage = 9;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2.2f;
            item.shoot = 172;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3.75f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.FrostburnArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessBoneArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's spooky and scary.");
        }

        public override void SetDefaults()
        {
            item.damage = 6;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2.5f;
            item.shoot = 474;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3.5f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.BoneArrow, 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessShadowflameArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("I appear to have burst into shadowflames.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.5f;
            item.shoot = 495;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 11f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ItemID.DemonTorch, 20);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.ShadowFlameBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessHellwingQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("B a t s.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 5.5f;
            item.shoot = 485;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 6f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.HellwingBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class EndlessMarrowArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("It's spooky and scary and fast.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.7f;
            item.shoot = 117;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 11f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.Marrow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class SplittingArrow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An extremely fun arrow."); 
        }

        public override void SetDefaults()
        {
            item.damage = 8;

            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1f;
            item.shoot = ModContent.ProjectileType<DestructiveArrow>();  //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 7f;
            item.ammo = AmmoID.Arrow;
            item.maxStack = 999;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 250);
            recipe.AddIngredient(ItemID.Obsidian, 10);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.SoulofNight, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this, 250);
            recipe.AddRecipe();
        }

    }

    //recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
    //item.shoot = ModContent.ProjectileType<("Tomahawkp");
    public class EndlessSplittingArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Try not to break your computer.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 1f;
            item.shoot = ModContent.ProjectileType<DestructiveArrow>();  //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 7f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<SplittingArrow>(), 3996);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }


    //recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
    //item.shoot = ModContent.ProjectileType<("Tomahawkp");
    public class EndlessHellArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Moves through walls.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3f;
            item.shoot = ModContent.ProjectileType<Hellarrow>();  //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 10f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<FlamebiterBow>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    //recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
    //item.shoot = ModContent.ProjectileType<("Tomahawkp");
    public class EndlessFrostArrowQuiver : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("So cold that it's, uh.. hmm... uh, cold!");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 4.5f;
            item.shoot = 120;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 10f;
            item.ammo = AmmoID.Arrow;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.EndlessQuiver, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.IceBow, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class CursedDartBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This fire is Super. Hot. Super. Hot. Super. Hot...");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2.2f;
            item.shoot = 478;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CursedDart, 3996);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class CrystalDartBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("No more missing.");
        }

        public override void SetDefaults()
        {
            item.damage = 14;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 3.5f;
            item.shoot = 477;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 1f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CrystalDart, 3996);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class IchorDartBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Be careul not to multiply them inside the box.");
        }

        public override void SetDefaults()
        {
            item.damage = 12;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2.5f;
            item.shoot = 479;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 3f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IchorDart, 3996);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class PoisonDartBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Darts in a box!");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 2f;
            item.shoot = 267;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 2f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PoisonDart, 3996);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class BowlOfSeeds : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("How many seeds can you fit in a bowl?");
        }

        public override void SetDefaults()
        {
            item.damage = 3;
            item.ranged = true;
            item.width = 8;
            item.height = 8;
            item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
            item.knockBack = 0f;
            item.shoot = 51;   //The projectile shoot when your weapon using this ammo
            item.shootSpeed = 4f;
            item.ammo = AmmoID.Dart;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Seed, 3996);
            recipe.AddIngredient(ItemID.Bowl, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    public class ThiccShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Unreliable bullet velocity.");
        }
        public override void SetDefaults()
        {

            item.damage = 24;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 6.5f;
            item.value = 50000;
            item.rare = 2;
            item.UseSound = SoundID.Item36;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 13 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(40)); // 30 degree spread.
                         
				// If you want to randomize the speed to stagger the projectiles
				 float scale = 1f - (Main.rand.NextFloat() * 1f);
				 perturbedSpeed = perturbedSpeed * scale;                                                                                     // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 //perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X * 10f, perturbedSpeed.Y * 10f, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        /*
         * public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 13 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(200)); // 30 degree spread.
                         
				// If you want to randomize the speed to stagger the projectiles
				 float scale = 4f - (Main.rand.NextFloat() * 1f);
				 perturbedSpeed = perturbedSpeed * 0.1f;                                                                                     // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X * 10f, perturbedSpeed.Y * 1f, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
          */
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Shotgun, 5);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class CompactBow : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("fires a ton of arrows in a tight spread.");
        }
        public override void SetDefaults()

        {


            item.damage = 2;
            item.ranged = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 65;
            item.useAnimation = 65;
            item.crit = 2;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 20000;
            item.rare = 3;
            item.UseSound = SoundID.Item5;
            item.autoReuse = false;
            item.shoot = 1;
            item.shootSpeed = 20f;
            item.useAmmo = AmmoID.Arrow;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WoodenArrow, 10000);
            recipe.AddIngredient(ItemID.QueenBeeTrophy, 1);
            recipe.AddIngredient(ItemID.WoodenBow, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 15;
            float rotation = MathHelper.ToRadians(25);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 45f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class DaedalusRainBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Not quite strong enough to be a stormbow.");
        }
        public override void SetDefaults()
        {

            item.damage = 13;   //The damage stat for the Weapon.                      
            item.ranged = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 15;     //How fast the Weapon is used.
            item.useAnimation = 15;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 3.5f;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame

            item.UseSound = SoundID.Item5; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shootSpeed = 9f;    //This defines the projectile speed when shoot
            item.crit = 8;
            item.shoot = 1;
            item.useAmmo = AmmoID.Arrow;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.RainCloud, 10);
            recipe.AddIngredient(ItemID.ShadowScale, 20);
            recipe.AddIngredient(ItemID.WhiteString, 1);
            recipe.AddIngredient(ItemID.FallenStar, 15);
            recipe.AddIngredient(ModContent.ItemType<Stick>(), 45);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class LaserEnhancedPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A pickaxe that uses lasers to mine, making it an extremely powerful tool for destroying things at incredible speeds.");
        }

        public override void SetDefaults()
        {
            item.damage = 0;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 2;
            item.useAnimation = 2;
            item.pick = 1000;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.knockBack = 15;
            item.value = 1;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<SoulOfTwilight>(), 1998);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 25);
            recipe.AddIngredient(ItemID.LaserDrill, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        
    }
    public class LunarLaser : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pew pew.");
        }
        public override void SetDefaults()
        {

            item.damage = 100;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 8;     //How fast the Weapon is used.
            item.useAnimation = 8;    //How long the Weapon is used for.
            item.useStyle = 5;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 2;  //The knockback stat of your Weapon.      
            item.value = 1000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 10;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 3;//How many mana this weapon use
            item.UseSound = SoundID.Item12; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 640;  //This defines what type of projectile this weapon will shoot 6 4 0
            item.shootSpeed = 20f;    //This defines the projectile speed when shoot
            item.crit = 20;
        }

        
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpaceGun, 1);
            recipe.AddIngredient(ItemID.FragmentNebula, 10);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class GeyserOnAStick : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots spurts of flames both up and down!");
        }
        public override void SetDefaults()
        {

            item.damage = 20;   //The damage stat for the Weapon.                      
            item.melee = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 15;     //How fast the Weapon is used.
            item.useAnimation = 15;    //How long the Weapon is used for.
            item.useStyle = 4;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 2;  //The knockback stat of your Weapon.      
            item.value = 1000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 2;   //The color the title of your Weapon when hovering over it ingame
            item.UseSound = SoundID.Item74; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = ModContent.ProjectileType<GeyserBlast>();  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 1f;    //This defines the projectile speed when shoot
            item.crit = 10;
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GeyserTrap, 1);
            recipe.AddIngredient(ModContent.ItemType<ThickStick>(), 2);
            recipe.AddIngredient(ItemID.Gel, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Onaighast: ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The outcast of the sulphuric sea's sweet whispers can be heard while firing this strange revolver.");
        }

        public override void SetDefaults()
        {
            item.damage = 35;
            item.ranged = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.knockBack = 50;
            item.value = 30000;
            item.rare = 10;
            item.UseSound = SoundID.Item36;
            item.autoReuse = true;
            item.shootSpeed = 24f;
            item.shoot = 1;
            item.useAmmo = AmmoID.Bullet;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 15 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(0)); // 30 degree spread.
                                                                                                               // If you want to randomize the speed to stagger the projectiles
                                                                                                               // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                               // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
    public class CorruptCommandersStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Command the weakest forces of the corruption. Nobody can command the strongest.");
        }
        public override void SetDefaults()
        {

            item.damage = 34;
            item.melee = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = 4;
            item.useTime = 5;
            item.useAnimation = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 50000;
            item.rare = 5;
            item.crit = 25;
            item.autoReuse = true;
            item.shoot = 307;
            item.shootSpeed = 15f;
            item.UseSound = SoundID.Item109;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(50)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ScourgeoftheCorruptor, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ItemID.CursedFlame, 10);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 8);
            recipe.AddIngredient(ModContent.ItemType<Upgrade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 12);
            recipe.AddIngredient(ModContent.ItemType<SoulOfMidnight>(), 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class AncientSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("f a s t.");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.melee = true;
            item.width = 56;
            item.height = 64;
            item.useTime = 5;
            item.crit = 15;
            item.useAnimation = 5;
            item.useStyle = 1;
            item.knockBack = 4;
            item.value = 3000;
            item.rare = 3;
            item.shoot = 656;
            item.shootSpeed = 15f;

            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.NextBool(10))
            {
                target.AddBuff(BuffID.OnFire, 300);

            }
            if (Main.rand.NextBool(10))
            {
                target.AddBuff(BuffID.Ichor, 300);

            }
            if (Main.rand.NextBool(10))
            {
                target.AddBuff(BuffID.Venom, 300);

            }
            if (Main.rand.NextBool(2))
            {
                target.AddBuff(BuffID.Poisoned, 300);

            }
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            if (Main.rand.NextBool(15))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            else
            {
                position.Y -= (float)(10000);
                type = ProjectileID.BulletHighVelocity;
            }




            return true;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ModContent.ItemType<SakuraBlade>(), 1);
            recipe.AddIngredient(ItemID.FossilOre, 25);
            recipe.AddIngredient(ItemID.Amber, 3);
            recipe.AddIngredient(ItemID.Ruby, 3);
            recipe.AddIngredient(ItemID.AncientCloth, 3);
            recipe.AddIngredient(ItemID.AncientBattleArmorMaterial, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class MeteorShowerStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Rain tons of meteors.");
        }
        public override void SetDefaults()
        {

            item.damage = 38;   //The damage stat for the Weapon.                      
            item.magic = true;   //This defines if it does magic damage and if its effected by magic increasing Armor/Accessories.
            item.width = 28;      //The size of the width of the hitbox in pixels.
            item.height = 32;      //The size of the height of the hitbox in pixels.
            item.useTime = 8;     //How fast the Weapon is used.
            item.useAnimation = 8;    //How long the Weapon is used for.
            item.useStyle = 4;         //The way your Weapon will be used, 5 is the Holding Out Used for: Guns, Spellbooks, Drills, Chainsaws, Flails, Spears for example
            item.noMelee = true;     //Setting to True allows the weapon sprite to stop doing damage, so only the projectile does the damge
            item.knockBack = 4.5f;  //The knockback stat of your Weapon.      
            item.value = 10000; // How much the item is worth, in copper coins, when you sell it to a merchant. It costs 1/5th of this to buy it back from them. An easy way to remember the value is platinum, gold, silver, copper or PPGGSSCC (so this item price is 10gold)
            item.rare = 8;   //The color the title of your Weapon when hovering over it ingame
            item.mana = 13;//How many mana this weapon use
            item.UseSound = SoundID.Item88; //item.UseSound = SoundID.Item1;   //The sound played when using your Weapon
            item.autoReuse = true; //Weather your Weapon will be used again after use while holding down, if false you will need to click again after use to use it again.
            item.shoot = 424;  //This defines what type of projectile this weapon will shoot  
            item.shootSpeed = 20f;    //This defines the projectile speed when shoot
            item.crit = 4;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-5, 5) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(160, 320);  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, 1);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.MeteorStaff, 2);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ModContent.ItemType<VoidMaterial>(), 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class Insecticide : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Not for humans.");
        }
        public override void SetDefaults()

        {


            item.damage = 39;
            item.ranged = true;
            item.width = 10;
            item.height = 10;
            item.useTime = 3;
            item.useAnimation = 3;
            item.crit = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 4;
            item.value = 200000;
            item.rare = 8;
            item.UseSound = SoundID.Item13;
            item.autoReuse = true;
            item.shoot = 511;
            item.shootSpeed = 65f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ToxicFlask, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.BottledWater, 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 5);
            recipe.AddIngredient(ItemID.Grasshopper, 20);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 20;
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 15f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class BubbleBlower : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bubbles are fun.");
        }
        public override void SetDefaults()

        {


            item.damage = 15;
            item.magic = true;
            item.mana = 2;
            item.width = 10;
            item.height = 10;
            item.useTime = 3;
            item.useAnimation = 10;
            item.crit = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = 3;
            item.UseSound = SoundID.Item85;
            item.autoReuse = true;
            item.shoot = 405;
            item.shootSpeed = 15f;
            item.reuseDelay =21;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BubbleWand, 1);
            recipe.AddIngredient(ItemID.BubbleMachine, 1);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class BubalBlower : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Bubals are fun.");
        }
        public override void SetDefaults()

        {


            item.damage = 1500;
            item.magic = true;
            item.mana = 2;
            item.width = 10;
            item.height = 10;
            item.useTime = 3;
            item.useAnimation = 10;
            item.crit = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = 3;
            item.UseSound = SoundID.Item85;
            item.autoReuse = true;
            item.shoot = 405;
            item.shootSpeed = 15f;
            item.reuseDelay = 21;

        }


    }
    public class SuperConcentratedLaser : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fires a concentrated laser.");
        }
        public override void SetDefaults()

        {


            item.damage = 35;
            item.magic = true;
            item.mana = 1;
            item.width = 10;
            item.height = 10;
            item.useTime = 2;
            item.useAnimation = 2;
            item.crit = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0.5f;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item12;
            item.autoReuse = true;
            item.shoot = 606;
            item.shootSpeed = 11f;

        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpaceGun, 1);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.SoulofMight, 2);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 2);
            recipe.AddIngredient(ItemID.Minishark, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
      
    }
    public class SuperSpreadLaser : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Fires a large inaccurate laser.");
        }
        public override void SetDefaults()

        {


            item.damage = 28;
            item.magic = true;
            item.mana = 1;
            item.width = 10;
            item.height = 10;
            item.useTime = 2;
            item.useAnimation = 2;
            item.crit = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0.5f;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item12;
            item.autoReuse = true;
            item.shoot = 606;
            item.shootSpeed = 11f;

        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SpaceGun, 1);
            recipe.AddIngredient(ItemID.SoulofMight, 2);
            recipe.AddIngredient(ItemID.HallowedBar, 10);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 2);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    public class Ultimatum : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Weapon of disappearence and appearence.");
        }

        public override void SetDefaults()
        {
            item.damage = 150;
            item.ranged = true;
            item.width = 1;
            item.height = 1;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 9;
            item.shoot = ModContent.ProjectileType<Ultimate>();
            item.UseSound = SoundID.Item114;
            item.shootSpeed = 7f;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 4 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
     public class IchorSack : ModItem

     {
           public override void SetStaticDefaults()
           {
               Tooltip.SetDefault("Sprays ichor relentlessly.");
           }
           public override void SetDefaults()

           {


                  item.damage = 40;
            item.magic = true;
            item.mana = 2;
            item.width = 10;
            item.height = 10;
            item.useTime = 6;
            item.useAnimation = 6;
            item.crit = 5;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2f;
            item.value = 20000;
            item.rare = 5;
            item.UseSound = SoundID.Item13;
            item.autoReuse = true;
            item.shoot = 524;
            item.shootSpeed = 7f;

           }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            if (Main.rand.NextBool(5))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            else
            {
                type = ProjectileID.IchorBullet;
            }
            return true;
        }

     }
    public class StarShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a few big stars.");
        }
        public override void SetDefaults()
        {

            item.damage = 150;
            item.magic = true;
            item.width = 1;
            item.height = 20;
            item.useStyle = 5;
            item.useTime = 25;
            item.useAnimation = 25;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3.25f;
            item.value = 7500;
            item.rare = 10;
            item.UseSound = SoundID.Item99;
            item.autoReuse = true;
            item.shoot = 503;
            item.shootSpeed = 35f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(30);
            position += Vector2.Normalize(new Vector2(speedX, speedY));
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.FragmentVortex, 10); 
            recipe.AddIngredient(ModContent.ItemType<StarGun>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class MiniShotgun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Awesome, and a 33% chance not to consume ammo.");
        }
        public override void SetDefaults()
        {

            item.damage = 10;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = 5;
            item.useTime = 8;
            item.useAnimation = 8;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 5000;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }
        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .33f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); 
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30));
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; 
        }
       
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IllegalGunParts, 1);
            recipe.AddIngredient(ItemID.Minishark, 1);
            recipe.AddIngredient(ItemID.Shotgun, 1);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddIngredient(ItemID.IronBar, 15);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class DarkBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sword of pure darkness.");
        }

        public override void SetDefaults()
        {
            item.damage = 55;
            item.melee = true;
            item.width = 44;
            item.height = 48;
            item.useTime = 27;
            item.crit = 4;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 3000;
            item.rare = 4;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.NightsEdge, 1);
            recipe.AddIngredient(ItemID.SoulofNight, 25);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 1);
            recipe.AddIngredient(ItemID.SharkFin, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class VoidBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sword of pure darkness.");
        }

        public override void SetDefaults()
        {
            item.damage = 78;
            item.melee = true;
            item.width = 174;
            item.height = 172;
            item.useTime = 27;
            item.crit = 12;
            item.useAnimation = 27;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 3000;
            item.rare = 6;
            item.shootSpeed = 7f;
            item.shoot = ModContent.ProjectileType<BlackholeBlast>();
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<DarkBlade>(), 1);
            recipe.AddIngredient(ModContent.ItemType<SoulOfMidnight>(), 10);
            recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 5);
            recipe.AddIngredient(ModContent.ItemType<VoidStone>(), 3);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class BrokenFlamethrower : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Still works somehow.");
        }
        public override void SetDefaults()
        {

            item.damage = 10;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 50000;
            item.rare = 4;
            item.UseSound = SoundID.Item13;
            item.autoReuse = true;
            item.shoot = 400;
            item.shootSpeed = 13f;
            item.useAmmo = AmmoID.Gel;
        }
      
    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(65)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Flamethrower, 1);
            recipe.AddIngredient(ItemID.Bomb, 10);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class SwordOfTheStars : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Can shoot many projectiles.");
        }

        public override void SetDefaults()
        {
            item.damage = 34;
            item.melee = true;
            item.width = 56;
            item.height = 64;
            item.useTime = 8;
            item.crit = 15;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.shoot = 239;
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            if (Main.rand.NextBool(2))
            {
                target.AddBuff(BuffID.Wet, 300);

            }
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            if (Main.rand.NextBool(15))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            else
            {
                type = ProjectileID.SkyFracture;
           }
            if (Main.rand.NextBool(5))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BlackBolt, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(8))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.LunarFlare, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(3))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MoonlordArrowTrail, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(15))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.NebulaBlaze1, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(9))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallofFrost, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(2))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.StarWrath, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(13))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.NorthPoleSnowflake, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(7))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ScutlixLaserFriendly, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(5))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.AmberBolt, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(25))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ElectrosphereMissile, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(4))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Blizzard, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(14))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DD2SquireSonicBoom, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(6))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.LightBeam, damage, knockBack, player.whoAmI);
            }
            return true;
           
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            //recipe.AddIngredient(ModContent.ItemType<SakuraBlade>(), 1);
            recipe.AddIngredient(ItemID.Cloud, 25);
            recipe.AddIngredient(ModContent.ItemType<LightGem>(), 2);
            recipe.AddIngredient(ItemID.RainCloud, 5);
            recipe.AddIngredient(ItemID.Starfury, 1);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.Sapphire, 20);
            recipe.AddIngredient(ItemID.SoulofLight, 20);
            recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
            recipe.AddIngredient(ItemID.Diamond, 2);
            recipe.AddIngredient(ItemID.Feather, 30);
            recipe.AddIngredient(ItemID.FallenStar, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class SharpFlower : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("She loves me, she loves me not, she lov- oh no she's dead.");
        }
        public override void SetDefaults()
        {

            item.damage = 12;
            item.mana = 3;
            item.magic = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 500;
            item.rare = 2;
            item.UseSound = SoundID.Item17;
            item.autoReuse = false;
            item.shoot = 221;
            item.shootSpeed = 15f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(5)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sunflower, 20);
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class LightMaker : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Makes a lot of light.");
        }
        public override void SetDefaults()
        {

            item.magic = true;
            item.width = 100;
            item.height = 100;
            item.useStyle = 4;
            item.useTime = 5;
            item.useAnimation = 5;
            item.noMelee = true;
            item.value = 75000;
            item.rare = 2;
            item.UseSound = SoundID.Item17;
            item.autoReuse = true;
            item.shoot = 53;
            item.shootSpeed = 50f;
            item.mana = 5;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                 // If you want to randomize the speed to stagger the projectiles
                                                                                                                 // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                 // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.StickyGlowstick, 3996);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class VoidEliminatorSuperior : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Actually overpowered.");
        }
        public override void SetDefaults()
        {

            item.damage = 1;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.crit = 100;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 25000000;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 14;
            item.useAmmo = AmmoID.Bullet;
            item.shootSpeed = 70f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 20 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

     
    }
    public class VoidEliminatorBow : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Actually overpowered.");
        }
        public override void SetDefaults()
        {

            item.damage = 1;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.crit = 100;
            item.noMelee = true;
            item.knockBack = 0;
            item.value = 25000000;
            item.rare = 11;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 14;
            item.useAmmo = AmmoID.Arrow;
            item.shootSpeed = 70f;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 20 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(10)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

    }
    [AutoloadEquip(EquipType.Head)]
    public class PaperBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("You gave me the ugly!");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 0;
            item.rare = -1;
            item.defense -= 100;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Horrified] = true;
            player.AddBuff(22, 30, true); //add a buff (buff ID,time)
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Wood, 100);
            recipe.AddIngredient(ItemID.Barrel, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    [AutoloadEquip(EquipType.Head)]
    public class DacernsHelmet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The helmet of Dacern, the creator of this mod.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 0;
            item.rare = 11;
            item.defense = 1000;
        }

        public override void UpdateEquip(Player player)
        {

            player.lifeRegen += 50;
            player.buffImmune[BuffID.OnFire] = true;
            player.noKnockback = true;
            player.AddBuff(198, 30, true); //add a buff (buff ID,time)
            player.AddBuff(181, 30, true); //add a buff (buff ID,time)
            player.AddBuff(178, 30, true); //add a buff (buff ID,time)
            player.AddBuff(175, 30, true); //add a buff (buff ID,time)
            player.AddBuff(165, 30, true); //add a buff (buff ID,time)
           // player.AddBuff(151, 30, true); //add a buff (buff ID,time) player.AddBuff(32, 30, true); //add a buff (buff ID,time)
         //   player.AddBuff(113, 30, true); //add a buff (buff ID,time)
         //   player.AddBuff(111, 30, true); //add a buff (buff ID,time) player.AddBuff(32, 30, true); //add a buff (buff ID,time)
       //     player.AddBuff(89, 30, true); //add a buff (buff ID,time)
           // player.AddBuff(48, 30, true); //add a buff (buff ID,time) player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(60, 30, true); //add a buff (buff ID,time) player.AddBuff(32, 30, true); //add a buff (buff ID,time)
         //   player.AddBuff(2, 30, true); //add a buff (buff ID,time)
            player.AddBuff(95, 30, true); //add a buff (buff ID,time)
        }

    }


    [AutoloadEquip(EquipType.Head)]
    public class CultistGrandmastersHood : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A black and red hood left behind by the cultist grandmaster.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 100000;
            item.rare = 9;
        }

    }


    [AutoloadEquip(EquipType.Head)]
    public class PurpleSlimeMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A mask designed to look like a purple slime.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 1000;
            item.rare = 5;
        }

    }


    [AutoloadEquip(EquipType.Head)]
    public class RedSlimeMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A mask designed to look like a red slime.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 1000;
            item.rare = 5;
        }

    }


    [AutoloadEquip(EquipType.Head)]
    public class YellowSlimeMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A mask designed to look like a yellow slime.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 1000;
            item.rare = 5;
        }

    }

    [AutoloadEquip(EquipType.Head)]
    public class StationaryTurretMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A mask designed to look like the powerful laser sentry known simply as the stationary turret.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 100000;
            item.rare = 9;
        }

    }
    [AutoloadEquip(EquipType.Body)]
    public class CultistGrandmastersRobe : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The robe worn be the cultist grandmaster.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 100000;
            item.rare = 9;
        }

    }

    [AutoloadEquip(EquipType.Legs)]
    public class CultistGrandmastersPants : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pants worn by the cultist grandmaster.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 100000;
            item.rare = 9;
        }

    }
    [AutoloadEquip(EquipType.Body)]
    public class DacernsChestplate : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The chestplate of Dacern the creator, a small YouTuber.");
        }



        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 11;
            item.defense = 1000;
        }

        public override void UpdateEquip(Player player)
        {
            player.meleeSpeed = 5f; //melee speed of the player
            player.noKnockback = true;
            player.AddBuff(172, 30, true); //add a buff (buff ID,time)
            player.AddBuff(159, 30, true); //add a buff (buff ID,time)
            player.AddBuff(150, 30, true); //add a buff (buff ID,time)
            player.AddBuff(117, 30, true); //add a buff (buff ID,time)
            player.AddBuff(59, 30, true); //add a buff (buff ID,time)
            player.AddBuff(115, 30, true); //add a buff (buff ID,time)
            //player.AddBuff(114, 30, true); //add a buff (buff ID,time)
            player.AddBuff(100, 30, true); //add a buff (buff ID,time)player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(110, 30, true); //add a buff (buff ID,time)player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.AddBuff(76, 30, true); //add a buff (buff ID,time)
            player.AddBuff(58, 30, true); //add a buff (buff ID,time)
        }


    }

    [AutoloadEquip(EquipType.Legs)]
    public class DacernsLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("The leggings of Dacern, who you can talk to at https://discord.gg/7k22jTM.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 11;
            item.defense = 1000;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed = 3f; //movement speed
            player.AddBuff(112, 30, true); //add a buff (buff ID,time) player.AddBuff(32, 30, true); //add a buff (buff ID,time)
            player.noKnockback = true;
         //   player.AddBuff(140, 30, true); //add a buff (buff ID,time)
            player.AddBuff(63, 30, true); //add a buff (buff ID,time)
            player.AddBuff(116, 30, true); //add a buff (buff ID,time)
            player.AddBuff(3, 30, true); //add a buff (buff ID,time)
        }
    }
    public class DacernsDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A small dagger that was created on a whim by Dacern.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 42;
            item.height = 42;
            item.useTime = 4;
            item.useAnimation = 4;
            item.useStyle = 3;
            item.knockBack = 1;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }

    }
    public class DacernsLaserSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A blade of light made by Dacern because why not.");
        }

        public override void SetDefaults()
        {
            item.damage = 100;
            item.melee = true;
            item.width = 9;
            item.height = 65;
            item.useTime = 2;
            item.useAnimation = 2;
            item.useStyle = 4;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 11;
            item.autoReuse = true;
        }

    }
    public class DacernsSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sword Dacern made in boredom.");
        }

        public override void SetDefaults()
        {
            item.damage = 75;
            item.melee = true;
            item.width = 46;
            item.shoot = 635;
            item.shootSpeed = 5f;
            item.height = 54;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 5;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }
    }
    public class DacernsCrackedSaw : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An item made by Dacern to serve an unknown purpose.");
        }

        public override void SetDefaults()
        {
            item.damage = 1000;
            item.melee = true;
            item.width = 78;
            item.height = 30;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 2;
            item.knockBack = 20;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }
    }
    public class DacernsBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An item carefully made by Dacern.");
        }

        public override void SetDefaults()
        {
            item.damage = 5000;
            item.melee = true;
            item.width = 56;
            item.height = 56;
            item.useTime = 12;
            item.useAnimation = 12;

            item.shoot = 661;
            item.shootSpeed = 13f;
            item.useStyle = 1;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = SoundID.Item15;
            item.autoReuse = true;
        }

    }
    public class DacernsBladeTwo : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A very heavy item carefully made by Dacern.");
        }

        public override void SetDefaults()
        {
            item.damage = 5000;
            item.melee = true;
            item.width = 56;
            item.height = 56;
            item.useTime = 120;
            item.useAnimation = 120;
            item.useStyle = 1;
            item.knockBack = 0;
            item.value = 30000;
            item.rare = 11;
            item.UseSound = (SoundID.Item15.WithVolume(15f));
            item.autoReuse = true;
        }

    }
    public class SuperEffectiveWhetstone : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases armor penetration by too much.");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.rare = 11;
            item.accessory = true;
        }
        public override void UpdateEquip(Player player)
        {
            player.armorPenetration += 2500; //melee speed of the player
        }


    }
   
    public class VoidHeart : ModItem
{
    public override void SetStaticDefaults()
    {
        Tooltip.SetDefault("Increases your defense to that of a void creature.");
    }
    public override void SetDefaults()
    {
        item.width = 24;
        item.height = 28;
        item.value = 0;
        item.rare = 11;
        item.accessory = true;

            item.defense = 10000;
    }
        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Bleeding] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.Stoned] = true;
        }

    }

    public class GrandmastersHeart : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Transforms you into the cultist grandmaster.");
        }
        public override void SetDefaults()
        {
            item.width = 24;
            item.height = 28;
            item.value = 0;
            item.rare = 11;
            item.accessory = true;
            item.defense = 68;
        }

        public override void UpdateEquip(Player player)
        {
            player.statLifeMax2 += 49500;
            player.statManaMax2 += 10000;
            player.nightVision = true;
            
            player.manaCost -= 100;
            player.manaFlower = true;
            player.moveSpeed -= 0.9f;
            player.noKnockback = true;
            player.buffImmune[BuffID.Poisoned] = true;
            player.buffImmune[BuffID.Confused] = true;
            player.buffImmune[BuffID.OnFire] = true;
            player.buffImmune[BuffID.Venom] = true;
            player.buffImmune[BuffID.CursedInferno] = true;
            player.buffImmune[BuffID.Frostburn] = true;
            player.buffImmune[BuffID.ShadowFlame] = true;
            player.buffImmune[BuffID.Ichor] = true;
            player.buffImmune[BuffID.Midas] = true;
            player.buffImmune[BuffID.Suffocation] = true;

            
            int lomu = 0;

            lomu++;
            if (lomu > 120)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<FireballFriendly>();
                Projectile.NewProjectile(position, direction * speed, type, 100, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

                lomu = 0;

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }
    }

    
    [AutoloadEquip(EquipType.Legs)]
    public class SuperFastLeggings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Run fast");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 11;
            item.defense = 0;
        }
        public override void UpdateEquip(Player player)
        {
            player.moveSpeed = 20f; //movement speed
        }
    }
    public class BoulderShield : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Not very effective as a shield, but can do some damage.");
        }

        public override void SetDefaults()
        {
            item.damage = 250;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 3;
            item.knockBack = 16;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Boulder, 5);
            recipe.AddIngredient(ItemID.EoCShield, 1);
            recipe.AddIngredient(ModContent.ItemType<MinorUpgrade>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class ReallyDullSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A really fricking dull sword.");
        }

        public override void SetDefaults()
        {
            item.damage = 4;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 2.5f;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Bomb, 5);
            recipe.AddIngredient(ItemID.Muramasa, 1);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class ReallySharpSword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Oh, you just needed to sharpen it.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 30;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 1;
            item.knockBack = 2.5f;
            item.value = 3000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<ReallyDullSword>(), 1);
            recipe.AddTile(TileID.SharpeningStation);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class ExplorationCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Launches an oddly familiar figure.");
        }
        public override void SetDefaults()
        {

            item.damage = 50;
            item.ranged = true;
            item.width = 40;
            item.height = 20;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 8;
            item.value = 5000;
            item.rare = 6;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Dora>();
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item96;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(50)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.TreasureMap, 1);
            recipe.AddIngredient(ItemID.SnowballCannon, 1);
            recipe.AddTile(TileID.TinkerersWorkbench);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class ManaSupercannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Launches an oddly familiar figure.");
        }
        public override void SetDefaults()
        {

            item.damage = 625;
            item.magic = true;
            item.width = 40;
            item.mana = 200;
            item.height = 40;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 60;
            item.useAnimation = 60;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 10;
            item.value = 5000;
            item.rare = 6;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<ManaShot>();
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item17;
        }
    }
    public class FamiliarPhotos : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("They're all so familiar, but you just can't quite make them out.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 10;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.
   
        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<ForgottenEye>());
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<ForgottenBee>());
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<FamiliarImage>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

    }

    public class DarkStar : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons the god of space.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 10;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.SoulofNight, 20);
                recipe.AddIngredient(ItemID.FallenStar, 15);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 4);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this, 5);
                recipe.AddRecipe();

            }
        }

        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y - 500, ModContent.NPCType<SpaceBoss>(), 0);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

    }
    public class SlimyPillarStatue : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons the three pillars of slime.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 5;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.

        public override bool UseItem(Player player)
        {
            NPC.NewNPC((int)player.Center.X+200, (int)player.Center.Y-200, ModContent.NPCType<RedSlimyPillar>(), 0);
            NPC.NewNPC((int)player.Center.X-200, (int)player.Center.Y-200, ModContent.NPCType<PurpleSlimyPillar>(), 0);
            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y-200, ModContent.NPCType<YellowSlimyPillar>(), 0);
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Gel, 200);
                recipe.AddIngredient(ItemID.PurplePaint, 10);
                recipe.AddIngredient(ItemID.YellowPaint, 10);
                recipe.AddIngredient(ItemID.RedPaint, 10);
                recipe.AddIngredient(ItemID.PillarStatue, 1);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this, 5);
                recipe.AddRecipe(); 
                
                recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Gel, 200);
                recipe.AddIngredient(ItemID.PurplePaint, 10);
                recipe.AddIngredient(ItemID.YellowPaint, 10);
                recipe.AddIngredient(ItemID.RedPaint, 10);
                recipe.AddIngredient(ItemID.ArmorStatue, 2);
                recipe.AddIngredient(ModContent.ItemType<Chemicals>(), 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this, 5);
                recipe.AddRecipe();
            }
        }

    }

    public class BuildingKit : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons the stationary turret.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 5;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<LaserBoss>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
      //      recipe.AddIngredient(ModContent.ItemType<MatterManipulationPowder>(), 1);
            recipe.AddIngredient(ItemID.Chest, 1);
            recipe.AddIngredient(ItemID.IronBar, 15);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.WoodenHammer, 1);
            recipe.AddIngredient(ItemID.Wrench, 1);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class CultistInsignia : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons the cultist grandmaster.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = 10;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.

        public override void AddRecipes()
        {

            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ModContent.ItemType<DarkGem>(), 3);
                recipe.AddIngredient(ItemID.Ruby, 10);
                recipe.AddIngredient(ModContent.ItemType<VoidBar>(), 1);
                recipe.AddTile(TileID.MythrilAnvil);
                recipe.SetResult(this, 5);
                recipe.AddRecipe();
            }
        }


        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<SummonerBoss>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

    }

    public class TimeAndSpaceManipulator : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons the most horrifying being to exist.");
            ItemID.Sets.SortingPriorityBossSpawns[item.type] = 13; // This helps sort inventory know this is a boss summoning item.
        }

        public override void SetDefaults()
        {
            item.width = 20;
            item.height = 20;
            item.maxStack = 20;
            item.rare = ItemRarityID.Purple;
            item.useAnimation = 45;
            item.useTime = 45;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.UseSound = SoundID.Item44;
            item.consumable = true;
        }

        // We use the CanUseItem hook to prevent a player from using this item while the boss is present in the world.

        public override bool UseItem(Player player)
        {
            NPC.SpawnOnPlayer(player.whoAmI, ModContent.NPCType<GreenSlime>());
            Main.PlaySound(SoundID.Roar, player.position, 0);
            return true;
        }

        public override void AddRecipes()
        {
           
            if (ModContent.GetInstance<GlobalEffects>().HahaLol)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Gel, 50);
                recipe.SetResult(this, 20);
                recipe.AddRecipe();
            }
        }

    }
    public class CrunchyBunny : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Crunch.");
        }
        public override void SetDefaults()
        {
            item.UseSound = SoundID.Item2;                //this is the sound that plays when you use the item
            item.useStyle = 2;                 //this is how the item is holded when used
            item.useTurn = true;
            item.useAnimation = 17;
            item.useTime = 17;
            item.maxStack = 999;                 //this is where you set the max stack of item
            item.consumable = true;           //this make that the item is consumable when used
            item.width = 20;
            item.height = 28;
            item.value = Item.sellPrice(platinum: 999999999);
            item.rare = 1;
            return;
        }
    }

    [AutoloadEquip(EquipType.Body)]
    public class CactusCoverings : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Provide very powerful thorns in exchange for 8 defense.");
        }



        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 9;
            item.defense -= 8;
        }

        public override void UpdateEquip(Player player)
        {
            player.thorns += 12f; //movement speed
        }

    }

    [AutoloadEquip(EquipType.Legs)]
    public class SwiftSneakers : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increases player's movement speed, mining speed, placing speed, minion count, sentry count, and allows dashing in exchange for 8 defense.");
        }



        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 0;
            item.rare = 9;
            item.defense -= 8;
        }

        public override void UpdateEquip(Player player)
        {

            player.accRunSpeed += 20;

            player.maxRunSpeed += 40;

            player.dash = 1;

            player.maxTurrets += 1;

            player.maxMinions += 1; //movement speed

            player.tileSpeed += 5f; //movement speed
            player.wallSpeed += 5f; //movement speed
            player.stepSpeed += 5f; //movement speed
            player.moveSpeed += 5f; //movement speed
            player.pickSpeed -= 0.5f; //movement speed
        }

    }

    public class EnergyGauntlet : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a powerful beam of invisible energy from your palm.");
        }

        public override void SetDefaults()
        {
            item.melee = true;
            item.channel = true; //Channel so that you can hold the weapon [Important]
            item.rare = ItemRarityID.Cyan;
            item.width = 28;
            item.height = 30;
            item.useTime = 20;
            item.UseSound = SoundID.Item13;
            item.autoReuse = true;
            item.shootSpeed = 14f;
            item.useAnimation = 20;
            item.value = Item.sellPrice(silver: 30);

            item.useStyle = 5;
            item.knockBack = 0.1f;
            item.useTime = 5;
            item.mana = 1;
            item.damage = 45;
            item.noUseGraphic = true;
            item.shoot = ModContent.ProjectileType<LSP>();
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
            recipe.AddIngredient(ItemID.TitanGlove, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
            recipe.AddIngredient(ItemID.PowerGlove, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
            recipe.AddIngredient(ItemID.MechanicalGlove, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.ChargedBlasterCannon, 1);
            recipe.AddIngredient(ItemID.FireGauntlet, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }




  


    public class AmberGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("An orange sword made out of smooth amber.");
        }

        public override void SetDefaults()
        {
            item.damage = 26;
            item.melee = true;
            item.width = 28;
            item.height = 34;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amber, 10);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class DiamondGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A white sword made out of glistening diamonds.");
        }

        public override void SetDefaults()
        {
            item.damage = 18;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Diamond, 10);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class RubyGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A red sword made out of vibrant rubies.");
        }

        public override void SetDefaults()
        {
            item.damage = 42;
            item.melee = true;
            item.width = 70;
            item.height = 70;
            item.useTime = 45;
            item.useAnimation = 45;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Ruby, 20);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class EmeraldGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A green sword made out of glossy emeralds.");
        }

        public override void SetDefaults()
        {
            item.damage = 5;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 6;
            item.useAnimation = 6;
            item.useStyle = 1;
            item.knockBack = 1;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Emerald, 20);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class SapphireGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A blue sword made out of dark sapphires.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 30;
            item.useAnimation = 30;
            item.useStyle = 1;
            item.knockBack = 15;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Sapphire, 30);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class TopazGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A yellow sword made out of cleanly cut topaz.");
        }

        public override void SetDefaults()
        {
            item.damage = 7;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 12;
            item.useAnimation = 12;
            item.useStyle = 1;
            item.knockBack = 6;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Topaz, 30);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
    public class AmethystGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A purple sword made out of captivating amethyst.");
        }

        public override void SetDefaults()
        {
            item.damage = 10;
            item.melee = true;
            item.width = 32;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 30);
            recipe.AddIngredient(ModContent.ItemType<Hilt>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class RainbowGemsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A sharp, multicolored sword made out of seven different gems.");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 50;
            item.height = 50;
            item.useTime = 13;
            item.useAnimation = 13;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 1000;
            item.rare = 2;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ModContent.ItemType<AmberGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<DiamondGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<SapphireGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<TopazGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<RubyGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<EmeraldGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<AmethystGemsword>(), 1);
            recipe.AddIngredient(ModContent.ItemType<LargeGem>(), 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class HellsStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A rare staff of endless burning flames.");
        }

        public override void SetDefaults()
        {
            item.damage = 30;
            item.magic = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 8;
            item.crit = 25;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.mana = 2;
            item.shoot = 400;
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            if (Main.rand.NextBool(30))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.InfernoFriendlyBolt, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.FireArrow, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ImpFireball, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.BallofFire, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.MolotovFire2, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Flamarang, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.Flamelash, damage, knockBack, player.whoAmI);
            }
            if (Main.rand.NextBool(20))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DD2FlameBurstTowerT2Shot, damage, knockBack, player.whoAmI);
            }
            return true;

        }
    }

    public class ShroomCannon : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots blazing glowing mushrooms.");
        }

        public override void SetDefaults()
        {
            item.damage = 15;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 13;
            item.crit = 25;
            item.useAnimation = 13;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.shoot = ModContent.ProjectileType<ShroomShot>() ;
            item.shootSpeed = 25f;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(45)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class SacrificialKnife : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Lose some health and have a chancce to shoot out a burst of unholy projectiles.");
        }

        public override void SetDefaults()
        {
            item.damage = 8;
            item.ranged = true;
            item.width = 64;
            item.height = 32;
            item.noUseGraphic = true;
            item.useTime = 32;
            item.crit = 25;
            item.useAnimation = 32;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.shoot = ModContent.ProjectileType<Sacrifice>();
            item.shootSpeed = 12f;
            item.UseSound = SoundID.Item17;
            item.autoReuse = false;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {

            if (Main.rand.NextBool(3))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.UnholyArrow, damage * 10, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.UnholyTridentFriendly, damage * 10, knockBack, player.whoAmI) ;
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DemonScythe, damage * 10, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.DarkLance, damage * 10, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.VampireKnife, damage * 10, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ShadowFlame, damage * 10, knockBack, player.whoAmI);
            }
            return true;

        }
    }

    public class DesertBoulderStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Launches a sandstone boulder.");
        }

        public override void SetDefaults()
        {
            item.damage = 45;
            item.magic = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 40;
            item.crit = 25;
            item.useAnimation = 40;
            item.useStyle = 5;
            item.knockBack = 5;
            item.value = 3000;
            item.rare = 4;
            item.mana = 5;
            item.shoot = ModContent.ProjectileType<DesertBoulder>();
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item78;
            item.autoReuse = true;
        }

    }


    public class ChainHookShockwave : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons a bunch of hooks on chains.");
        }
        public override void SetDefaults()
        {

            item.damage = 15;
            item.magic = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 3;
            item.value = 3000;
            item.rare = 4;
            item.UseSound = SoundID.Item14;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<Hook>();
            item.shootSpeed = 8f;
            item.mana = 10;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            float numberProjectiles = 8;
            float rotation = MathHelper.ToRadians(180);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 180f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class DualBarrelMinigun : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots two bullets at high speeds. " +
                "50% chance not to consume ammo.");
        }
        public override void SetDefaults()
        {

            item.damage = 15;
            item.ranged = true;
            item.width = 0;
            item.height = 0;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.UseSound = SoundID.Item11;
            item.autoReuse = true;
            item.shoot = 1;
            item.shootSpeed = 7f;
            item.useAmmo = AmmoID.Bullet;
        }

        public override bool ConsumeAmmo(Player player)
        {
            return Main.rand.NextFloat() >= .5f;
        }
        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2; // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 30 degree spread.
                                                                                                               // If you want to randomize the speed to stagger the projectiles
                                                                                                               // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                               // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }


        public override void AddRecipes()
        {
            if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
            {
                ModRecipe recipe = new ModRecipe(mod);
                recipe.AddIngredient(ItemID.Minishark, 2);
                recipe.AddTile(TileID.TinkerersWorkbench);
                recipe.SetResult(this);
                recipe.AddRecipe();
            }
        }
				
    }
    public class HighPressureHose : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a high power stream of water.");
        }

        public override void SetDefaults()
        {
            item.damage = 22;
            item.ranged = true;
            item.width = 30;
            item.height = 12;
            item.noUseGraphic = false;
            item.useTime = 2;
            item.crit = 25;
            item.useAnimation = 2;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.shoot = 22;
            item.shootSpeed = 20f;
            item.UseSound = SoundID.Item13;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(3)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
        
    }

    public class CondensedWaterBucket : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Pours water used as an attack instead of a tile.");
        }

        public override void SetDefaults()
        {
            item.damage = 40;
            item.ranged = true;
            item.width = 30;
            item.height = 12;
            item.noUseGraphic = true;
            item.useTime = 23;
            item.maxStack = 999;
            item.crit = 6;
            item.useAnimation = 23;
            item.useStyle = 5;
            item.knockBack = 3;
            item.value = 100;
            item.rare = 2;
            item.shoot = 22;
            item.shootSpeed = 3f;
            item.UseSound = SoundID.Item13;
            item.consumable = true;
            item.autoReuse = false;
            
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 5 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(8)); // 30 degree spread.
                                                                                                               // If you want to randomize the speed to stagger the projectiles
                                                                                                               // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                               // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

        public override void AddRecipes()
        {

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBucket, 1);
            recipe.AddTile(TileID.Sinks);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        }

    public class SunshineStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons rays of sunlight to rain upon your enemies.");
        }

        public override void SetDefaults()
        {
            item.damage = 17;
            item.magic = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 20;
            item.crit = 30;
            item.useAnimation = 20;
            item.useStyle = 3;
            item.knockBack = 1;
            item.value = 3000;
            item.rare = 4;
            item.mana = 4;
            item.shoot = ModContent.ProjectileType<Sunlight>();
            item.shootSpeed = 10f;
            item.UseSound = SoundID.Item43;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 12 + Main.rand.Next(2);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-2, 2) * 0.4f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
    }

    public class CrescentMoonBoomerang : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throw numerous small crescent moons.");
        }

        public override void SetDefaults()
        {
            item.damage = 20;
            item.melee = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 20;
            item.crit = 10;
            item.useAnimation = 20;
            item.noUseGraphic = true;
            item.useStyle = 1;
            item.knockBack = 3;
            item.value = 3000;
            item.rare = 4;
            item.shoot = ModContent.ProjectileType<Crescent>();
            item.shootSpeed = 17f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

    }
    
    public class WaterDagger : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a stream of water forward.");
        }

        public override void SetDefaults()
        {
            item.damage = 16;
            item.melee = true;
            item.width = 64;
            item.height = 32;
            item.useTime = 8;
            item.crit = 10;
            item.useAnimation = 8;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 3000;
            item.rare = 4;
            item.shoot = 27;
            item.shootSpeed = 13f;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

    }

    internal class MusicBoxGrandmasterTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MusicBoxCultistGrandmaster"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("MusicBoxCultistGrandmaster");
        }
    }

    public class MusicBoxCultistGrandmaster : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Cultist Grandmaster)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxGrandmasterTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }

    internal class MusicBoxSpaceTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MusicBoxSpace"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("MusicBoxSpace");
        }
    }

    public class MusicBoxSpace : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (God of Space)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxSpaceTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }


    internal class MusicBoxPillarsTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MusicBoxPillars"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("MusicBoxPillars");
        }
    }

    public class MusicBoxPillars : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Slimy Pillars)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxPillarsTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }


    internal class MusicBoxTurretTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MusicBoxTurret"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("MusicBoxTurret");
        }
    }

    public class MusicBoxTurret : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Stationary Turret)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxTurretTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }


    internal class MusicBoxSlimeTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("SlimeMusicBox"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("SlimeMusicBox");
        }
    }

    public class SlimeMusicBox : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Green Slime)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxSlimeTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }

    internal class MusicBoxMemoriesTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileObsidianKill[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style2x2);
            TileObjectData.newTile.Origin = new Point16(0, 1);
            TileObjectData.newTile.LavaDeath = false;
            TileObjectData.newTile.DrawYOffset = 2;
            TileObjectData.addTile(Type);
            
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Music Box");
            AddMapEntry(new Color(200, 200, 200), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType("MusicBoxMemories"));
        }

        public override void MouseOver(int i, int j)
        {
            Player player = Main.LocalPlayer;
            player.noThrow = 2;
            player.showItemIcon = true;
            player.showItemIcon2 = mod.ItemType("MusicBoxMemories");
        }
    }

    public class MusicBoxMemories : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Music Box (Memories)");
        }

        public override void SetDefaults()
        {
            item.useStyle = 1;
            item.useTurn = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.autoReuse = true;
            item.consumable = true;
            item.createTile = mod.TileType("MusicBoxMemoriesTile");
            item.width = 24;
            item.height = 24;
            item.rare = 4;
            item.value = 100000;
            item.accessory = true;
        }
    }
    /*public class Flashlight : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Casts a bright light ahead of you.");
        }

        public override void SetDefaults()
        {
            item.channel = true; //Channel so that you can hold the weapon [Important]
            item.rare = ItemRarityID.Green;
            item.width = 28;
            item.height = 30;
            item.useTime = 2;
            item.UseSound = SoundID.Item13;
            item.shootSpeed = 14f;
            item.useAnimation = 2;
            item.value = Item.sellPrice(silver: 75);
            item.damage = 0;

            item.useStyle = 5;
            item.knockBack = 0f;
            item.mana = 0;
            item.shoot = ModContent.ProjectileType<("Light");
        }


        public override void AddRecipes()
        {

            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.UltrabrightTorch, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.UltrabrightTorch, 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddIngredient(ItemID.IronBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.Torch, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();


            recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Lens, 1);
            recipe.AddIngredient(ItemID.LeadBar, 10);
            recipe.AddIngredient(ItemID.Wire, 50);
            recipe.AddIngredient(ItemID.Torch, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }*/
    public class GrandmastersSpellbook : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots the flames of the cultists.");
        }

        public override void SetDefaults()
        {
            item.damage = 120;
            item.magic = true;
            item.mana = 4;
            item.width = 56;
            item.height = 64;
            item.useTime = 8;
            item.crit = 15;
            item.useAnimation = 8;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 100000;
            item.rare = 9;
            item.shoot = ModContent.ProjectileType<FireballFriendly>();
            item.shootSpeed = 10;
            item.UseSound = SoundID.Item34;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 3 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X * 2, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }

    public class GrandmastersStaff : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Casts the magics of the dungeon.");
        }

        public override void SetDefaults()
        {
            item.damage = 110;
            item.magic = true;
            item.mana = 5;
            item.width = 56;
            item.height = 64;
            item.useTime = 14;
            item.crit = 18;
            item.useAnimation = 14;
            item.useStyle = 5;
            item.knockBack = 1;
            item.value = 100000;
            item.rare = 9;
            item.shoot = 10;
            item.shootSpeed = 10;
            item.UseSound = SoundID.Item43;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 1; // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 


                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.ShadowBeamFriendly, damage, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.LostSoulFriendly, damage, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.InfernoFriendlyBolt, damage, knockBack, player.whoAmI);
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ProjectileID.InfernoFriendlyBlast, damage, knockBack, player.whoAmI);
                return true;
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

    }

    public class GrandmastersScroll : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots red bolts in a circular formation.");
        }

        public override void SetDefaults()
        {
            item.damage = 66;
            item.magic = true;
            item.mana = 1;
            item.width = 56;
            item.height = 64;
            item.useTime = 6;
            item.crit = 10;
            item.useAnimation = 6;
            item.useStyle = 3;
            item.knockBack = 6;
            item.value = 100000;
            item.rare = 9;
            item.shoot = ModContent.ProjectileType<Lightning>();
            item.shootSpeed = 15;
            item.UseSound = SoundID.Item77;
            item.autoReuse = true;
        }


        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 10 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(360)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }

    }

    public class GrandmastersSigil : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons lasers over your head.");
        }

        public override void SetDefaults()
        {
            item.damage = 115;
            item.magic = true;
            item.mana = 2;
            item.width = 56;
            item.height = 64;
            item.useTime = 5;
            item.crit = 10;
            item.useAnimation = 5;
            item.useStyle = 3;
            item.knockBack = 0.1f;
            item.value = 100000;
            item.rare = 9;
            item.shoot = 606;
            item.shootSpeed = 15;
            item.UseSound = SoundID.Item77;
            item.autoReuse = true;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 2 + Main.rand.Next(2); // 4 or 5 shots
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.
                                                                                                                // If you want to randomize the speed to stagger the projectiles
                                                                                                                // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                                // perturbedSpeed = perturbedSpeed * scale; 
                Projectile.NewProjectile(position.X, position.Y - 150, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            return false; // return false because we don't want tmodloader to shoot projectile
        }
    }
    public class GrandmastersContainmentChamber : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName and Tooltip are automatically set from the .lang files, but below is how it is done normally.
            // DisplayName.SetDefault("Paper Airplane");
             Tooltip.SetDefault("Summons a small grandmaster cultist");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = ModContent.ProjectileType<CultistPet>();
            item.buffType = BuffType<Buffs.GrandmasterCultistBuff>();
        }


        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffType, 3600, true);
            }
        }
    }

    public class CultistBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }
       
        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/

            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<SolarArmband>());
            }
            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersHealingPotion>());
            }
            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersHealingPotion>());
            }
            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersHealingPotion>());
            }
            if (Main.rand.Next(6) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
            }
            if (Main.rand.Next(6) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
            }
            if (Main.rand.Next(6) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
            }
            if (Main.rand.Next(6) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
            }
            if (Main.rand.Next(10) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
            }
        }

        public override int BossBagNPC => ModContent.NPCType<SummonerBoss>();
    }

    public class SlimeBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 99999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
                player.QuickSpawnItem(ItemID.Gel, 1);
            
        }

        public override int BossBagNPC => NPCID.GreenSlime;
    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class SolarArmband : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Periodically shoots cultist fireballs at your cursor.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 100000;
            item.expert = true;
            item.rare = ItemRarityID.Expert;
            item.accessory = true;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 120)
            {
                //Code
            
            

                   Vector2 position = player.Center;
                   Vector2 targetPos = Main.MouseWorld;
                   Vector2 direction = targetPos - position;
                   direction.Normalize();
                   float speed = 10f;
                       int type = ModContent.ProjectileType<FireballFriendly>();
                   Projectile.NewProjectile(position, direction * speed, type, 100, 1, Main.myPlayer);
                       //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                       //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                       // Our timer has finished, do something here:
                       // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

                       lomu = 0;

               // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }


           
        }

    }

    [AutoloadEquip(EquipType.HandsOn)]
    public class SlimyWristband : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots slimes perioically.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 1000;
            item.expert = true;
            item.rare = ItemRarityID.Expert;
            item.accessory = true;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {



       /* public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
            type = Main.rand.Next(new int[] { ProjectileID.VenomArrow, ProjectileID.VampireKnife, ProjectileID.WaterBolt, ProjectileID.PhantasmArrow,
                ProjectileID.GoldenBullet, ProjectileID.WaterBolt, ProjectileID.PoisonedKnife, ProjectileID.QuarterNote,
                  ProjectileID.Flames, ProjectileID.Boulder, ProjectileID.LightDisc, ProjectileID.ChlorophyteOrb, ProjectileID.MagnetSphereBall,
                 ProjectileID.DeathSickle, ProjectileID.FlamingScythe, ProjectileID.NorthPoleSpear, ProjectileID.PulseBolt, ProjectileID.MolotovCocktail,
                  ProjectileID.Flairon, ProjectileID.ElectrosphereMissile, ProjectileID.CursedDart, ProjectileID.Daybreak,
                ProjectileID.ChlorophyteBullet, ProjectileID.Meowmere,  });
            return true;
        }*/



        lomu++;
            if (lomu > 80)
            {
                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;

                // Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<GreenSlimep>(), ModContent.ProjectileType<BlueSlime>(), ModContent.ProjectileType<RedSlime>(),
                //  ModContent.ProjectileType<PurpleSlime>(), ModContent.ProjectileType<YellowSlime>()}), 100, 1, Main.myPlayer);
                Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<RedSlime>()}), 100, 1, Main.myPlayer);
                lomu = 0;


                return;
            }
             


        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class CopperBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every 5 seconds.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 100;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
            item.damage = 10;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 300)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

                lomu = 0;


                Main.PlaySound(SoundID.Item5, 0);
                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.CopperWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class TinBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every 5 seconds.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 100;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
            item.damage = 10;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 300)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


                Main.PlaySound(SoundID.Item5, 0);
                lomu = 0;

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TinWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class SilverBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every 3 seconds.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.damage = 10;
            item.value = 500;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 180)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


                Main.PlaySound(SoundID.Item5, 0);
                lomu = 0;

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SilverWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class TungstenBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every 3 seconds.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 500;
            item.rare = ItemRarityID.Blue;
            item.accessory = true;
            item.damage = 10;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 180)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

                lomu = 0;

                Main.PlaySound(SoundID.Item5, 0);

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.TungstenWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class GoldBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every second.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2500;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
            item.damage = 10;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 60)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


                Main.PlaySound(SoundID.Item5, 0);
                lomu = 0;

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }
    [AutoloadEquip(EquipType.HandsOn)]
    public class PlatinumBowWatch : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots a wooden arrow at your cursor every second.");
        }

        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;
            item.value = 2500;
            item.rare = ItemRarityID.Green;
            item.accessory = true;
            item.damage = 10;
        }

        int lomu = 0;
        public override void UpdateEquip(Player player)
        {




            lomu++;
            if (lomu > 60)
            {
                //Code



                Vector2 position = player.Center;
                Vector2 targetPos = Main.MouseWorld;
                Vector2 direction = targetPos - position;
                direction.Normalize();
                float speed = 10f;
                int type = ModContent.ProjectileType<WoodenArrowFalse>();
                Projectile.NewProjectile(position, direction * speed, type, 10, 1, Main.myPlayer);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                //NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
                // Our timer has finished, do something here:
                // Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
                lomu = 0;

                // (Vector2 position, Vector2 velocity, int type, int damage, float knockback, int Owner)



                Main.PlaySound(SoundID.Item5, 0);


            }



        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.PlatinumWatch, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 999);
            recipe.AddTile(TileID.Anvils);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }

    }

    public class TranslucentThrowingDaggers : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throw a ton of translucent daggers.");
        }
        public override void SetDefaults()
        {

            item.damage = 10;
            item.melee = true;
            item.width = 26;
            item.height = 26;
            item.useTime = 4;
            item.useAnimation = 4;
            item.useStyle = 1;
            item.noMelee = true;
            item.noUseGraphic = true;
            item.knockBack = 0;
            item.value = 5000;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<TranslucentDagger>();
            item.shootSpeed = 10f;
        }
    }

    public class CultistSummonerBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Cultist Summoner.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile");
            item.placeStyle = 0;
        }
    }

    public class OutcastMartianBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Outcast Martian.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "CultistSummonerBanner";
                    break;
                case 1:
                    item = "OutcastMartianBanner";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "SacrificedCultist";
                        break;
                    case 1:
                        type = "MartianOutcast";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }
        public class SmallSwordBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Small Sword.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
            {
                item.width = 10;
                item.height = 24;
                item.maxStack = 99;
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.rare = ItemRarityID.Blue;
                item.value = Item.buyPrice(0, 0, 10, 0);
                item.createTile = mod.TileType("BannerTile2");
                item.placeStyle = 0;
            }
        }

        public class MouthBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Mouth.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
            {
                item.width = 10;
                item.height = 24;
                item.maxStack = 99;
                item.useTurn = true;
                item.autoReuse = true;
                item.useAnimation = 15;
                item.useTime = 10;
                item.useStyle = ItemUseStyleID.SwingThrow;
                item.consumable = true;
                item.rare = ItemRarityID.Blue;
                item.value = Item.buyPrice(0, 0, 10, 0);
                item.createTile = mod.TileType("BannerTile2");
                item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
            }
        }

        public class BannerTile2 : ModTile
        {
            public override void SetDefaults()
            {
                Main.tileFrameImportant[Type] = true;
                Main.tileNoAttach[Type] = true;
                Main.tileLavaDeath[Type] = true;
                TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
                TileObjectData.newTile.Height = 3;
                TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
                TileObjectData.newTile.StyleHorizontal = true;
                // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
                TileObjectData.newTile.StyleWrapLimit = 111;
                TileObjectData.addTile(Type);
                dustType = -1;
                disableSmartCursor = true;
                ModTranslation name = CreateMapEntryName();
                name.SetDefault("Banner");
                AddMapEntry(new Color(13, 88, 130), name);
            }

            public override void KillMultiTile(int i, int j, int frameX, int frameY)
            {
                int style = frameX / 18;
                string item;
                switch (style)
                {
                    case 0:
                        item = "SmallSwordBanner";
                        break;
                    case 1:
                        item = "MouthBanner";
                        break;
                    default:
                        return;
                }
                Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
            }

            public override void NearbyEffects(int i, int j, bool closer)
            {
                if (closer)
                {
                    Player player = Main.LocalPlayer;
                    int style = Main.tile[i, j].frameX / 18;
                    string type;
                    switch (style)
                    {
                        case 0:
                            type = "SmallBlade";
                            break;
                        case 1:
                            type = "Mouth";
                            break;
                        default:
                            return;
                    }
                    player.NPCBannerBuff[mod.NPCType(type)] = true;
                    player.hasBanner = true;
                }
            }
            /* public override void SetSpriteEffects(int i, int j, ref SpriteEffects spriteEffects)
             {
                 if (i % 2 == 1)
                 {
                     spriteEffects = SpriteEffects.FlipHorizontally;
                 }
             }*/
        }

    public class AssassinBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Assassin.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile3");
            item.placeStyle = 0;
        }
    }

    public class FlyingBoulderBanner : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Flying Boulder.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile3");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile3 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "AssassinBanner";
                    break;
                case 1:
                    item = "FlyingBoulderBanner";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "Assassin";
                        break;
                    case 1:
                        type = "BoulderNPC";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }

    public class DarknessSlimeBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Darkness Slime.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile4");
            item.placeStyle = 0;
        }
    }

    public class LunarSpiritBanner : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Lunar Spirit.");

        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile4");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile4 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "DarknessSlimeBanner";
                    break;
                case 1:
                    item = "LunarSpiritBanner";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "DarknessSlime";
                        break;
                    case 1:
                        type = "LunarSpirit";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }

    public class AncientEyeBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Ancient Eye.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile5");
            item.placeStyle = 0;
        }
    }

    public class SparkBanner : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Spark.");

        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile5");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile5 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "AncientEyeBanner";
                    break;
                case 1:
                    item = "SparkBanner";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "AncientEye";
                        break;
                    case 1:
                        type = "Sparkle";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }

    public class DemonOfDarknessBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Demon Of Darkness.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile6");
            item.placeStyle = 0;
        }
    }

    public class RedSparkBanner : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Red Spark.");

        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile6");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile6 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "DemonOfDarknessBanner";
                    break;
                case 1:
                    item = "RedSpark";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "DarkDemon";
                        break;
                    case 1:
                        type = "RedSpark";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }

    public class MalfunctioningArrowBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Malfunctioning Arrow.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile7");
            item.placeStyle = 0;
        }
    }

    public class MalfunctioningBulletBanner : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Nearby players get a bonus against: Malfunctioning Bullet.");
        }
        // The tooltip for this item is automatically assigned from .lang files
        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 24;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.rare = ItemRarityID.Blue;
            item.value = Item.buyPrice(0, 0, 10, 0);
            item.createTile = mod.TileType("BannerTile7");
            item.placeStyle = 1;        //Place style means which frame(Horizontally, starting from 0) of the tile should be placed
        }
    }

    public class BannerTile7 : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileNoAttach[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileObjectData.newTile.CopyFrom(TileObjectData.Style1x2Top);
            TileObjectData.newTile.Height = 3;
            TileObjectData.newTile.CoordinateHeights = new[] { 16, 16, 16 };
            TileObjectData.newTile.StyleHorizontal = true;
            // TileObjectData.newTile.AnchorTop = new AnchorData(AnchorType.SolidTile | AnchorType.SolidSide | AnchorType.SolidBottom, TileObjectData.newTile.Width, 0);
            TileObjectData.newTile.StyleWrapLimit = 111;
            TileObjectData.addTile(Type);
            dustType = -1;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Banner");
            AddMapEntry(new Color(13, 88, 130), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int style = frameX / 18;
            string item;
            switch (style)
            {
                case 0:
                    item = "MalfunctioningArrowBanner";
                    break;
                case 1:
                    item = "MalfunctioningBulletBanner";
                    break;
                default:
                    return;
            }
            Item.NewItem(i * 16, j * 16, 16, 48, mod.ItemType(item));
        }

        public override void NearbyEffects(int i, int j, bool closer)
        {
            if (closer)
            {
                Player player = Main.LocalPlayer;
                int style = Main.tile[i, j].frameX / 18;
                string type;
                switch (style)
                {
                    case 0:
                        type = "StrayArrow";
                        break;
                    case 1:
                        type = "StrayBullet";
                        break;
                    default:
                        return;
                }
                player.NPCBannerBuff[mod.NPCType(type)] = true;
                player.hasBanner = true;
            }
        }
    }

    public class ChestOfSolarFury : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Unleash a blinding light with the fury of the sun.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 0f;
            item.damage = 175;
            item.knockBack = 0.1f;
            item.useStyle = ItemUseStyleID.HoldingUp;
            item.useAnimation = 120;
            item.useTime = 120;
            item.width = 30;
            item.height = 30;
            item.crit = 50;
            item.rare = 7;

            item.noMelee = true;
            item.autoReuse = false;
            item.melee = true;

            item.UseSound = SoundID.Item14;
            item.value = 10000;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = 10;
        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<SolarBlast>(), damage, knockBack, player.whoAmI);
            Projectile.NewProjectile(position.X, position.Y, speedX, speedY, ModContent.ProjectileType<SolarBlastRecoil>(), damage * 0, knockBack, player.whoAmI);
            return true;
        }





        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.LihzahrdPowerCell, 5);
            recipe.AddIngredient(ItemID.Chest, 1);
            recipe.AddTile(TileID.LihzahrdFurnace);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }

    public class Flashbang : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Unleash a blinding light.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 0f;
            item.damage = 15;
            item.knockBack = 0.35f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 120;
            item.useTime = 120;
            item.width = 30;
            item.height = 30;
            item.crit = 50;
            item.rare = 2;

            item.noMelee = true;
            item.noUseGraphic = true;
            item.consumable = true;
            item.maxStack = 999;
            item.autoReuse = false;
            item.melee = true;

            item.UseSound = SoundID.Item14;
            item.value = 10000;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<FlashBlast>();
        }


        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Grenade, 1);
            recipe.AddIngredient(ItemID.Torch, 1);

            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }


    [AutoloadEquip(EquipType.Head)]
    public class SuperVisionGoggles : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Increased sight, speed, armor penetration, and immunity to decreased vision effects.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 0;
            item.rare = 9;
            item.defense = 10;
        }

        public override void UpdateEquip(Player player)
        {
            player.buffImmune[BuffID.Darkness] = true;
            player.armorPenetration = 10;
            player.buffImmune[BuffID.Blackout] = true;
            player.moveSpeed += 0.1f; //movement speed
            player.nightVision = true;
        }

    }

    public class LaserBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/
            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ItemID.IronBar, 20);
            }
            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ItemID.LeadBar, 20);
            }
            if (Main.rand.Next(5) == 0)
            {
                player.QuickSpawnItem(ItemID.LaserRifle, 1);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.HealingPotion, 15);
            }
                player.QuickSpawnItem(mod.ItemType("LaserTurret"), 1);
            
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("DarkGem"), 2);
            }
            if (Main.rand.Next(8) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("MinorUpgrade"), 1);
            }

            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("Blaustein"), 75);
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(mod.ItemType("LightGem"), 2);
            }
        }

        public override int BossBagNPC => ModContent.NPCType<LaserBoss>();
    }
    public class SpaceBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/

            player.QuickSpawnItem(ModContent.ItemType<RodOfMindDecay>(), 1);

            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.FallenStar, 20);

            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<ManaSupercannon>(), 1);

            }
            if (Main.rand.Next(7) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<VoidMaterial>(), 15);

            }

            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.FallenStar, 20);

            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<VoidMaterial>(), 1);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofFlight, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofMight, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofFright, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofSight, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofNight, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.SoulofLight, 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<SoulOfDaylight>(), 20);

            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<SoulOfMidnight>(), 20);

            }
                player.QuickSpawnItem(ModContent.ItemType<DarkStar>(), 1);

            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<SoulOfTwilight>(), 20);

            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<SpaceGodsYoyo>(), 1);

            }
        }

        public override int BossBagNPC => ModContent.NPCType<SpaceBoss>();
    }
    [AutoloadEquip(EquipType.Head)]
    public class SpaceGodsMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A mask that looks like the legendary intergalactic alien.");
        }


        public override void SetDefaults()
        {
            item.width = 18;
            item.height = 18;

            item.value = 100000;
            item.rare = 5;
        }

    }


    public class PurpleBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/

            player.QuickSpawnItem(mod.ItemType("SlimyBlade"));
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.PurpleandSilverDye, 3);
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<PurpleSlimyShooter>(), 1);
            }

            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.PurpleandBlackDye, 3);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.DeepPurplePaint, 50);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.PillarStatue, 2);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.PurplePaint, 50);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.PurpleDye, 3);
            }
            NPC.NewNPC((int)player.Center.X - 20, (int)player.Center.Y - 200, NPCID.PurpleSlime, 0);

            NPC.NewNPC((int)player.Center.X - 10, (int)player.Center.Y - 200, NPCID.PurpleSlime, 0);

            NPC.NewNPC((int)player.Center.X + 10, (int)player.Center.Y - 200, NPCID.PurpleSlime, 0);

            NPC.NewNPC((int)player.Center.X + 20, (int)player.Center.Y - 200, NPCID.PurpleSlime, 0);

            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y - 200, NPCID.PurpleSlime, 0);

            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 20);
            }

            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 80);
            }

            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 150);
            }
        }

        public override int BossBagNPC => ModContent.NPCType<PurpleSlimyPillar>();
    }
    public class RedBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/


            player.QuickSpawnItem(mod.ItemType("SlimyWristband"));
            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 20);
            }
            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<RedSlimyShooter>(), 1);
            }

            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.RedandSilverDye, 3);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.RedandBlackDye, 3);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.PillarStatue, 2);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.DeepRedPaint, 50);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.RedPaint, 50);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.RedDye, 3);
            }
            NPC.NewNPC((int)player.Center.X - 20, (int)player.Center.Y - 200, NPCID.RedSlime, 0);

            NPC.NewNPC((int)player.Center.X - 10, (int)player.Center.Y - 200, NPCID.RedSlime, 0);

            NPC.NewNPC((int)player.Center.X + 10, (int)player.Center.Y - 200, NPCID.RedSlime, 0);

            NPC.NewNPC((int)player.Center.X + 20, (int)player.Center.Y - 200, NPCID.RedSlime, 0);

            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y - 200, NPCID.RedSlime, 0);

            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 80);
            }

            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 150);
            }
        }

        public override int BossBagNPC => ModContent.NPCType<RedSlimyPillar>();
    }
    public class YellowBag : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Treasure Bag");
            Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
        }

        public override void SetDefaults()
        {
            item.maxStack = 999;
            item.consumable = true;
            item.width = 24;
            item.height = 24;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
        }

        public override bool CanRightClick()
        {
            return true;
        }

        public override void OpenBossBag(Player player)
        {
            player.TryGettingDevArmor();
            /* if (Main.rand.NextBool(5))
             {
                 case 1:
                     { 
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersStaff>());
                     {
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSpellbook>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersSigil>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersScroll>());
                 player.QuickSpawnItem(ModContent.ItemType<GrandmastersContainmentChamber>());
             }*/

            player.QuickSpawnItem(mod.ItemType("SlimySceptre"));

            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ModContent.ItemType<YellowSlimyShooter>(), 1);
            }
            if (Main.rand.Next(1) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 20);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.YellowandSilverDye, 3);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.PillarStatue, 2);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.YellowandBlackDye, 3);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.YellowGradientDye, 3);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.DeepYellowPaint, 50);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.YellowPaint, 50);
            }
            if (Main.rand.Next(4) == 0)
            {
                player.QuickSpawnItem(ItemID.YellowDye, 3);
            }
            if (Main.rand.Next(2) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 80);
            }

            NPC.NewNPC((int)player.Center.X-20, (int)player.Center.Y - 200, NPCID.YellowSlime, 0);

            NPC.NewNPC((int)player.Center.X-10, (int)player.Center.Y - 200, NPCID.YellowSlime, 0);

            NPC.NewNPC((int)player.Center.X+10, (int)player.Center.Y - 200, NPCID.YellowSlime, 0);

            NPC.NewNPC((int)player.Center.X+20, (int)player.Center.Y - 200, NPCID.YellowSlime, 0);

            NPC.NewNPC((int)player.Center.X, (int)player.Center.Y - 200, NPCID.YellowSlime, 0);

            if (Main.rand.Next(3) == 0)
            {
                player.QuickSpawnItem(ItemID.Gel, 150);
            }
        }

        public override int BossBagNPC => ModContent.NPCType<YellowSlimyPillar>();
    }

    public class SlimyBlade : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Coated in a special gel that forms into a slime when swung.");
        }
        public override void SetDefaults()
        {
            item.damage = 80;
            item.magic = true;
            item.mana = 4;
            item.width = 28;
            item.height = 32;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 2;
            item.value = 3000;
            item.crit = 50;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.expert = true;
            item.shootSpeed = 10f;
            item.shoot = ModContent.ProjectileType<PurpleSlime>();


        }


        /* public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
         {
             // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
             type = Main.rand.Next(new int[] { ProjectileID.VenomArrow, ProjectileID.VampireKnife, ProjectileID.WaterBolt, ProjectileID.PhantasmArrow,
                 ProjectileID.GoldenBullet, ProjectileID.WaterBolt, ProjectileID.PoisonedKnife, ProjectileID.QuarterNote,
                   ProjectileID.Flames, ProjectileID.Boulder, ProjectileID.LightDisc, ProjectileID.ChlorophyteOrb, ProjectileID.MagnetSphereBall,
                  ProjectileID.DeathSickle, ProjectileID.FlamingScythe, ProjectileID.NorthPoleSpear, ProjectileID.PulseBolt, ProjectileID.MolotovCocktail,
                   ProjectileID.Flairon, ProjectileID.ElectrosphereMissile, ProjectileID.CursedDart, ProjectileID.Daybreak,
                 ProjectileID.ChlorophyteBullet, ProjectileID.Meowmere,  });
             return true;
         }*/


    //public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
   //     {
     //       Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(30)); // 30 degree spread.

            // Here we randomly set type to either the original (as defined by the ammo), a vanilla projectile, or a mod projectile.
      
     //   }

    }
    public class SlimySceptre : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Summons slimes as projectiles.");
        }
        public override void SetDefaults()
        {
            item.damage = 100;
            item.magic = true;
            item.mana = 4;
            item.width = 28;
            item.height = 32; 
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 5;
            item.knockBack = 2;
            item.value = 3000;
            item.crit = 50;
            item.rare = ItemRarityID.Expert;
            item.UseSound = SoundID.Item77;
            item.expert = true;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.shoot = ModContent.ProjectileType<YellowSlime>();


        }


    }

    public class RodOfMindDecay : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Decays the minds of nearby enemies.");
        }
        public override void SetDefaults()
        {
            item.damage = 30;
            item.magic = true;
            item.mana = 1;
            item.width = 30;
            item.height = 30;
            item.useTime = 10;
            item.useAnimation = 10;
            item.useStyle = 3;
            item.knockBack = 0.1f;
            item.value = 30000;
            item.crit = 15;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
            item.autoReuse = true;
            item.shootSpeed = 10f;
            item.shoot = ModContent.ProjectileType<MindDecay>();


        }


    }

    public class LaserTurret : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Attack like the sationary turret.");
        }
        public override void SetDefaults()

        {


            item.damage = 35;
            item.ranged = true;
            item.width = 200;
            item.height = 200;
            item.useTime = 16;
            item.useAnimation = 16;
            item.crit = 75;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
            item.UseSound = SoundID.Item33;
            item.autoReuse = true;
            item.shoot = ModContent.ProjectileType<ElectricOrb>();
            item.shootSpeed = 100f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, ModContent.ProjectileType<EyeBeam>(), damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class YellowSlimyShooter : ModItem

    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots three slow yellow lasers forward.");
        }
        public override void SetDefaults()

        {


            item.damage = 65;
            item.ranged = true;
            item.width = 200;
            item.height = 200;
            item.useTime = 20;
            item.useAnimation = 20;
            item.crit = 50;
            item.useStyle = 5;
            item.noMelee = true;
            item.knockBack = 1;
            item.value = 2000;
            item.rare = ItemRarityID.Expert;
            item.expert = true;
            item.UseSound = SoundID.Item33;
            item.autoReuse = true;
            item.shoot = ProjectileID.IchorBullet;
            item.shootSpeed = 8f;

        }

        public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)

        {
            float numberProjectiles = 3;
            float rotation = MathHelper.ToRadians(15);
            position += Vector2.Normalize(new Vector2(speedX, speedY)) * 10f;
            for (int i = 0; i < numberProjectiles; i++)
            {
                Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .2f; // Watch out for dividing by 0 if there is only 1 projectile.
                Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, ModContent.ProjectileType<EyeBeam>(), damage, knockBack, player.whoAmI);
            }
            return false;
        }
    }

    public class PurpleTrophy : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true; // Necessary since Style3x3Wall uses AnchorWall
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 36;
            TileObjectData.addTile(Type);
            dustType = 7;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Trophy");
            AddMapEntry(new Color(120, 85, 60), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int item = 0;
            switch (frameX / 54)
            {
                case 0:
                    item = ItemType<PurpleSlimyPillarTrophy>();
                    break;
            }
            if (item > 0)
            {
                Item.NewItem(i * 16, j * 16, 48, 48, item);
            }
        }
    }
    public class BossTrophy : ModTile
    {
        public override void SetDefaults()
        {
            Main.tileFrameImportant[Type] = true;
            Main.tileLavaDeath[Type] = true;
            TileID.Sets.FramesOnKillWall[Type] = true; // Necessary since Style3x3Wall uses AnchorWall
            TileObjectData.newTile.CopyFrom(TileObjectData.Style3x3Wall);
            TileObjectData.newTile.StyleHorizontal = true;
            TileObjectData.newTile.StyleWrapLimit = 36;
            TileObjectData.addTile(Type);
            dustType = 7;
            disableSmartCursor = true;
            ModTranslation name = CreateMapEntryName();
            name.SetDefault("Trophy");
            AddMapEntry(new Color(120, 85, 60), name);
        }

        public override void KillMultiTile(int i, int j, int frameX, int frameY)
        {
            int item = 0;
            switch (frameX / 54)
            {
                case 0:
                    item = ItemType<CultistGrandmasterTrophy>();
                    break;
                case 1:
                    item = ItemType<StationaryTurretTrophy>();
                    break;
                case 2:
                    item = ItemType<YellowSlimyPillarTrophy>();
                    break;
                case 3:
                    item = ItemType<RedSlimyPillarTrophy>();
                    break;
                case 4:
                    item = ItemType<PurpleSlimyPillarTrophy>();
                    break;
                case 5:
                    item = ItemType<SkeletonTrophy>();
                    break;
                case 6:
                    item = ItemType<EyeTrophy>();
                    break;
                case 7:
                    item = ItemType<BeeTrophy>();
                    break;
                case 8:
                    item = ItemType<SunTrophy>();
                    break;
            }
            if (item > 0)
            {
                Item.NewItem(i * 16, j * 16, 48, 48, item);
            }
        }
    }
    public class CultistGrandmasterTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Cultist Grandmaster Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 0;
        }
    }
    public class StationaryTurretTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Stationary Turret Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 1;
        }
    }
    public class SunTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("God of Space Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 8;
        }
    }
    public class YellowSlimyPillarTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Pillar Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 2;
        }
    }
    public class PurpleSlimyPillarTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Pillar Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 4;
        }
    }
    public class RedSlimyPillarTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Slimy Pillar Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 3;
        }
    }

    public class SkeletonTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forgotten Memory Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 5;
        }
    }
    public class EyeTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forgotten Memory Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 6;
        }
    }
    public class BeeTrophy : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Forgotten Memory Trophy");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 30;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.consumable = true;
            item.value = 50000;
            item.rare = ItemRarityID.Blue;
            item.createTile = mod.TileType("BossTrophy");
            item.placeStyle = 7;
        }
    }

    public class BackfiringBoxThrower : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Throw a sphere that shoots arrows at your cursor.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 10f;
            item.damage = 10;
            item.knockBack = 5f;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 30;
            item.height = 30;
            item.crit = 10;
            item.rare = 3;

            item.noUseGraphic = true;
            item.noMelee = true;
            item.autoReuse = true;
            item.ranged = true;

            item.UseSound = SoundID.Item1;
            item.value = 10000;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<BowBackfirer>();
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }
    }
    public class RedSlimyShooter : ModItem
    {
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Shoots what could be described as a firework display of flaming arrows.");
        }
        public override void SetDefaults()
        {
            // Alter any of these values as you see fit, but you should probably keep useStyle on 1, as well as the noUseGraphic and noMelee bools
            item.shootSpeed = 10f;
            item.damage = 35;
            item.knockBack = 1f;
            item.useStyle = ItemUseStyleID.HoldingOut;
            item.useAnimation = 30;
            item.useTime = 30;
            item.width = 30;
            item.height = 30;
            item.crit = 8;
            item.rare = 6;

            item.noUseGraphic = false;
            item.noMelee = true;
            item.autoReuse = true;
            item.ranged = true;

            item.UseSound = SoundID.NPCHit1;
            item.value = 10000;
            // Look at the javelin projectile for a lot of custom code
            // If you are in an editor like Visual Studio, you can hold CTRL and Click ExampleJavelinProjectile
            item.shoot = ModContent.ProjectileType<Slimelauncher>();
        }

        public override bool CanUseItem(Player player)
        {
            // Ensures no more than one spear can be thrown out, use this when using autoReuse
            return player.ownedProjectileCounts[item.shoot] < 1;
        }
    }
}




/*public class ThiccShotgun : ModItem
{
    public override void SetStaticDefaults()
    {
        Tooltip.SetDefault("overboard.");

    }
    public override void SetDefaults()
    {

        item.damage = 24;
        item.ranged = true;
        item.width = 40;
        item.height = 20;
        item.useStyle = ItemUseStyleID.HoldingOut;
        item.useTime = 60;
        item.useAnimation = 60;
        item.useStyle = 5;
        item.noMelee = true;
        item.knockBack = 6.5f;
        item.value = 50000;
        item.rare = 2;
        item.UseSound = SoundID.Item36;
        item.autoReuse = true;
        item.shoot = 1;
        item.shootSpeed = 7f;
        item.useAmmo = AmmoID.Bullet;
    }

    public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
    {
        int numberProjectiles = 13 + Main.rand.Next(2); // 4 or 5 shots
        for (int i = 0; i < numberProjectiles; i++)
        {
            Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(20)); // 30 degree spread.
                                                                                                            // If you want to randomize the speed to stagger the projectiles
                                                                                                            // float scale = 1f - (Main.rand.NextFloat() * .3f);
                                                                                                            // perturbedSpeed = perturbedSpeed * scale; 
            Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
        }
        return false; // return false because we don't want tmodloader to shoot projectile
    }
    public override void AddRecipes()
    {
        ModRecipe recipe = new ModRecipe(mod);
        recipe.AddIngredient(ItemID.BlackDye, 3);
        recipe.AddIngredient(ItemID.Shotgun, 5);
        recipe.AddTile(TileID.anvils);

        recipe.SetResult(this);
        recipe.AddRecipe();
    }
}*/


/*public class EndlessLuminiteArrowQuiver : ModItem
{
    public override void SetStaticDefaults()
    {
        Tooltip.SetDefault("It's time for the REAL fun to begin now...");
    }

    public override void SetDefaults()
    {
        item.damage = 15;
        item.ranged = true;
        item.width = 8;
        item.height = 8;
        item.consumable = false;             //You need to set the item consumable so that the ammo would automatically consumed
        item.knockBack = 3.5f;
        item.shoot = 639;   //The projectile shoot when your weapon using this ammo
        item.shootSpeed = 3f;
        item.ammo = AmmoID.Arrow;
    {
public override void AddRecipes()
{
    ModRecipe recipe = new ModRecipe(mod); ModRecipe recipe = new ModRecipe(mod);
                    recipe.AddIngredient(ItemID.EndlessQuiver, 1);
                    recipe.AddIngredient(ItemID.MoonlordArrow, 3996);
                    recipe.SetResult(this);
                    recipe.AddRecipe();
    recipe.AddTile(TileID.Anvils);
    recipe.SetResult(this);
    recipe.AddRecipe();
}

        }
    }
}*/



/*public class Sound : ModSound
{
    public override void PlaySound(ref SoundEffectInstance, SoundInstance, float volume, float pan, SoundType type)
    {
        soundInstance = sound.CreateInstance();
        soundInstance.Volume = volume * 0.5f;
        soundInstance.Pan = pan;
        soundInstance.Pitch = -1.0f;
        Main.PlaySoundInstance(SongMusic);
    }
}*/

/*  public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
 *  
{

    target.AddBuff(70, 180, false); //The debuff inflicted is the modded debuff Ethereal Flames. 180 is the duration in frames: Terraria runs at 60 FPS, so that's 3 seconds (180/60=3). To change the modded debuff, change EtherealFlames to whatever the buff is called; to add a vanilla debuff, change mod.BuffType("EtherealFlames") to a number based on the terraria buff IDs. Some useful ones are 20 for poison, 24 for On Fire!, 39 for Cursed Flames, 69 for Ichor, and 70 for Venom.

}*/



/*public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
       { 
            if (Main.rand.NextBool(15))
            {
                Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, player.whoAmI);
            }
            else
            {
                type = ProjectileID.BulletHighVelocity;
            }   return true;
        }*/
