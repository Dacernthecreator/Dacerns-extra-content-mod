
using Microsoft.Xna.Framework;
using System.ComponentModel;
using System.Media;
using Terraria;
using Terraria.ID;
using System.Collections.Generic;
using Terraria.ModLoader;
using Dacern.FriendlyNPC;
using Dacern.Items.Materials;
using Dacern.Items;
using Dacern.Enemies;
//using Dacern.DacernPlayer;
using Dacern;
using System.Security.Cryptography.X509Certificates;
//using Dacern.misc;

//projectile.CloneDefaults

namespace Dacern.Projectiles
{
	public class Baseball : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Baseball");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

	}

	public class Electricsphere : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Electrosphere");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ElectrosphereMissile);
			projectile.hostile = true;
			projectile.damage = 50;
		}

	}
	public class Dora : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dora Dora Dora the explorer, who's that super cool exploradora? Need your help Grab your backpacks");
		}

		public override void SetDefaults()
		{
			projectile.width = 60;
			projectile.height = 87;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
			projectile.ranged = true;
		}

	}

	public class MechaPiranha : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("piranha machine gun");
		}

		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 24;
			projectile.aiStyle = 39;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 600;
			projectile.ranged = true;
		}
		public override void AI()
		{
			Player player = Main.player[projectile.owner];

			// By separating large AI into methods it becomes very easy to see the flow of the AI in a broader sense
			// First we update player variables that are needed to channel the laser
			// Then we run our charging laser logic
			// If we are fully charged, we proceed to update the laser's position
			// Finally we spawn some effects like dusts and light
			projectile.rotation = projectile.velocity.ToRotation();
			//UpdatePlayer(player);

			{
				Main.projFrames[projectile.type] = 4;
			}
		}


		private void ChargeLaser(Player player)
		{
			// Kill the projectile if the player stops channeling
			if (!player.channel)
			{
				projectile.Kill();
			}
		}
	}
	public class FamiliarBolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the familiar image");
		}

		public override void SetDefaults()
		{
			projectile.width = 60;
			projectile.height = 87;
			projectile.aiStyle = 107;
			projectile.damage = 10;
			projectile.hostile = true;
			projectile.ranged = true;
		}

	}
	public class Nauh : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nauh");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.damage = 0;
			projectile.aiStyle = 1;
			projectile.friendly = false;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

	}

	public class DesertBoulder : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("sandstone boulder");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 25;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

	}

	public class Sunlight : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("rays of light");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.light = 0.25f;
			projectile.friendly = true;
			projectile.magic = true;
		}

		public override void AI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Lighting.AddLight(projectile.position, 255f, 255f, 0f);
		}
	}

	public class ManaShot : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mana");
		}

		public override void SetDefaults()
		{
			projectile.width = 330;
			projectile.height = 360;
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.timeLeft = 240;
			projectile.friendly = true;
			projectile.magic = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	

	public class Sacrifice : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("cutting too deep..");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.hostile = true;

			projectile.melee = true;
			projectile.timeLeft = 1;
		}
    }
	public class Hook : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a hook on a chain");
			
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 13;
			projectile.friendly = true;
			projectile.magic = true;
		}

	}

	public class SlimeBall : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy Ball");

		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 18;
			projectile.aiStyle = 0;
			projectile.hostile = true;
			projectile.aiStyle = 600;
			projectile.magic = true;
			projectile.tileCollide = false;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class SlimySpike : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy spike");

		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.WoodenArrowHostile);
			projectile.tileCollide = false;
		}

	}
	public class SlimySpikep : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy spike");

		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.WoodenArrowHostile);
			projectile.tileCollide = false;
		}

	}
	public class SlimySpikey : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy spike");

		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.WoodenArrowHostile);
			projectile.tileCollide = false;
		}

	}
	public class SolarBlast : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("an explosion of solar energy");
		}

		public override void SetDefaults()
		{
			projectile.width = 3000;
			projectile.height = 3000;
			projectile.aiStyle = 123;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.melee = true;
			
			projectile.timeLeft = 10;
		}

		public override void AI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Lighting.AddLight(projectile.position, 254f, 132f, 6f);

		}
		public override void DrawBehind(int index, List<int> drawCacheProjsOverNPCsAndTiles, List<int> drawCacheProjsOverNPCs, List<int> drawCacheProjsOverProjectiles, List<int> drawCacheProjsOverWiresUI)
		{
			// Add this projectile to the list of projectiles that will be drawn BEFORE tiles and NPC are drawn. This makes the projectile appear to be BEHIND the tiles and NPC.
			drawCacheProjsOverNPCsAndTiles.Add(index);
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Confused, 300, false);
			target.AddBuff(BuffID.OnFire, 120, false);
		}
	}

	public class MindDecay : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("their mind rotting into a mush");
		}

		public override void SetDefaults()
		{
			projectile.width = 3000;
			projectile.height = 3000;
			projectile.aiStyle = 123;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.magic = true;

			projectile.timeLeft = 1;
		}

	}
	public class FlashBlast : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("flashbang");
		}

		public override void SetDefaults()
		{
			projectile.width = 3000;
			projectile.height = 3000;
			projectile.aiStyle = 123;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.melee = true;

			projectile.timeLeft = 10;
		}

		public override void AI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Lighting.AddLight(projectile.position, 255f, 255f, 255f);

		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Confused, 300, false);
		}
	}

	public class SolarBlastRecoil : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("an explosion of solar energy");
		}

		public override void SetDefaults()
		{
			projectile.width = 3000;
			projectile.height = 3000;
			projectile.aiStyle = 123;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.melee = true;
			projectile.damage = 0;
			projectile.timeLeft = 10;
		}


		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.Blackout, 180, false);
		}
	}
	public class Lightning : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red lightning");

		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.magic = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}

	public class Crescent : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the moon");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 3;
			projectile.penetrate = -1;
			projectile.light = 0.25f;
			projectile.friendly = true;
			projectile.melee = true;
		}

	}

	public class IceMistFriendly : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ice blast");
		}

		
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CultistBossIceMist);
            projectile.hostile = false;
			projectile.friendly = true;
		}

	}

	public class IceFriendly : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("CultistIce");
		}


		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CultistBossIceMist);
			projectile.aiStyle = 0;
			projectile.penetrate = -1;
			projectile.light = 0.1f;
			projectile.magic = true;
			projectile.hostile = false;
			projectile.width = 22;
			projectile.height = 62;
			projectile.timeLeft = 60;
			projectile.friendly = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}

	public class LightningFriendly : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightning");
		}


		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.CultistBossLightningOrbArc);
			projectile.hostile = false;
			projectile.friendly = true;
		}

	}
	public class MissileFriendly : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rocket");
		}


		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.SaucerMissile);
			projectile.hostile = false;
			projectile.friendly = true;
		}

	}
	public class CultistPet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			// DisplayName.SetDefault("Paper Airplane"); // Automatic from .lang files
			Main.projFrames[projectile.type] = 4;
			Main.projPet[projectile.type] = true;
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.ZephyrFish);
			aiType = ProjectileID.ZephyrFish;
		}

		public override bool PreAI()
		{
			Player player = Main.player[projectile.owner];
			player.zephyrfish = false; // Relic from aiType
			return true;
		}

		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			DacernPlayer.Dacerncontroller modPlayer = player.GetModPlayer<DacernPlayer.Dacerncontroller>();
			if (player.dead)
			{
				modPlayer.CultPet = false;
			}
			if (modPlayer.CultPet)
			{
				projectile.timeLeft = 2;
			}
		}
	}

	public class FireballFriendly : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cultist fireball");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
		public override void AI()
		{
			{
				Main.projFrames[projectile.type] = 4;
			}

		}
	}

	public class RedSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Slime");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.penetrate = 2;
			projectile.friendly = true;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class YellowSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("YellowSlime");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.penetrate = 2;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class BlueSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blue Slime");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class GreenSlimep : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Slime");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class BowBackfirer : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Impossible");
		}

		public override void SetDefaults()
		{
			projectile.width = 0;
			projectile.timeLeft = 120;
			projectile.height = 0;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, ModContent.ProjectileType<WoodenArrowFalse>(), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
		}
		int lomu = 0;
		public override void AI()
		{
			//projectile.rotation = Main.MouseWorld;

			lomu++;
			if (lomu > 10)
			{
				
				Vector2 position = projectile.Center;
				Vector2 targetPos = Main.MouseWorld;
				Vector2 direction = targetPos - position;
				direction.Normalize();
				float speed = 10f;

				// Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<GreenSlimep>(), ModContent.ProjectileType<BlueSlime>(), ModContent.ProjectileType<RedSlime>(),
				//  ModContent.ProjectileType<PurpleSlime>(), ModContent.ProjectileType<YellowSlime>()}), 100, 1, Main.myPlayer);
				Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<WoodenArrowFalse>() }), 100, 1, Main.myPlayer);
				lomu = 0;


				return;
			}



		}
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class Slimelauncher : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Impossible");
		}

		public override void SetDefaults()
		{
			projectile.width = 0;
			projectile.timeLeft = 60;
			projectile.height = 0;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.NPCDeath1, Main.MouseWorld);

			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, ModContent.ProjectileType<MegaSlime>(), projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
		}
	}
	public class MegaSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Impossible");
		}

		public override void SetDefaults()
		{
			projectile.width = 0;
			projectile.timeLeft = 180;
			projectile.height = 0;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

		int lomu = 0;
		public override void AI()
		{
			//projectile.rotation = Main.MouseWorld;

			lomu++;
			if (lomu > 50)
			{

				Vector2 position = projectile.Center;
				Vector2 targetPos = Main.MouseWorld;
				Vector2 direction = targetPos - position;
				direction.Normalize();
				float speed = 10f;

				// Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<GreenSlimep>(), ModContent.ProjectileType<BlueSlime>(), ModContent.ProjectileType<RedSlime>(),
				//  ModContent.ProjectileType<PurpleSlime>(), ModContent.ProjectileType<YellowSlime>()}), 100, 1, Main.myPlayer);
				Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ProjectileID.FireArrow }), 35, 1, Main.myPlayer);
				lomu = 0;


				return;
			}



		}
	}

	public class PurpleSlime : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple slime");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 8;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.light = 0.1f;
			projectile.magic = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
	}

	public class WoodenArrowFalse : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Arrow");
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.damage = 1;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}

	public class WoodenArrowFalser : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Arrow");
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.aiStyle = 1;
			projectile.damage = 1;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override void Kill(int timeLeft)
		{
			// This code and the similar code above in OnTileCollide spawn dust from the tiles collided with. SoundID.Item10 is the bounce sound you hear.
			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
		}

	}

	public class TranslucentDagger : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Translucent Throwing Daggers");
		}

		public override void SetDefaults()
		{
			projectile.width = 12;
			projectile.alpha = 175;
			projectile.height = 25;
			projectile.damage = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
		}
		
	}
	public class Aura : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Defensive aura");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 107;
			projectile.friendly = true;
			projectile.timeLeft = 18;
			projectile.alpha = 80;
			projectile.magic = true;
		}

	}
	public class ShroomShot : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shroom shot");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle =8;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(BuffID.OnFire, 1000, false);
		}
		public override void AI()
        {
			{
				Main.projFrames[projectile.type] = 4;
			}

        }
    }
	public class ModGlobalProjectileWA : GlobalProjectile
	{
		public override void AI(Projectile projectile)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1700) == 0)
				{
					if (projectile.type == ProjectileID.WoodenArrowFriendly)
					{
						projectile.Kill();
						NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y, ModContent.NPCType<Strayarrow>());
					}
				}
			}
		}
	}
	public class ModGlobalProjectileBou : GlobalProjectile
	{
		public override void AI(Projectile projectile)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(3550) == 0)
				{
					if (projectile.type == ProjectileID.Boulder)
					{
						projectile.Kill();
						NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y, ModContent.NPCType<BoulderNPC>());
					}
				}
			}
		}
	}
	public class ModGlobalProjectileMB : GlobalProjectile
	{
		public override void AI(Projectile projectile)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1700) == 0)
				{
					if (projectile.type == ProjectileID.Bullet)
					{
						projectile.Kill();
						NPC.NewNPC((int)projectile.Center.X, (int)projectile.Center.Y, ModContent.NPCType<Straybullet>());
					}
				}
			}
		}
	}






	public class BlackholeBlast : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The void blade");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			Main.projFrames[projectile.type] = 4;
			projectile.aiStyle = 118;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.ranged = true;
		}

	}

	public class BlackholeBlaste : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a blackhole");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 118;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.ranged = true;
		}

	}
	public class BP1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dying");
		}

		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 1;
			projectile.hostile = true;
			projectile.damage = 10;
			projectile.penetrate = 0;
			projectile.ranged = true;
		}

	}
	public class Communism : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Communism");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class DestructiveArrow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Splitting arrow");
			//Sets.TrailCacheLength[projectile.type] = 5;
			//Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.timeLeft = 600;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

		public override void Kill(int timeLeft)
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
			/*if (projectile.ai[1] == 0f)
			{
				Vector2 vel = default(Vector2);
				for (int i = 0; i < 3; i++)
				{
					((Vector2)(ref vel))..ctor(Utils.NextFloat(Main.rand, -3f, 3f), Utils.NextFloat(Main.rand, -10f, -8f));
					Projectile.NewProjectile(projectile.get_Center(), vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0f, 1f);
				}
			}
			projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
			projectile.width = 10;
			projectile.height = 10;
			projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
			int explosionRadius = 3;
			explosionRadius = 7;
			_ = (int)(projectile.position.X / 16f - (float)explosionRadius);
			int maxTileX = (int)(projectile.position.X / 16f + (float)explosionRadius);
			int minTileY = (int)(projectile.position.Y / 16f - (float)explosionRadius);
			int maxTileY = (int)(projectile.position.Y / 16f + (float)explosionRadius);
			_ = 0;
			if (maxTileX > Main.maxTilesX)
			{
				maxTileX = Main.maxTilesX;
			}
			if (minTileY < 0)
			{
				minTileY = 0;
			}
			if (maxTileY > Main.maxTilesY)
			{
				maxTileY = Main.maxTilesY;
			}*/
		}

	}
	public class Deth : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dying");
		}

		public override void SetDefaults()
		{
			projectile.width = 128;
			projectile.height = 128;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 99;
			projectile.magic = true;
		}

	}
	public class Frick : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dying");
		}

		public override void SetDefaults()
		{
			projectile.width = 128;
			projectile.damage = 100;
			projectile.height = 128;
			projectile.aiStyle = 1;
			projectile.damage = 75;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

	}
	public class Dirt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dirt");
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class Elucidator : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elucidator");
		}

		public override void SetDefaults()
		{
			projectile.width = 64;
			projectile.damage = 50;
			projectile.height = 64;
			projectile.timeLeft = 180;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.aiStyle = 57;
			projectile.friendly = true;
			projectile.light = 100f;
			projectile.penetrate = -1;
			projectile.melee = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(20, 1000, false);
		}

	}
	public class Estobolt : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the estocade");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 77;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class Estocadep : ModProjectile
	{
		public float movementFactor
		{
			get
			{
				return projectile.ai[0];
			}
			set
			{
				projectile.ai[0] = value;
			}
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Estocade");
		}

		public override void SetDefaults()
		{
			projectile.width = 112;
			projectile.height = 112;
			projectile.aiStyle = 19;
			projectile.penetrate = -1;
			projectile.scale = 1.3f;
			projectile.alpha = 0;
			projectile.hide = true;
			projectile.ownerHitCheck = true;
			projectile.melee = true;
			projectile.tileCollide = false;
			projectile.friendly = true;
		}

		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0121: Unknown result type (might be due to invalid IL or missing references)
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		public override void AI()
		{
			// Since we access the owner player instance so much, it's useful to create a helper local variable for this
			// Sadly, Projectile/ModProjectile does not have its own
			Player projOwner = Main.player[projectile.owner];
			Vector2 ownerMountedCenter = projOwner.RotatedRelativePoint(projOwner.MountedCenter, true);
			projectile.direction = projOwner.direction;
			projOwner.heldProj = projectile.whoAmI;
			projOwner.itemTime = projOwner.itemAnimation;
			projectile.position.X = ownerMountedCenter.X - (float)(projectile.width / 2);
			projectile.position.Y = ownerMountedCenter.Y - (float)(projectile.height / 2);
			// As long as the player isn't frozen, the spear can move
			if (!projOwner.frozen)
			{
				if (movementFactor == 0f) // When initially thrown out, the ai0 will be 0f
				{
					movementFactor = 3f; // Make sure the spear moves forward when initially thrown out
					projectile.netUpdate = true; // Make sure to netUpdate this spear
				}
				if (projOwner.itemAnimation < projOwner.itemAnimationMax / 3) // Somewhere along the item animation, make sure the spear moves back
				{
					movementFactor -= 2.4f;
				}
				else // Otherwise, increase the movement factor
				{
					movementFactor += 2.1f;
				}
			}
			// Change the spear position based off of the velocity and the movementFactor
			projectile.position += projectile.velocity * movementFactor;
			// When we reach the end of the animation, we can kill the spear projectile
			if (projOwner.itemAnimation == 0)
			{
				projectile.Kill();
			}
			// Apply proper rotation, with an offset of 135 degrees due to the sprite's rotation, notice the usage of MathHelper, use this class!
			// MathHelper.ToRadians(xx degrees here)
			projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
			// Offset by 90 degrees here
			if (projectile.spriteDirection == -1)
			{
				projectile.rotation -= MathHelper.ToRadians(180f);
			}

			// These dusts are added later, for the 'ExampleMod' effect

		}
	}
	public class FamiliarArrow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Familiar arrow");
		}

		public override void SetDefaults()
		{
			projectile.width = 39;
			projectile.height = 39;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class GeyserBlast : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a geyser on a stick");
		}

		public override void SetDefaults()
		{
			projectile.width = 50;
			projectile.height = 50;
			projectile.aiStyle = 126;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
		}

	}
	public class Golem : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a flying golem like what the frick");
		}

		public override void SetDefaults()
		{
			projectile.width = 212;
			projectile.height = 208;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 180, false);
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class GunGun : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flintlock pistol");
		}

		public override void SetDefaults()
		{
			projectile.width = 36;
			projectile.height = 22;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class Hellarrow : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hell arrow");
			//Sets.TrailCacheLength[projectile.type] = 5;
			//Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.timeLeft = 600;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}
	}
	//public override void AI()
	//{
	//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
	//IL_013d: Unknown result type (might be due to invalid IL or missing references)
	//IL_0143: Unknown result type (might be due to invalid IL or missing references)
	/*int dustType = 127;
	if (projectile.timeLeft > 133)
	{
		projectile.timeLeft = 133;
	}
	if (projectile.ai[0] > 7f)
	{
		float dustScale = 1f;
		if (projectile.ai[0] == 8f)
		{
			dustScale = 0.2f;
		}
		else if (projectile.ai[0] == 9f)
		{
			dustScale = 0.4f;
		}
		else if (projectile.ai[0] == 10f)
		{
			dustScale = 0.6f;
		}
		else if (projectile.ai[0] == 11f)
		{
			dustScale = 0.8f;
		}
		projectile.ai[0] += 1f;
		for (int i = 0; i < 1; i++)
		{
			int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, dustType, projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 100, default(Color), 1f);
			Dust obj = Main.dust[dustIndex];
			obj.noGravity = true;
			obj.scale *= 1.75f;
			obj.velocity.X *= 2f;
			obj.velocity.Y *= 2f;
			obj.scale *= dustScale;
		}
	}
	else
	{
		projectile.ai[0] += 1f;
	}
	Projectile projectile = projectile;
	projectile.rotation += 0.3f * (float)projectile.direction;
}

}*/
	public class Hfireball : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavy fireball");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 32;
			projectile.timeLeft = 18000;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.aiStyle = 14;
			projectile.friendly = true;
			projectile.light = 0.01f;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

		public override void AI()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.owner == Main.myPlayer && Main.rand.Next(4) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 127, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 1000, false);
		}

	}

	public class LSF : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the gauntlet of energy");
		}

		public override void SetDefaults()
		{
			projectile.width = 5;
			projectile.height = 5;
			projectile.timeLeft = 600;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.aiStyle = 105;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

		public override void AI()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.owner == Main.myPlayer && Main.rand.Next(4) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 127, 0f, 0f, 0, default(Color), 1f);
			}
		}
	}

	public class LSP : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the energy gauntlet");
		}
		// Use a different style for constant so it is very clear in code when a constant is used

		// The maximum charge value
		private const float MAX_CHARGE = 50f;
		//The distance charge particle from the player center
		private const float MOVE_DISTANCE = 60f;

		// The actual distance is stored in the ai0 field
		// By making a property to handle this it makes our life easier, and the accessibility more readable
		public float Distance
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}

		// The actual charge value is stored in the localAI0 field
		public float Charge
		{
			get => projectile.localAI[0];
			set => projectile.localAI[0] = value;
		}

		// Are we at max charge? With c#6 you can simply use => which indicates this is a get only property
		public bool IsAtMaxCharge => Charge == MAX_CHARGE;

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.magic = true;
			projectile.hide = true;
		}

		// Change the way of collision check of the projectile
		public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
		{
			// We can only collide if we are at max charge, which is when the laser is actually fired
			if (!IsAtMaxCharge) return false;

			Player player = Main.player[projectile.owner];
			Vector2 unit = projectile.velocity;
			float point = 0f;
			// Run an AABB versus Line check to look for collisions, look up AABB collision first to see how it works
			// It will look for collisions on the given line using AABB
			return Collision.CheckAABBvLineCollision(targetHitbox.TopLeft(), targetHitbox.Size(), player.Center,
				player.Center + unit * Distance, 22, ref point);
		}

		// Set custom immunity time on hitting an NPC
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.immune[projectile.owner] = 5;
		}

		// The AI of the projectile
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			projectile.position = player.Center + projectile.velocity * MOVE_DISTANCE;
			projectile.timeLeft = 2;

			// By separating large AI into methods it becomes very easy to see the flow of the AI in a broader sense
			// First we update player variables that are needed to channel the laser
			// Then we run our charging laser logic
			// If we are fully charged, we proceed to update the laser's position
			// Finally we spawn some effects like dusts and light

			UpdatePlayer(player);
			ChargeLaser(player);

			// If laser is not charged yet, stop the AI here.
			if (Charge < MAX_CHARGE) return;

			SetLaserPosition(player);
			//SpawnDusts(player);
			CastLights();
		}

		/*private void SpawnDusts(Player player)
		{
			Vector2 unit = projectile.velocity * -1;
			Vector2 dustPos = player.Center + projectile.velocity * Distance;

			for (int i = 0; i < 2; ++i)
			{
				float num1 = projectile.velocity.ToRotation() + (Main.rand.Next(2) == 1 ? -1.0f : 1.0f) * 1.57f;
				float num2 = (float)(Main.rand.NextDouble() * 0.8f + 1.0f);
				Vector2 dustVel = new Vector2((float)Math.Cos(num1) * num2, (float)Math.Sin(num1) * num2);
				Dust dust = Main.dust[Dust.NewDust(dustPos, 0, 0, 226, dustVel.X, dustVel.Y)];
				dust.noGravity = true;
				dust.scale = 1.2f;
				dust = Dust.NewDustDirect(Main.player[projectile.owner].Center, 0, 0, 31,
					-unit.X * Distance, -unit.Y * Distance);
				dust.fadeIn = 0f;
				dust.noGravity = true;
				dust.scale = 0.88f;
				dust.color = Color.Cyan;
			}

			if (Main.rand.NextBool(5))
			{
				Vector2 offset = projectile.velocity.RotatedBy(1.57f) * ((float)Main.rand.NextDouble() - 0.5f) * projectile.width;
				Dust dust = Main.dust[Dust.NewDust(dustPos + offset - Vector2.One * 4f, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity *= 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
				unit = dustPos - Main.player[projectile.owner].Center;
				unit.Normalize();
				dust = Main.dust[Dust.NewDust(Main.player[projectile.owner].Center + 55 * unit, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity = dust.velocity * 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
			}*/
		//}

		/*
		 * Sets the end of the laser position based on where it collides with something
		 */
		private void SetLaserPosition(Player player)
		{
			for (Distance = MOVE_DISTANCE; Distance <= 2200f; Distance += 5f)
			{
				var start = player.Center + projectile.velocity * Distance;
				if (!Collision.CanHit(player.Center, 1, 1, start, 1, 1))
				{
					Distance -= 5f;
					break;
				}
			}
		}



		private void ChargeLaser(Player player)
		{
			// Kill the projectile if the player stops channeling
			if (!player.channel)
			{
				projectile.Kill();
			}
			else
			{
				// Do we still have enough mana? If not, we kill the projectile because we cannot use it anymore
				if (Main.time % 10 < 1 && !player.CheckMana(player.inventory[player.selectedItem].mana, true))
				{
					projectile.Kill();
				}
				Vector2 offset = projectile.velocity;
				offset *= MOVE_DISTANCE - 20;
				Vector2 pos = player.Center + offset - new Vector2(10, 10);
				if (Charge < MAX_CHARGE)
				{
					Charge++;
				}
				int chargeFact = (int)(Charge / 20f);
				Vector2 dustVelocity = Vector2.UnitX * 18f;
				dustVelocity = dustVelocity.RotatedBy(projectile.rotation - 1.57f);
				Vector2 spawnPos = projectile.Center + dustVelocity;
				for (int k = 0; k < chargeFact + 1; k++)
				{
					Vector2 spawn = spawnPos + ((float)Main.rand.NextDouble() * 6.28f).ToRotationVector2() * (12f - chargeFact * 2);
					Dust dust = Main.dust[Dust.NewDust(pos, 20, 20, 226, projectile.velocity.X / 2f, projectile.velocity.Y / 2f)];
					dust.velocity = Vector2.Normalize(spawnPos - spawn) * 1.5f * (10f - chargeFact * 2f) / 10f;
					dust.noGravity = true;
					dust.scale = Main.rand.Next(10, 20) * 0.05f;
				}
			}
		}

		private void UpdatePlayer(Player player)
		{
			// Multiplayer support here, only run this code if the client running it is the owner of the projectile
			if (projectile.owner == Main.myPlayer)
			{
				Vector2 diff = Main.MouseWorld - player.Center;
				diff.Normalize();
				projectile.velocity = diff;
				projectile.direction = Main.MouseWorld.X > player.position.X ? 1 : -1;
				projectile.netUpdate = true;
			}
			int dir = projectile.direction;
			player.ChangeDir(dir); // Set player direction to where we are shooting
			player.heldProj = projectile.whoAmI; // Update player's held projectil
			player.itemTime = 2; // Set item time to 2 frames while we are used
			player.itemAnimation = 2; // Set item animation time to 2 frames while we are used
		}

		private void CastLights()
		{
			// Cast a light along the line of the laser
			DelegateMethods.v3_1 = new Vector3(0.8f, 0.8f, 1f);
			Utils.PlotTileLine(projectile.Center, projectile.Center + projectile.velocity * (Distance - MOVE_DISTANCE), 26, DelegateMethods.CastLight);
		}

		public override bool ShouldUpdatePosition() => false;

		/*
		 * Update CutTiles so the laser will cut tiles (like grass)
		 */
	}
	/*public class IMP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("IronMace");
		}

		public override void SetDefaults()
		{
			projectile.width = 220;
			projectile.height = 220;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.ignoreWater = true;
			projectile.melee = true;
		}

		public override void AI()
		{
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			Player player = Main.player[projectile.owner];
			if (Main.myPlayer == projectile.owner && (!player.channel || player.noItems || player.get_CCed()))
			{
				projectile.Kill();
			}
			projectile.set_Center(player.get_MountedCenter());
			projectile.position.X += ((Entity)player).width / 2 * ((Entity)player).direction;
			projectile.spriteDirection = ((Entity)player).direction;
			Projectile projectile = projectile;
			projectile.rotation += 0.3f * (float)((Entity)player).direction;
			if (projectile.rotation > (float)Math.PI * 2f)
			{
				Projectile projectile2 = projectile;
				projectile2.rotation -= (float)Math.PI * 2f;
			}
			else if (projectile.rotation < 0f)
			{
				Projectile projectile3 = projectile;
				projectile3.rotation += (float)Math.PI * 2f;
			}
			player.heldProj = projectile.whoAmI;
			player.itemTime = 2;
			player.itemAnimation = 2;
			player.itemRotation = projectile.rotation;
		}

	}*/

	public class Light : ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the energy gauntlet");
		}
		// Use a different style for constant so it is very clear in code when a constant is used

		//The distance charge particle from the player center
		private const float MOVE_DISTANCE = 60f;

		// The actual distance is stored in the ai0 field
		// By making a property to handle this it makes our life easier, and the accessibility more readable
		public float Distance
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}


		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.magic = true;
			projectile.hide = true;
		}

		// Set custom immunity time on hitting an NPC
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.immune[projectile.owner] = 5;
		}



		// The AI of the projectile
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			if (!player.channel)
			{
				projectile.Kill();
			}
			projectile.position = player.Center + projectile.velocity * MOVE_DISTANCE;
			projectile.timeLeft = 2;

			// By separating large AI into methods it becomes very easy to see the flow of the AI in a broader sense
			// First we update player variables that are needed to channel the laser
			// Then we run our charging laser logic
			// If we are fully charged, we proceed to update the laser's position
			// Finally we spawn some effects like dusts and light

			UpdatePlayer(player);


			SetLaserPosition(player);
			//SpawnDusts(player);
			CastLights();
		}




		/*private void SpawnDusts(Player player)
		{
			Vector2 unit = projectile.velocity * -1;
			Vector2 dustPos = player.Center + projectile.velocity * Distance;

			for (int i = 0; i < 2; ++i)
			{
				float num1 = projectile.velocity.ToRotation() + (Main.rand.Next(2) == 1 ? -1.0f : 1.0f) * 1.57f;
				float num2 = (float)(Main.rand.NextDouble() * 0.8f + 1.0f);
				Vector2 dustVel = new Vector2((float)Math.Cos(num1) * num2, (float)Math.Sin(num1) * num2);
				Dust dust = Main.dust[Dust.NewDust(dustPos, 0, 0, 226, dustVel.X, dustVel.Y)];
				dust.noGravity = true;
				dust.scale = 1.2f;
				dust = Dust.NewDustDirect(Main.player[projectile.owner].Center, 0, 0, 31,
					-unit.X * Distance, -unit.Y * Distance);
				dust.fadeIn = 0f;
				dust.noGravity = true;
				dust.scale = 0.88f;
				dust.color = Color.Cyan;
			}

			if (Main.rand.NextBool(5))
			{
				Vector2 offset = projectile.velocity.RotatedBy(1.57f) * ((float)Main.rand.NextDouble() - 0.5f) * projectile.width;
				Dust dust = Main.dust[Dust.NewDust(dustPos + offset - Vector2.One * 4f, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity *= 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
				unit = dustPos - Main.player[projectile.owner].Center;
				unit.Normalize();
				dust = Main.dust[Dust.NewDust(Main.player[projectile.owner].Center + 55 * unit, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity = dust.velocity * 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
			}*/
		//}

		/*
		 * Sets the end of the laser position based on where it collides with something
		 */
		private void SetLaserPosition(Player player)
		{
			for (Distance = MOVE_DISTANCE; Distance <= 2200f; Distance += 5f)
			{
				var start = player.Center + projectile.velocity * Distance;
				if (!Collision.CanHit(player.Center, 1, 1, start, 1, 1))
				{
					Distance -= 5f;
					break;
				}
			}
		}



		private void UpdatePlayer(Player player)
		{
			// Multiplayer support here, only run this code if the client running it is the owner of the projectile
			if (projectile.owner == Main.myPlayer)
			{
				Vector2 diff = Main.MouseWorld - player.Center;
				diff.Normalize();
				projectile.velocity = diff;
				projectile.direction = Main.MouseWorld.X > player.position.X ? 1 : -1;
				projectile.netUpdate = true;
			}
			int dir = projectile.direction;
			player.ChangeDir(dir); // Set player direction to where we are shooting
			player.heldProj = projectile.whoAmI; // Update player's held projectil
			player.itemTime = 2; // Set item time to 2 frames while we are used
			player.itemAnimation = 2; // Set item animation time to 2 frames while we are used
		}
	
		private void UpdatePlayerVisuals(Player player, Vector2 playerHandPos)
		{
			// Place the Prism directly into the player's hand at all times.
			projectile.Center = playerHandPos;


			// The Prism is a holdout projectile, so change the player's variables to reflect that.
			// Constantly resetting player.itemTime and player.itemAnimation prevents the player from switching items or doing anything else.
			player.ChangeDir(projectile.direction);
			player.heldProj = projectile.whoAmI;


			// If you do not multiply by projectile.direction, the player's hand will point the wrong direction while facing left.
			player.itemRotation = (projectile.velocity * projectile.direction).ToRotation();
		}
		private void CastLights()
		{
			// Cast a light along the line of the laser
			DelegateMethods.v3_1 = new Vector3(0.8f, 0.8f, 1f);
			Utils.PlotTileLine(projectile.Center, projectile.Center + projectile.velocity * (Distance - MOVE_DISTANCE), 26, DelegateMethods.CastLight);
		}

		public override bool ShouldUpdatePosition() => false;

		/*
		 * Update CutTiles so the laser will cut tiles (like grass)
		 */
	}
	public class IronTomahawkp : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tomahawk");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.ranged = true;
		}

	}
	public class LeadTomahawkp : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tomahawk");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.penetrate = 3;
			projectile.ranged = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(20, 180, false);
		}

	}
	public class LetterA : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter A");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterB : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter A");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterC : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter C");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}

	public class LetterD : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter D");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterE : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter E");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterF : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter F");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterG : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter G");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterH : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter H");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterI : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter I");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterJ : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter J");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterK : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter K");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterL : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter L");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}

	public class LetterM : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter M");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterN : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter N");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterO : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter O");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter P");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterQ : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter Q");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterR : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter R");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterS : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter S");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterT : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter T");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterU : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter U");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterV : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter V");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterW : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter W");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterX : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter X");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LetterY : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter Y");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}

	public class LetterZ : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Letter Z");
		}

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class LightOrb : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("liteorb");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.timeLeft = 18000;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.aiStyle = 14;
			projectile.friendly = true;
			projectile.light = 100f;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

		public override void AI()
		{
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.owner == Main.myPlayer && Main.rand.Next(4) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 127, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 1000, false);
		}

	}


	public class Merchantyoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Merchant yoyo");
		}

		public override void SetDefaults()
		{
			projectile.width = 100;
			projectile.height = 144;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

	}
	public class MLP : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a flying Moon lord like what the frick");
		}

		public override void SetDefaults()
		{
			projectile.width = 212;
			projectile.height = 208;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(24, 180, false);
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class NovaBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nova Bullet");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 20;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 100;
			projectile.timeLeft = 120;
			projectile.light = 0.3f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			base.aiType = 14;
		}

	}
	public class Proj1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Jade Bolt");
		}

		public override void SetDefaults()
		{
			projectile.width = 50;
			projectile.height = 50;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class SakuraPetal : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a sakura petal");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 5;
			projectile.ranged = true;
			projectile.tileCollide = false;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class Shadowyoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anger");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.magic = true;
		}

	}
	public class Spaceyoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The space god's yoyo");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
		}

		int lomu = 0;
		public override void AI()
		{
			//projectile.rotation = Main.MouseWorld;

			lomu++;
			if (lomu > 7)
			{

				Vector2 position = projectile.Center;
				Vector2 targetPos = Main.MouseWorld;
				Vector2 direction = targetPos - position;
				direction.Normalize();
				float speed = 10f;

				// Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<GreenSlimep>(), ModContent.ProjectileType<BlueSlime>(), ModContent.ProjectileType<RedSlime>(),
				//  ModContent.ProjectileType<PurpleSlime>(), ModContent.ProjectileType<YellowSlime>()}), 100, 1, Main.myPlayer);
				Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ProjectileID.ScutlixLaserFriendly }), 100, 1, Main.myPlayer);
				lomu = 0;


				return;
			}



		}
	}
	public class Ghostyoyo : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The yoyo of spirits and ghosts.");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.alpha = 125;
			projectile.height = 16;
			projectile.aiStyle = 99;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.melee = true;
		}

		int lomu = 0;
		public override void AI()
		{
			//projectile.rotation = Main.MouseWorld;

			lomu++;
			if (lomu > 3)
			{

				Vector2 position = projectile.Center;
				Vector2 targetPos = Main.MouseWorld;
				Vector2 direction = targetPos - position;
				direction.Normalize();
				float speed = 10f;

				// Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ModContent.ProjectileType<GreenSlimep>(), ModContent.ProjectileType<BlueSlime>(), ModContent.ProjectileType<RedSlime>(),
				//  ModContent.ProjectileType<PurpleSlime>(), ModContent.ProjectileType<YellowSlime>()}), 100, 1, Main.myPlayer);
				Projectile.NewProjectile(position, direction * speed, Main.rand.Next(new int[] { ProjectileID.LostSoulFriendly }), 100, 1, Main.myPlayer);
				lomu = 0;


				return;
			}



		}
	}
	public class StoneProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone block");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.ranged = true;
		}

	}
	public class SPH : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a chunk of stone");
		}

		public override void SetDefaults()
		{
			projectile.damage = 750;
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.hostile = true;
			projectile.ranged = true;
		}

	}
	public class Swordp : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The true hero sword");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 2;
			projectile.ranged = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}

	}
	public class Tomeproj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anger");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 40;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.magic = true;
		}

	}
	public class Ultimate : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("the ultimatum");
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.height = 32;
			projectile.aiStyle = 81;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 180;
			projectile.ranged = true;
		}

	}
	public class UnleashedEnergy : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unleashed energy");
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 18;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = 1;
			projectile.magic = true;
			projectile.light = 0.75f;
			projectile.timeLeft = 600;
		}

		public override void AI()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			Lighting.AddLight(projectile.position, 0f, 0f, 99f);



			projectile.rotation = projectile.velocity.ToRotation();

		
	}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.AddBuff(70, 180, false);
			target.AddBuff(69, 180, false);
			target.AddBuff(20, 180, false);
			target.AddBuff(36, 180, false);
			target.AddBuff(67, 180, false);
			target.AddBuff(72, 180, false);
			target.AddBuff(144, 180, false);
			target.AddBuff(149, 180, false);
			target.AddBuff(153, 180, false);
			target.AddBuff(31, 180, false);
			target.AddBuff(30, 180, false);
		}

	}

	public class VoidProj : ModProjectile
	{
		/*public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unleashed energy");
		}*/

		public override void SetDefaults()
		{
			projectile.width = 30;
			projectile.height = 30;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.ranged = true;
			projectile.light = 5f;
			projectile.timeLeft = 600;
		}

	}


	public class VortexShuriken : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex shuriken");
			//Sets.TrailCacheLength[projectile.type] = 5;
			//Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.timeLeft = 600;
			projectile.ignoreWater = true;
			projectile.light = 0.67f;
			projectile.tileCollide = true;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override void Kill(int timeLeft)
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 5; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, ProjectileID.MoonlordArrowTrail, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
		}
	}
	public class VoidBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("strange flower");
		}

		public override void SetDefaults()
		{
			projectile.width = 15;
			projectile.height = 15;
			projectile.damage = 20;
			projectile.aiStyle = 83;
			projectile.hostile = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.timeLeft = 300;
			projectile.ranged = true;
		}
	}

	public class InvisBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Invisible shot");
		}

		public override void SetDefaults()
		{
			projectile.width = 5;
			projectile.height = 5;
			projectile.damage = 10;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.tileCollide = true;
			projectile.timeLeft = 300;
			projectile.ranged = true;
		}
	}
	public class ThiccBullet : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("a thicc bullet");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 24;
			projectile.damage = 7;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.light = 0.25f;
			projectile.light = 1f;
			projectile.timeLeft = 600;
			projectile.ranged = true;
		}
		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	public class ElectricOrb : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laser turret");
		}

		public override void SetDefaults()
		{
			projectile.width = 96;
			projectile.height = 96;
			projectile.damage = 7;
			projectile.aiStyle = 0;
			projectile.friendly = true;
			projectile.light = 0.25f;
			projectile.timeLeft = 600;
			projectile.ranged = true;
		}

		public override void AI()
		{
			{
				Main.projFrames[projectile.type] = 4;
			}
		}
	}
	public class EyeBeam : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Laser turret");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.EyeBeam);
			projectile.hostile = false;
			projectile.friendly = true;
			projectile.height = 8;
				projectile.width = 48;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.aiStyle = 0;
			projectile.light = 1f;
			projectile.timeLeft = 600;
			projectile.ranged = true;
		}

		public override void AI()
		{

			projectile.rotation = projectile.velocity.ToRotation();

		}
	}
	/*if (projectile.ai[1] == 0f)
	{
		Vector2 vel = default(Vector2);
		for (int i = 0; i < 3; i++)
		{
			((Vector2)(ref vel))..ctor(Utils.NextFloat(Main.rand, -3f, 3f), Utils.NextFloat(Main.rand, -10f, -8f));
			Projectile.NewProjectile(projectile.get_Center(), vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0f, 1f);
		}
	}
	projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
	projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
	projectile.width = 10;
	projectile.height = 10;
	projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
	projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
	int explosionRadius = 3;
	explosionRadius = 7;
	_ = (int)(projectile.position.X / 16f - (float)explosionRadius);
	int maxTileX = (int)(projectile.position.X / 16f + (float)explosionRadius);
	int minTileY = (int)(projectile.position.Y / 16f - (float)explosionRadius);
	int maxTileY = (int)(projectile.position.Y / 16f + (float)explosionRadius);
	_ = 0;
	if (maxTileX > Main.maxTilesX)
	{
		maxTileX = Main.maxTilesX;
	}
	if (minTileY < 0)
	{
		minTileY = 0;
	}
	if (maxTileY > Main.maxTilesY)
	{
		maxTileY = Main.maxTilesY;
	}*/



	public class LunarThrowingDagger : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar dagger");
			//Sets.TrailCacheLength[projectile.type] = 5;
			//Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 32;
			projectile.timeLeft = 600;
			projectile.ignoreWater = true;
			projectile.light = 1f;
			projectile.tileCollide = true;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.ranged = true;
		}

		public override void Kill(int timeLeft)
		{
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			if (projectile.ai[1] == 0)
			{
				for (int i = 0; i < 4; i++)
				{
					// Random upward vector.
					Vector2 vel = new Vector2(Main.rand.NextFloat(-3, 3), Main.rand.NextFloat(-10, -8));
					Projectile.NewProjectile(projectile.Center, vel, ProjectileID.Daybreak, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
					Projectile.NewProjectile(projectile.Center, vel, ProjectileID.NebulaBlaze1, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
					Projectile.NewProjectile(projectile.Center, vel, ProjectileID.MoonlordArrow, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
					Projectile.NewProjectile(projectile.Center, vel, ProjectileID.FrostBoltStaff, projectile.damage, projectile.knockBack, projectile.owner, 0, 1);
				}
			}
			/*if (projectile.ai[1] == 0f)
			{
				Vector2 vel = default(Vector2);
				for (int i = 0; i < 3; i++)
				{
					((Vector2)(ref vel))..ctor(Utils.NextFloat(Main.rand, -3f, 3f), Utils.NextFloat(Main.rand, -10f, -8f));
					Projectile.NewProjectile(projectile.get_Center(), vel, projectile.type, projectile.damage, projectile.knockBack, projectile.owner, 0f, 1f);
				}
			}
			projectile.position.X = projectile.position.X + (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y + (float)(projectile.height / 2);
			projectile.width = 10;
			projectile.height = 10;
			projectile.position.X = projectile.position.X - (float)(projectile.width / 2);
			projectile.position.Y = projectile.position.Y - (float)(projectile.height / 2);
			int explosionRadius = 3;
			explosionRadius = 7;
			_ = (int)(projectile.position.X / 16f - (float)explosionRadius);
			int maxTileX = (int)(projectile.position.X / 16f + (float)explosionRadius);
			int minTileY = (int)(projectile.position.Y / 16f - (float)explosionRadius);
			int maxTileY = (int)(projectile.position.Y / 16f + (float)explosionRadius);
			_ = 0;
			if (maxTileX > Main.maxTilesX)
			{
				maxTileX = Main.maxTilesX;
			}
			if (minTileY < 0)
			{
				minTileY = 0;
			}
			if (maxTileY > Main.maxTilesY)
			{
				maxTileY = Main.maxTilesY;
			}*/
		}

	}

	/*public class Light: ModProjectile
	{

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("how did you find this death message what the heck?");
		}
		// Use a different style for constant so it is very clear in code when a constant is used

		// The maximum charge value
		private const float MAX_CHARGE = 50f;
		//The distance charge particle from the player center
		private const float MOVE_DISTANCE = 60f;

		// The actual distance is stored in the ai0 field
		// By making a property to handle this it makes our life easier, and the accessibility more readable
		public float Distance
		{
			get => projectile.ai[0];
			set => projectile.ai[0] = value;
		}

		// The actual charge value is stored in the localAI0 field
		public float Charge
		{
			get => projectile.localAI[0];
			set => projectile.localAI[0] = value;
		}

		// Are we at max charge? With c#6 you can simply use => which indicates this is a get only property
		public bool IsAtMaxCharge => Charge == MAX_CHARGE;

		public override void SetDefaults()
		{
			projectile.width = 10;
			projectile.height = 10;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.tileCollide = false;
			projectile.magic = true;
			projectile.hide = true;
		}

		// Change the way of collision check of the projectile
		public override bool? Colliding(Rectangle projHitbox, Rectangle targetHitbox)
		{
			// We can only collide if we are at max charge, which is when the laser is actually fired
			if (!IsAtMaxCharge) return false;

			Player player = Main.player[projectile.owner];
			Vector2 unit = projectile.velocity;
			float point = 0f;
			// Run an AABB versus Line check to look for collisions, look up AABB collision first to see how it works
			// It will look for collisions on the given line using AABB
			return Collision.CheckAABBvLineCollision(targetHitbox.TopLeft(), targetHitbox.Size(), player.Center,
				player.Center + unit * Distance, 22, ref point);
		}

		// Set custom immunity time on hitting an NPC
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			target.immune[projectile.owner] = 5;
		}

		// The AI of the projectile
		public override void AI()
		{
			Player player = Main.player[projectile.owner];
			projectile.position = player.Center + projectile.velocity * MOVE_DISTANCE;
			projectile.timeLeft = 2;

			// By separating large AI into methods it becomes very easy to see the flow of the AI in a broader sense
			// First we update player variables that are needed to channel the laser
			// Then we run our charging laser logic
			// If we are fully charged, we proceed to update the laser's position
			// Finally we spawn some effects like dusts and light

			UpdatePlayer(player);
			ChargeLaser(player);

			// If laser is not charged yet, stop the AI here.
			if (Charge < MAX_CHARGE) return;

			SetLaserPosition(player);
			//SpawnDusts(player);
			CastLights();
		}

		/*private void SpawnDusts(Player player)
		{
			Vector2 unit = projectile.velocity * -1;
			Vector2 dustPos = player.Center + projectile.velocity * Distance;

			for (int i = 0; i < 2; ++i)
			{
				float num1 = projectile.velocity.ToRotation() + (Main.rand.Next(2) == 1 ? -1.0f : 1.0f) * 1.57f;
				float num2 = (float)(Main.rand.NextDouble() * 0.8f + 1.0f);
				Vector2 dustVel = new Vector2((float)Math.Cos(num1) * num2, (float)Math.Sin(num1) * num2);
				Dust dust = Main.dust[Dust.NewDust(dustPos, 0, 0, 226, dustVel.X, dustVel.Y)];
				dust.noGravity = true;
				dust.scale = 1.2f;
				dust = Dust.NewDustDirect(Main.player[projectile.owner].Center, 0, 0, 31,
					-unit.X * Distance, -unit.Y * Distance);
				dust.fadeIn = 0f;
				dust.noGravity = true;
				dust.scale = 0.88f;
				dust.color = Color.Cyan;
			}

			if (Main.rand.NextBool(5))
			{
				Vector2 offset = projectile.velocity.RotatedBy(1.57f) * ((float)Main.rand.NextDouble() - 0.5f) * projectile.width;
				Dust dust = Main.dust[Dust.NewDust(dustPos + offset - Vector2.One * 4f, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity *= 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
				unit = dustPos - Main.player[projectile.owner].Center;
				unit.Normalize();
				dust = Main.dust[Dust.NewDust(Main.player[projectile.owner].Center + 55 * unit, 8, 8, 31, 0.0f, 0.0f, 100, new Color(), 1.5f)];
				dust.velocity = dust.velocity * 0.5f;
				dust.velocity.Y = -Math.Abs(dust.velocity.Y);
			}*/
	//}

	/*
	 * Sets the end of the laser position based on where it collides with something

	private void SetLaserPosition(Player player)
	{
		for (Distance = MOVE_DISTANCE; Distance <= 2200f; Distance += 5f)
		{
			var start = player.Center + projectile.velocity * Distance;
			if (!Collision.CanHit(player.Center, 1, 1, start, 1, 1))
			{
				Distance -= 5f;
				break;
			}
		}
	}

	private void ChargeLaser(Player player)
	{
		// Kill the projectile if the player stops channeling
		if (!player.channel)
		{
			projectile.Kill();
		}
	}

	private void UpdatePlayer(Player player)
	{
		// Multiplayer support here, only run this code if the client running it is the owner of the projectile
		if (projectile.owner == Main.myPlayer)
		{
			Vector2 diff = Main.MouseWorld - player.Center;
			diff.Normalize();
			projectile.velocity = diff;
			projectile.direction = Main.MouseWorld.X > player.position.X ? 1 : -1;
			projectile.netUpdate = true;
		}
		int dir = projectile.direction;
		player.ChangeDir(dir); // Set player direction to where we are shooting
		player.heldProj = projectile.whoAmI; // Update player's held projectil
		player.itemTime = 2; // Set item time to 2 frames while we are used
		player.itemAnimation = 2; // Set item animation time to 2 frames while we are used
	}

	private void CastLights()
	{
		// Cast a light along the line of the laser
		DelegateMethods.v3_1 = new Vector3(0.8f, 0.8f, 1f);
		Utils.PlotTileLine(projectile.Center, projectile.Center + projectile.velocity * (Distance - MOVE_DISTANCE), 26, DelegateMethods.CastLight);
	}

	public override bool ShouldUpdatePosition() => false;

	/*
	 * Update CutTiles so the laser will cut tiles (like grass)

}*/

	// Code adapted from the vanilla's magic missile.
	public class Bladecast : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 100;
			projectile.height = 100;
			// projectile.aiStyle = 9; // Vanilla magic missile uses this aiStyle, but using it wouldn't let us fine tune the projectile speed or dust
			projectile.friendly = true;
			projectile.timeLeft = 420;
			projectile.magic = true;
			drawOriginOffsetY = -6;
		}


		public override void AI()
		{

			// In Multi Player (MP) This code only runs on the client of the projectile's owner, this is because it relies on mouse position, which isn't the same across all clients.
			if (Main.myPlayer == projectile.owner && projectile.ai[0] == 0f)
			{

				Player player = Main.player[projectile.owner];
				// If the player channels the weapon, do something. This check only works if item.channel is true for the weapon.
				if (player.channel)
				{
					float maxDistance = 18f; // This also sets the maximun speed the projectile can reach while following the cursor.
					Vector2 vectorToCursor = Main.MouseWorld - projectile.Center;
					float distanceToCursor = vectorToCursor.Length();

					// Here we can see that the speed of the projectile depends on the distance to the cursor.
					if (distanceToCursor > maxDistance)
					{
						distanceToCursor = maxDistance / distanceToCursor;
						vectorToCursor *= distanceToCursor;
					}

					int velocityXBy1000 = (int)(vectorToCursor.X * 1000f);
					int oldVelocityXBy1000 = (int)(projectile.velocity.X * 1000f);
					int velocityYBy1000 = (int)(vectorToCursor.Y * 1000f);
					int oldVelocityYBy1000 = (int)(projectile.velocity.Y * 1000f);

					// This code checks if the precious velocity of the projectile is different enough from its new velocity, and if it is, syncs it with the server and the other clients in MP.
					// We previously multiplied the speed by 1000, then casted it to int, this is to reduce its precision and prevent the speed from being synced too much.
					if (velocityXBy1000 != oldVelocityXBy1000 || velocityYBy1000 != oldVelocityYBy1000)
					{
						projectile.netUpdate = true;
					}

					projectile.velocity = vectorToCursor;

				}
				// If the player stops channeling, do something else.
				else if (projectile.ai[0] == 0f)
				{

					// This code block is very similar to the previous one, but only runs once after the player stops channeling their weapon.
					projectile.netUpdate = true;

					float maxDistance = 14f; // This also sets the maximun speed the projectile can reach after it stops following the cursor.
					Vector2 vectorToCursor = Main.MouseWorld - projectile.Center;
					float distanceToCursor = vectorToCursor.Length();

					//If the projectile was at the cursor's position, set it to move in the oposite direction from the player.
					if (distanceToCursor == 0f)
					{
						vectorToCursor = projectile.Center - player.Center;
						distanceToCursor = vectorToCursor.Length();
					}

					distanceToCursor = maxDistance / distanceToCursor;
					vectorToCursor *= distanceToCursor;

					projectile.velocity = vectorToCursor;

					if (projectile.velocity == Vector2.Zero)
					{
						projectile.Kill();
					}

					projectile.ai[0] = 1f;
				}
			}

			// Set the rotation so the projectile points towards where it's going.
			if (projectile.velocity != Vector2.Zero)
			{
				projectile.rotation = projectile.velocity.ToRotation() + MathHelper.PiOver4;
			}
		}

		public override void Kill(int timeLeft)
		{
			// If the projectile dies without hitting an enemy, crate a small explosion that hits all enemies in the area.
			if (projectile.penetrate == 1)
			{
				// Makes the projectile hit all enemies as it circunvents the penetrate limit.
				projectile.maxPenetrate = -1;
				projectile.penetrate = -1;

				int explosionArea = 60;
				Vector2 oldSize = projectile.Size;
				// Resize the projectile hitbox to be bigger.
				projectile.position = projectile.Center;
				projectile.Size += new Vector2(explosionArea);
				projectile.Center = projectile.position;

				projectile.tileCollide = false;
				projectile.velocity *= 0.01f;
				// Damage enemies inside the hitbox area
				projectile.Damage();
				projectile.scale = 0.01f;

				//Resize the hitbox to its original size
				projectile.position = projectile.Center;
				projectile.Size = new Vector2(10);
				projectile.Center = projectile.position;
			}

			Main.PlaySound(SoundID.Item10, projectile.position);
		}
	}


}



/*public override void AI()
{

	// Apply proper rotation, with an offset of 135 degrees due to the sprite's rotation, notice the usage of MathHelper, use this class!
	// MathHelper.ToRadians(xx degrees here)
	projectile.rotation = projectile.velocity.ToRotation() + MathHelper.ToRadians(135f);
	// Offset by 90 degrees here
	if (projectile.spriteDirection == -1)
	{
		projectile.rotation -= MathHelper.ToRadians(180f);
	}*/

