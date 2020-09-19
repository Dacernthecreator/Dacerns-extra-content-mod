
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.ComponentModel;
using System.Media;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Dacern.FriendlyNPC;
using Dacern.Items.Materials;
using Dacern.Items;
using Dacern.Projectiles;
//using Dacern.DacernPlayer;
using Dacern;
using System.Security.Cryptography.X509Certificates;
//using Dacern.miscq

namespace Dacern.Enemies
{
	public class Arms : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arms");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 10000;
			npc.damage = 45;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath19;
			npc.value = 5000f;
			npc.knockBackResist = 100f;
			npc.aiStyle = 17;
			base.aiType = 250;
			base.animationType = 250;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Chest : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Body");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 20;
			npc.lifeMax = 10000;
			npc.damage = 30;
			npc.defense = 80;
			npc.HitSound = SoundID.NPCHit29;
			npc.DeathSound = SoundID.NPCDeath45;
			npc.value = 5000f;
			npc.knockBackResist = 100f;
			npc.aiStyle = 87;
			base.aiType = 49;
			base.animationType = 49;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class DarkDemon : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demon of darkness");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[62];
		}

		public override void SetDefaults()
		{
			npc.width = 246;
			npc.height = 207;
			npc.lifeMax = 10000;
			npc.damage = 2500;
			npc.defense = 30;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 35000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 14;
			base.aiType = 62;
			base.animationType = 62;

			banner = npc.type;
			bannerItem = ModContent.ItemType<DemonOfDarknessBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class DarknessSlime : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Darkness Slime");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[1];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 24;
			npc.lifeMax = 1000;
			npc.damage = 125;
			npc.defense = 20;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 100f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 1;
			base.aiType = 1;
			base.animationType = 1;

			banner = npc.type;
			bannerItem = ModContent.ItemType<DarknessSlimeBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 4;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}

	[AutoloadBossHead]
	public class GreenSlime : ModNPC
	{
		public override void SetDefaults()
		{
			npc.boss = true;
			npc.CloneDefaults(NPCID.GreenSlime);
			npc.width = 46;
			npc.height = 64;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Slime");
		}

	}

	public class Darkrock : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark Rock");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[49];
		}

		public override void SetDefaults()
		{
			npc.width = 96;
			npc.height = 96;
			npc.lifeMax = 10000;
			npc.damage = 999;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;

			npc.value = 2500f;
			npc.knockBackResist = 1000f;
			npc.aiStyle = 0;
			base.aiType = 250;
			base.animationType = 250;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 1;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class DarkServant : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark servant");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 500;
			npc.height = 500;
			npc.lifeMax = 25000;
			npc.damage = 150;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit18;
			npc.DeathSound = SoundID.NPCDeath21;
			npc.value = 100000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 3;
			base.aiType = 49;
			base.animationType = 48;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 198;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Eyes : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eyes");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[49];
		}

		public override void SetDefaults()
		{
			npc.width = 26;
			npc.height = 60;
			npc.lifeMax = 1;
			npc.damage = 300;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit49;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 5000f;
			npc.knockBackResist = 100f;
			npc.aiStyle = 14;
			base.aiType = 250;
			base.animationType = 250;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 105;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Firework : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Firework");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[62];
		}

		public override void SetDefaults()
		{
			npc.width = 64;
			npc.height = 152;
			npc.lifeMax = 1000;
			npc.damage = 2500;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 35000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 74;
			base.aiType = 388;
			base.animationType = 62;
		}

	}
	/*public class Glitch : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Glitch");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[49];
		}

		public override void SetDefaults()
		{
			npc.width = 500;
			npc.height = 500;
			npc.lifeMax = 20000;
			npc.damage = 36;
			npc.defense = 2;
			npc.HitSound = SoundID.NPCHit35;
			npc.DeathSound = SoundID.NPCDeath37;
			npc.value = 7500f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 86;
			base.aiType = 250;
			base.animationType = 250;
		}

		private void Shoot(ref int type)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			Projectile.NewProjectile(npc.get_Center().X, npc.get_Center().Y, 0f, 0f, type, 500, 0f, Main.myPlayer, (float)npc.whoAmI, (float)Main.rand.Next());
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(0, 268);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}*/
	public class GreenSpark : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Green Spark");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[3];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 100000;
			npc.damage = 1000;
			npc.defense = 50;
			npc.HitSound = SoundID.Item99;
			npc.DeathSound = SoundID.Item103;
			npc.value = 10f;
			npc.knockBackResist = 100f;
			npc.aiStyle = 2;
			base.aiType = 49;
			base.animationType = 49;
		}

	}
	public class JoeSwanson : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Joe Swanson's holiness");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 202;
			npc.height = 202;
			npc.lifeMax = 130;
			npc.damage = 9999999;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 7500f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 0;
			base.aiType = 86;
			base.animationType = 3;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Legs : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Legs");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 1000;
			npc.damage = 25;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit17;
			npc.DeathSound = SoundID.NPCDeath15;
			npc.value = 7500f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 26;
			base.aiType = 86;
			base.animationType = 3;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Legion : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Legion");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.GreekSkeleton];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 150;
			npc.damage = 40;
			npc.defense = 15;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath37;
			npc.value = 0f;
			npc.knockBackResist = 60f;
			npc.aiStyle = 3;
			base.aiType = NPCID.GreekSkeleton;
			base.animationType = NPCID.GreekSkeleton;
		}

		/*public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			if (Main.hardMode)
			{
				
			}
		}*/

		public override void NPCLoot()
		{

			if (Main.rand.Next(10) == 0)
			{

				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Javelin, 1, false, 0, false, false);
			}
		}


		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class ModGlobalNPCWS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.WaterSphere)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BurningSphere);
				}
			}
		}
	}

	public class ModGlobalNPCBoulder : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.ChaosBall)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.WaterSphere);
				}
			}
		}
	}
	/*public class ModGlobalTileSharpeningStation : GlobalTile
	{
        public override void KillTile(int i, int j, int type, ref bool fail, ref bool effectOnly, ref bool noItem)
        {
            base.KillTile(i, j, type, ref fail, ref effectOnly, ref noItem);
			Tile tile = Framing.GetTileSafely(i, j);
			if (type == TileID.SharpeningStation)
            {

				NPC.NewNPC, NPCID.EnchantedSword);
			}



		}
		
		
	}*/
	public class ModGlobalNPCSandel : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.SandElemental)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BlackRecluse);
				}
			}
		}
	}
	public class ModGlobalNPCDutchmanscannon : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.PirateShipCannon)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonSpirit);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialJavelin3 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2JavelinstT3)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT3);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialJavelin2 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2JavelinstT2)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT2);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialJavelin1 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2JavelinstT1)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT1);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialBomber3 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2GoblinBomberT3)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT3);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialBomber2 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2GoblinBomberT2)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT2);
				}
			}
		}
	}
	public class ModGlobalNPCEtherialBomber1 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DD2GoblinBomberT1)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DD2GoblinT1);
				}
			}
		}
	}
	public class ModGlobalNPCEyeofCthulhu : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.EyeofCthulhu)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.WanderingEye);
				}
			}
		}
	}
	public class ModGlobalNPCIceGolem : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.IceGolem)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.IceElemental);
				}
			}
		}
	}
	public class ModGlobalNPCMeteHead : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MeteorHead)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Hellbat);
				}
			}
		}
	}
	public class ModGlobalNPCBurnSphe : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.BurningSphere)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.ChaosBall);
				}
			}
		}
	}
	public class ModGlobalNPCAN : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(2) == 0)
				{
					if (npc.type == NPCID.AngryNimbus)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ThickCloud>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCBOne : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(4) == 0)
				{
					if (npc.type == ModContent.NPCType<SmallBlade>())
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BladeFragment>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCBTwo : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(7) == 0)
				{
					if (npc.type == ModContent.NPCType<SmallBlade>())
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BladeFragment>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCBThree : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(7) == 0)
				{
					if (npc.type == ModContent.NPCType<SmallBlade>())
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BladeFragment>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCSTP : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.LunarTowerStardust)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonGuardian);
					}
				}
			}
		}
	}
	public class ModGlobalNPCNEP : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.LunarTowerNebula)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonGuardian);
					}
				}
			}
		}
	}
	public class ModGlobalNPCVOP : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.LunarTowerVortex)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonGuardian);
					}
				}
			}
		}
	}
	public class ModGlobalNPCSOP : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.LunarTowerSolar)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonGuardian);
					}
				}
			}
		}
	}
	public class ModGlobalNPCB : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.Bunny)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<RedSpark>());
					}
				}
			}
		}
	}

	public class ModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(75) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<LunarSpirit>())
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpiritYoyo>());
					
				    }
				}
			}
		}
	}

	public class ModGlobalNPB : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
					if (npc.type == ModContent.NPCType<BoulderNPC>())
					{
						npc.TargetClosest();
						if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
						{
							Vector2 position = npc.Center;
							Vector2 targetPosition = Main.player[npc.target].Center;
							Vector2 direction = targetPosition - position;
							direction.Normalize();
							float speed = 10f;
							int type = ProjectileID.Boulder;
							int damage = npc.damage / 1;
							Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);

							// Our timer has finished, do something here:
							// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
						}
					
				
			}
		}
	}

	public class ModGlobalNPCBlade : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<Blade>())
					{
						NPC.NewNPC((int)npc.Center.X , (int)npc.Center.Y , ModContent.NPCType<SmallBlade>());

						NPC.NewNPC((int)npc.Center.X + -1000, (int)npc.Center.Y + -1000, ModContent.NPCType<SmallBlade>());
						NPC.NewNPC((int)npc.Center.X + 1000, (int)npc.Center.Y + 1000, ModContent.NPCType<SmallBlade>());
						NPC.NewNPC((int)npc.Center.X + -1000, (int)npc.Center.Y + 1000, ModContent.NPCType<SmallBlade>());
						NPC.NewNPC((int)npc.Center.X + 1000, (int)npc.Center.Y + -1000, ModContent.NPCType<SmallBlade>());
					NPC.NewNPC((int)npc.Center.X + -1000, (int)npc.Center.Y + 0, ModContent.NPCType<SmallBlade>());
					NPC.NewNPC((int)npc.Center.X + 0, (int)npc.Center.Y + 1000, ModContent.NPCType<SmallBlade>());
					NPC.NewNPC((int)npc.Center.X + 1000, (int)npc.Center.Y + 0, ModContent.NPCType<SmallBlade>());
					NPC.NewNPC((int)npc.Center.X + 0, (int)npc.Center.Y + -1000, ModContent.NPCType<SmallBlade>());
				}
				}
			}
		}
	

	public class ModGlobalNPCFI : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{
				if (npc.type == ModContent.NPCType<FamiliarImage>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SupressedMemory>());
				}
			}
		}
	}
	public class ModGlobalNPCF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{
				if (npc.type == ModContent.NPCType<InvisibleMan>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<TranslucentThrowingDaggers>());
				}
			}
		}
	}
	public class ModGlobalNPCFE : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{
				if (npc.type == ModContent.NPCType<ForgottenEye>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Sadness>());
				}
			}
		}
	}
	public class ModGlobalNPCFtoolazylolE : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{
				if (npc.type == ModContent.NPCType<ForgottenEye>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<EyeTrophy>());
				}
			}
		}
	}
	public class ModGlobalNPCFEskele : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{
				if (npc.type == ModContent.NPCType<FamiliarImage>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SkeletonTrophy>());
				}
			}
		}
	}
	public class ModGlobalNPCskele : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{
				if (npc.type == ModContent.NPCType<ForgottenBee>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BeeTrophy>());
				}
			}
		}
	}
	public class ModGlobalNPCFB : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{
				if (npc.type == ModContent.NPCType<ForgottenBee>())
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Nightmare>());
				}
			}
		}
	}
	public class ModGlobalNPCL : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{
				if (npc.type == ModContent.NPCType<Legion>())
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Legion>());
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Legion>());
				}
			}
		}
	}
	public class ModGlobalNPDS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.DungeonSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SpikeBall);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BlazingWheel);
					}
				}
			}
		}
	}

	public class ModGlobalNPStaff : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(750) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUnderworldHeight)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HellsStaff>());
					}
				}
			}
		}
	}

	public class ModGlobalNPShroomCannon : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(250) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneGlowshroom)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ShroomCannon>());
					}
				}
			}
		}
	}


	public class ModGlobalNPCrimsonSacrifice : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(750) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCrimson)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SacrificialKnife>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCRain : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1200) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneRain)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HighPressureHose>());
					}
				}
			}
		}
	}


	public class ModGlobalNPCExtraCandleMechanicQOL : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1000) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneWaterCandle)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.WaterCandle);
					}
				}
			}
		}
	}

	public class ModGlobalNPCorruptSacrifice : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(750) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneCorrupt)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SacrificialKnife>());
					}
				}
			}
		}
	}


	public class ModGlobalNPCDESERT : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(600) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneUndergroundDesert) 

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DesertBoulderStaff>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCDungeonHooks : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(800) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneDungeon)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ChainHookShockwave>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCWaterdagger: GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(800) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<WaterDagger>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCSunshine : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(250) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DesertBoulderStaff>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCMoon : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(250) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (Main.player[(int)Player.FindClosest(npc.position, npc.width, npc.height)].ZoneSkyHeight)

					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CrescentMoonBoomerang>());
					}
				}
			}
		}
	}
	public class ModGlobalNPDGLOL : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().HahaLol)
			{
				if (npc.type == NPCID.DungeonGuardian)
				{
					npc.defense = 0;
					npc.lifeMax = 1;
					npc.damage *= 0;
				}
			}
		}
	}

	public class ModGlobalNPGSLOLBUTIDK : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().HahaLol)
			{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SparklingStone>());
				if (Main.expertMode)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SlimeBag>());
				}

			}
		}
	}

	public class ModGlobalNPGSLOL : GlobalNPC
	{
		public override void SetDefaults(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().HahaLol)
			{
				if (npc.type == NPCID.BlueSlime)
				{
					npc.defense += 99999999;
					npc.lifeMax += 99999999;

					npc.rarity = 10;
					npc.damage += 99999999;
				}
			}
		}
	}

	public class ModGlobalNPJSHLOL : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().HahaLol)
			{

				if (Main.rand.Next(5) == 0)
				{
					if (npc.type == NPCID.GreenSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<JoeSwanson>());
					}
				}
			}
		}
	}

	 
	public class ModGlobalNPBS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
					if (npc.type == ModContent.NPCType<GhostBoss>())
					{
						NPC.NewNPC((int)npc.Center.X - 500, (int)npc.Center.Y + 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X - 500, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X+500, (int)npc.Center.Y + 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X+500, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X - 500, (int)npc.Center.Y, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X + 500, (int)npc.Center.Y, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y - 500, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 500, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X + 200, (int)npc.Center.Y + 99, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X - 340, (int)npc.Center.Y + 250, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y - 320, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X + 4, (int)npc.Center.Y, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X - 200, (int)npc.Center.Y + 270, NPCID.Ghost, 0, npc.whoAmI) ;
						NPC.NewNPC((int)npc.Center.X - 39, (int)npc.Center.Y - 300, NPCID.Ghost, 0, npc.whoAmI);
						NPC.NewNPC((int)npc.Center.X + 400, (int)npc.Center.Y - 50, NPCID.Ghost, 0, npc.whoAmI);
					}
				
			
		}
	}

	public class ModGlobalNPBSDS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.BlueSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}

	public class ModGlobalNPSSDS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.SlimeSpiked)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}

	public class ModGlobalNPBSDcrismS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.Crimslime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}

	public class ModGlobalNPRedSp : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<RedSlimyPillar>())
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.KingSlime);
					}
				}
			
		}
	}

	public class ModGlobalNPPurpleSp : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<PurpleSlimyPillar>())
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.KingSlime);
					}
				}
			
		}
	}

	public class ModGlobalNPYellowSp : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<YellowSlimyPillar>())
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.KingSlime);
					}
				
			}
		}
	}

	public class ModGlobalNPBSDcrismSb : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.LittleCrimslime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSs : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.BigCrimslime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSandslS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.SandSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSSJS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.SpikedJungleSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSJuns : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.JungleSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSSIS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.SpikedIceSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSIS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.IceSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSlimer2 : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.Slimer2)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDSSlimer : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.Slimer)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDunS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.DungeonSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDKS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.KingSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}

	public class ModGlobalNPBSDKSAgain : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.KingSlime)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RainbowSlime);
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSlr : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.RainbowSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSillum : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.IlluminantSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrips : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.PurpleSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}

	public class ModGlobalNPBSDcripsBrella : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.UmbrellaSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismYell : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.YellowSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCRedSlime : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.RedSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSblsm : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.BlackSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismBS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.BabySlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismothS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.MotherSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismGS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(35) == 0)
				{
					if (npc.type == NPCID.GreenSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSLavs : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{

				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.LavaSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrilingsmS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.Slimeling)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcors : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(35) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.CorruptSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	public class ModGlobalNPBSDcrismSAGAINOHNO : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(10) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<DarknessSlime>())
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarknessSlime>());
					}
				}
			}
		}
	}
	/*
	public class ModGlobalNPBSDShadowSAGAINOHNO : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(75) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == ModContent.NPCType<DarknessSlime>())
					{
						NPC.NewNPC((int)npc.Center.X + 50, (int)npc.Center.Y+ 20, ModContent.NPCType<ShadowSlime>());
					}
				}
			}
		}*/
	public class ModGlobalNPSS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(1) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.KingSlime)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CaveBat);
					}
				}
			}
		}
	}
	public class ModGlobalNPCS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(2) == 0)
				{
					if (npc.type == NPCID.Squirrel)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Sparkle>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCDE : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.hardMode)
				{
					if (Main.rand.Next(200) == 0)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Mouth>());
					}
				}
			}
		}
	}

	public class ModGlobalNPDTDD : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.hardMode)
				{
					if (Main.rand.Next(30) == 0)
					{
						if (npc.type == NPCID.Demon)
						{
							NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<DarkDemon>());
						}
					}
				}
			}
		}
	}
	public class ModGlobalNPCDF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(25) == 0)
				{
					if (npc.type == NPCID.DukeFishron)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Onaighast>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCDFT : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(25) == 0)
				{
					if (npc.type == NPCID.DukeFishron)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Ultimatum>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCBee : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.Bee)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BeeSmall);
				}
			}
		}
	}
	public class ModGlobalNPCBeeSmall : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.BeeSmall)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Bee);
				}
			}
		}
	}
	public class ModGlobalNPCG : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(23) == 0)
				{
					if (npc.type == NPCID.Golem)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<HolyHelm>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCGAgain : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(23) == 0)
				{
					if (npc.type == NPCID.Golem)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CactusCoverings>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCGAgainAgaon : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(23) == 0)
				{
					if (npc.type == NPCID.Golem)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SwiftSneakers>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCGT : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(2) == 0)
				{
					if (npc.type == NPCID.Golem)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GolemSoul>());
					}
				}
			}
		}
	}
	public class ModGlobalNPCCS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.CursedSkull)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					}
				}
			}
		}
	}
	public class ModGlobalNPCGCS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(1) == 0)
				{
					if (npc.type == NPCID.GiantCursedSkull)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					}
				}
			}
		}
	}
	public class ModGlobalNPCRS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.RainbowSlime)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GreenSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BlackSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MotherSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.IceSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SandSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Slimer2);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CorruptSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Crimslime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BlueSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GreenSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.JungleSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.PurpleSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.YellowSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DungeonSlime);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RedSlime);
				}
			}
		}
	}
	public class ModGlobalNPCBM : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MothronSpawn)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Mothron);
				}
			}
		}
	}
	public class ModGlobalNPCSH : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.SkeletronHand)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.EyeofCthulhu);
				}
			}
		}
	}
	public class ModGlobalNPCSA : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.ShadowFlameApparition)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinPeon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinArcher);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinPeon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinWarrior);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinThief);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinSorcerer);
				}
			}
		}
	}
	public class ModGlobalNPCPS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.PrimeSaw)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHead);
				}
			}
		}
	}
	public class ModGlobalNPCPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.PrimeCannon)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHead);
				}
			}
		}
	}
	public class ModGlobalNPCPL : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.PrimeLaser)
			{

				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHead);
			}
		}
	}
		public class ModGlobalNPCPV : GlobalNPC
		{
			public override void NPCLoot(NPC npc)
			{
				if (npc.type == NPCID.PrimeVice)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHead);
				}
			}
		}
	}
	public class ModGlobalNPCSkeletron : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.SkeletronHead)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.AncientDoom);
				}
			}
		}
	}
	public class ModGlobalNPCA : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.CultistArcherBlue)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.CultistArcherWhite);
				}
			}
		}
	}
	public class ModGlobalNPCP : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.Probe)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.EnchantedSword);
				}
			}
		}
	}
	public class ModGlobalNPCGG : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.GrayGrunt)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianTurret);
				}
			}
		}
	}
	public class ModGlobalNPCGS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.GoblinSummoner)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinPeon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinArcher);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinPeon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinWarrior);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinThief);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.ShadowFlameApparition);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.ShadowFlameApparition);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.ShadowFlameApparition);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GoblinSorcerer);
				}
			}
		}
	}
	public class ModGlobalNPCSOC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.ServantofCthulhu)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DemonEye);
				}
			}
		}
	}
	public class ModGlobalNPCME : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MothronEgg)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Mothron);
				}
			}
		}
	}
	public class ModGlobalNPCGLF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.GolemFistLeft)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.QueenBee);
				}
			}
		}
	}
	public class ModGlobalNPCMLHand : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MoonLordCore)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronPrime);
				}
			}
		}
	}
	public class ModGlobalNPCRet : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.Retinazer)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RedDevil);
				}
			}
		}
	}
	public class ModGlobalNPCSpa : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.Spazmatism)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RedDevil);
				}
			}
		}
	}
	public class ModGlobalNPCLC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.CultistBoss)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronPrime);
				}
			}
		}
	}
	public class ModGlobalNPCWoF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.TheHungry)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Harpy);
				}
			}
		}
	}
	public class ModGlobalNPCPl : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.PlanterasTentacle)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Corruptor);
				}
			}
		}
	}
	public class ModGlobalNPCMLHead : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MoonLordHand)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronPrime);
				}
			}
		}
	}
	public class ModGlobalNPCBoC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.Creeper)
				{
					if (Main.rand.Next(4) == 0)
					{
						NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BloodCrawler);
					}
				}
			}
		}
	}
	public class ModGlobalNPCGRF : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.GolemFistRight)
				{
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.QueenBee);
				}
			}
		}
	}
	public class ModGlobalNPCDFTh : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.DukeFishron)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianWalker);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianTurret);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GrayGrunt);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianOfficer);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianDrone);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.MartianEngineer);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Demon);
				}
			}
		}
	}
	public class ModGlobalNPCEoW : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.EaterofWorldsBody)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Bee);
				}
			}
		}
	}
	public class ModGlobalNPCMST : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MartianSaucerTurret)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Turret>());
				}
			}
		}
	}
	public class ModGlobalNPCMSM : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (npc.type == NPCID.MartianSaucerCannon)
				{

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<Turret>());
				}
			}
		}
	}
	public class ModGlobalNPCIS : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (Main.rand.Next(250) == 0)
			{
				if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
				{
					if (npc.type == NPCID.IchorSticker)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<IchorSack>());
					}
				}
			}
		}
	}

	public class ModGlobalNPCFishronagain : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (Main.rand.Next(6) == 0)
				{
					if (npc.type == NPCID.DukeFishron)
					{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<FamiliarPhotos>());
					}
				}
			}
		}
	}
	public class Mouth : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mouth");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 33;
			npc.height = 15;
			npc.lifeMax = 300;
			npc.damage = 999;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit26;
			npc.DeathSound = SoundID.NPCDeath31;
			npc.value = 0f;
			npc.knockBackResist = 0.2f;
			npc.aiStyle = 86;
			base.aiType = 49;
			base.animationType = 48;
			banner = npc.type;
			bannerItem = ModContent.ItemType<MouthBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Nite : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[49];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.lifeMax = 10000;
			npc.damage = 25;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath33;
			npc.value = 9000f;
			npc.knockBackResist = 0.9f;
			npc.aiStyle = 3;
			base.aiType = 213;
			base.animationType = 49;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class OPcube : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Overpowered cube");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 200;
			npc.height = 200;
			npc.lifeMax = 500000;
			npc.damage = 999999;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit30;
			npc.DeathSound = SoundID.NPCDeath59;
			npc.value = 5000f;
			npc.knockBackResist = 100f;
			npc.aiStyle = 87;
			base.aiType = 250;
			base.animationType = 250;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 54;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class RedSpark : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Red Spark");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[3];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 100;
			npc.damage = 65;
			npc.defense = 36;
			npc.HitSound = SoundID.Item54;
			npc.DeathSound = SoundID.Item95;
			npc.value = 10f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 2;
			base.aiType = 49;
			base.animationType = 3;

			banner = npc.type;
			bannerItem = ModContent.ItemType<RedSparkBanner>();
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Frick>();
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}
		}
	}
	public class Sparkle : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spark");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[3];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 100;
			npc.damage = 125;
			npc.defense = 10;
			npc.HitSound = SoundID.Item29;
			npc.DeathSound = SoundID.Item4;
			npc.value = 1f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 2;
			base.aiType = 49;
			base.animationType = 3;
			banner = npc.type;
			bannerItem = ModContent.ItemType<SparkBanner>();
		}

	}
	public class Strayarrow : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Malfunctioning arrow");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 14;
			npc.height = 32;
			npc.lifeMax = 60;
			npc.damage = 20;
			npc.defense = 5;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 0f;
			npc.knockBackResist = 0;
			npc.aiStyle = 23;
			base.aiType = 250;
			base.animationType = 250;

			banner = npc.type;
			bannerItem = ModContent.ItemType<MalfunctioningArrowBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 7;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Straybullet : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Malfunctioning bullet");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 14;
			npc.height = 32;
			npc.lifeMax = 75;
			npc.damage = 50;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 23;
			base.aiType = 250;
			base.animationType = 250;

			banner = npc.type;
			bannerItem = ModContent.ItemType<MalfunctioningBulletBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 7;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class Tank : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("TestNPC");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[62];
		}

		public override void SetDefaults()
		{
			npc.width = 256;
			npc.height = 256;
			npc.lifeMax = 10000000;
			npc.damage = 0;
			npc.defense = 0;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 0;
			base.aiType = 3;
			base.animationType = 3;
		}

	}
	public class UnendingVoid : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Unending Void");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 600;
			npc.height = 600;
			npc.lifeMax = 1250;
			npc.damage = 9999;
			npc.defense = 99999999;
			npc.HitSound = SoundID.NPCHit18;
			npc.DeathSound = SoundID.NPCDeath51;
			npc.value = 5000f;
			npc.knockBackResist = 0f;
			base.aiType = 49;
			npc.aiStyle = 86;
			base.animationType = 49;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 109;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.003f;
			}
		}

		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VoidStone>(), 25, false, 0, false, false);
		}

	}
	public class Void : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 20;
			npc.lifeMax = 250;
			npc.damage = 250;
			npc.defense = 9999;
			npc.HitSound = SoundID.NPCHit18;
			npc.DeathSound = SoundID.NPCDeath51;
			npc.value = 5000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 23;
			base.aiType = 49;
			base.animationType = 48;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 109;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}
	public class VoidWolf : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Void wolf");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[3];
		}

		public override void SetDefaults()
		{
			npc.width = 79;
			npc.height = 48;
			npc.lifeMax = 350;
			npc.damage = 250;
			npc.defense = 99999999;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath51;
			npc.value = 500f;
			npc.knockBackResist = 0f;
			base.aiType = 155;
			npc.aiStyle = 26;
			base.animationType = 3;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 54;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.003f;
			}
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.SolarEclipse.Chance * 0.1f;
		}

		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VoidMaterial>(), 2, false, 0, false, false);
		}

	}
	// Party Zombie is a pretty basic clone of a vanilla NPC. To learn how to further adapt vanilla NPC behaviors, see https://github.com/tModLoader/tModLoader/wiki/Advanced-Vanilla-Code-Adaption#example-npc-npc-clone-with-modified-projectile-hoplite
	public class VoidSoul : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soul of the void");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.width = 40;
			npc.height = 42;
			npc.damage = 500;
			npc.defense = 9999;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit49;
			npc.DeathSound = SoundID.NPCDeath59;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 86;
			aiType = NPCID.FloatyGross;
			animationType = NPCID.Harpy;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.SolarEclipse.Chance * 0.03f;
		}

		public override void NPCLoot()
		{
			Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VoidMaterial>(), 3, false, 0, false, false);
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = Main.rand.Next(109, 109);
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + Main.rand.Next(-30, 31) * 0.01f;
			}
		}
	}
	public class BoulderNPC : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("flying boulder");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 200;
			npc.damage = 250;
			npc.defense = 100;
			npc.HitSound = SoundID.NPCHit3;
			npc.DeathSound = SoundID.NPCDeath3;
			npc.value = 5000f;
			npc.knockBackResist = 0.1f;
			npc.aiStyle = 23;
			base.aiType = 49;
			base.animationType = 48;
			npc.rarity = 1;

			banner = npc.type;
			bannerItem = ModContent.ItemType<FlyingBoulderBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 10; i++)
			{
				int dustType = 1;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(1) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Boulder, 1, false, 0, false, false);
			}
			if (Main.rand.Next(15) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<BoulderMask>(), 1, false, 0, false, false);
			}
			if (Main.rand.Next(3) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StoneBlock, 75, false, 0, false, false);
			}
			if (Main.rand.Next(3) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StoneBlock, 75, false, 0, false, false);
			}
			if (Main.rand.Next(3) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.StoneBlock, 75, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IronOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SilverOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.CopperOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.TinOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LeadOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.TungstenOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.GoldOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PlatinumOre, 15, false, 0, false, false);
			}
			if (Main.rand.Next(6) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LifeCrystal, 1, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Sapphire, 10, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Diamond, 10, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Amethyst, 10, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Ruby, 10, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Emerald, 10, false, 0, false, false);
			}
			if (Main.rand.Next(5) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Topaz, 10, false, 0, false, false);
			}
			if (Main.rand.Next(7) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.DirtBlock, 100, false, 0, false, false);
			}
			if (Main.rand.Next(7) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SiltBlock, 100, false, 0, false, false);
			}
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MudBlock, 50, false, 0, false, false);
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 15)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<SPH>();
					int damage = npc.damage / 250;
					Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}
		}
	}

	public class AncientEye : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Ancient eye");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 46;
			npc.height = 32;
			npc.lifeMax = 200;
			npc.damage = 35;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCHit1;
			npc.value = 100f;
			npc.knockBackResist = 1.2f;
			npc.aiStyle = 2;
			base.aiType = 49;
			npc.noTileCollide = true;
			base.animationType = 48;

			banner = npc.type;
			bannerItem = ModContent.ItemType<AncientEyeBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedBoss1)

				{
					return SpawnCondition.Dungeon.Chance * 0.05f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}
	}

	public class Assassin : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Assassin");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.lifeMax = 2200;
			npc.damage = 350;
			npc.defense = 26;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 3;
			base.aiType = NPCID.PossessedArmor;
			base.animationType = 48;

			banner = npc.type;
			bannerItem = ModContent.ItemType<AssassinBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedMechBossAny)

				{
					return SpawnCondition.Dungeon.Chance * 0.02f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}
	}

	public class ArrowDispenser : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arrow dispenser");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.lifeMax = 2200;
			npc.damage = 350;
			npc.defense = 26;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 0;
			base.aiType = NPCID.PossessedArmor;
			base.animationType = 48;

			banner = npc.type;
			bannerItem = ModContent.ItemType<AssassinBanner>();
		}

		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
				Vector2 position = npc.Center;
				Vector2 targetPosition = Main.player[npc.target].Center;
				Vector2 direction = targetPosition - position;
				direction.Normalize();
				float speed = 10f;
				//	int type = ProjectileID.LostSoulHostile;
				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y - 500, ModContent.NPCType<Strayarrow>(), 0, npc.whoAmI);


				// Our timer has finished, do something here:
				// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
			

		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 60, ModContent.NPCType<Strayarrow>(), 0, npc.whoAmI);


					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
				
				
			


		}
	}

	[AutoloadBossHead]
	public class RedSlimyPillar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy pillar");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[250];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.boss = true;
			npc.lifeMax = 3000;
			npc.damage = 350;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
		//	npc.aiStyle = 0;
			base.aiType = 250;
			base.animationType = 250;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Gel");

		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{

				if (Main.rand.Next(10) == 0)
				{
						Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedSlimyPillarTrophy>());
					
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RedandSilverDye, 2);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PillarStatue, 1);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RedandBlackDye, 2);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.DeepRedPaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RedPaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.RedDye, 2);
				}

				if (Main.rand.Next(1) == 0)
				{

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 20);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 80);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 150);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedSlimyShooter>());

				}
			}
			else
			{


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedSlimyPillarTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedBag>());

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<RedSlimeMask>());
				}
			}
		}
		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RedSlime, 0, npc.whoAmI); 


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RedSlime, 0, npc.whoAmI);


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.





		}
		int glan = 0;
		int glat = 0;
		int glam = 0;
		int glas = 0;
		int gint = 0;
		public override void AI()
		{
			glan++;
			if (glan > 50)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 50f;

					Main.PlaySound(SoundID.NPCDeath1, targetPosition);

					int type = ModContent.ProjectileType<SlimySpike>();
					int damage = npc.damage / 11;

					float rotation = MathHelper.ToRadians(25);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage , 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glan = 0;
				}
			}
			gint++;
			if (gint > 10) 
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 5f;

					int type = ModContent.ProjectileType<SlimeBall>();
					int damage = npc.damage * 10;

					Main.PlaySound(SoundID.NPCHit1, targetPosition);

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					gint = 0;
				}
			}
			glat++;
			if (glat > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 50f;

					int type = ModContent.ProjectileType<SlimySpike>();
					int damage = npc.damage / 11;

					float rotation = MathHelper.ToRadians(40);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glat = 0;
				}
			}
			glas++;
			if (glas > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 50f;

					int type = ModContent.ProjectileType<SlimySpike>();
					int damage = npc.damage / 11;

					float rotation = MathHelper.ToRadians(10);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glas = 0;
				}
			}
			glam++;
			if (glam > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 50f;

					int type = ModContent.ProjectileType<SlimySpike>();
					int damage = npc.damage / 11;

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 1; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glam = 0;
				}
			}
		}
	}
	[AutoloadBossHead]
	public class YellowSlimyPillar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy pillar");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[250];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.lifeMax = 3000;
			npc.boss = true;
			npc.damage = 350;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
		//	npc.aiStyle = 0;
			base.aiType = 250;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Gel");
			base.animationType = 250;

		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{


				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<YellowSlimyShooter>());

				}

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<YellowSlimyPillarTrophy>());

				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.YellowandSilverDye, 2);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PillarStatue, 1);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.YellowandBlackDye, 2);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.YellowGradientDye, 2);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.DeepYellowPaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.YellowPaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.YellowDye, 2);
				}
				if (Main.rand.Next(1) == 0)
				{

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 20);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 80);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 150);
				}
			}

			else
			{


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<YellowSlimyPillarTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<YellowBag>());

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<YellowSlimeMask>());
				}
			}
		}
		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.YellowSlime, 0, npc.whoAmI);


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.YellowSlime, 0, npc.whoAmI);


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.





		}
		int glan = 0;
		int glat = 0;
		int glam = 0;
		int glas = 0;
		int gint = 0;
		public override void AI()
		{
			glan++;
			if (glan > 20)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 50f;

					Main.PlaySound(SoundID.NPCDeath1, targetPosition);

					int type = ModContent.ProjectileType<SlimySpikey>();
					int damage = npc.damage / 10;

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 1; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glan = 0;
				}
			}
		}
	}
	[AutoloadBossHead]
	public class PurpleSlimyPillar : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Slimy pillar");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[250];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 48;
			npc.lifeMax = 3000;
			npc.boss = true;
			npc.damage = 350;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 1000f;
			npc.knockBackResist = 0f;
			//npc.aiStyle = 0;
			base.aiType = 250;
			base.animationType = 250;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Gel");

		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{

				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleSlimyShooter>());

				}

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleSlimyPillarTrophy>());

				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PurpleandSilverDye, 2);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PillarStatue, 1);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PurpleandBlackDye, 2);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.DeepPurplePaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PurplePaint, 25);
				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.PurpleDye, 2);
				}

				if (Main.rand.Next(1) == 0)
				{

					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 20);
				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 80);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.Gel, 150);
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleSlimeMask>());
				}
			}
			else
			{


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleSlimyPillarTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleBag>());

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<PurpleSlimeMask>());
				}
			}
		}
		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.PurpleSlime, 0, npc.whoAmI);


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


		}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.PurpleSlime, 0, npc.whoAmI);


			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.





		}
		int glan = 0;
		int glat = 0;
		int glam = 0;
		int glas = 0;
		int gint = 0;
      //  public override bool CheckActive()
      //  {
     //       return base.CheckActive();

    //    }
        public override void AI()
		{
			glan++;
			if (glan > 150)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 20f;

					Main.PlaySound(SoundID.NPCHit1, targetPosition);

					int type = ModContent.ProjectileType<SlimySpikep>();
					int damage = npc.damage / 9;

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
				}
			}
			if (glan > 210)
			{
					glan = 0;
				
			}
		}
	}

	public class MartianOutcast : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Outcast martian");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.CaveBat];
		}

		public override void SetDefaults()
		{
			npc.width = 20;
			npc.height = 38;
			npc.lifeMax = 1650;
			npc.damage = 150;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit43;
			npc.DeathSound = SoundID.NPCDeath45;
			npc.value = 2000f;
			npc.knockBackResist = 1f;
			npc.aiStyle = 3;
			base.aiType = NPCID.GrayGrunt;
			base.animationType = NPCID.CaveBat;
			banner = npc.type;
			bannerItem = ModContent.ItemType<OutcastMartianBanner>();
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedGolemBoss)

				{
					return SpawnCondition.Dungeon.Chance * 0.06f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}

		public override void NPCLoot()
		{
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.CosmicCarKey, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LaserDrill, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LaserMachinegun, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.AntiGravityHook, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ElectrosphereLauncher, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.InfluxWaver, 1, false, 0, false, false);
			}
			if (Main.rand.Next(100) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.ChargedBlasterCannon, 1, false, 0, false, false);
			}
			if (Main.rand.Next(10) == 0)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.MartianConduitPlating, 100, false, 0, false, false);
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 80)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.SaucerLaser;
					int damage = npc.damage / 250;
					Projectile.NewProjectile(position, direction * speed, type, damage * 15, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}
		}
	}

	public class SacrificedCultist : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cultist summoner"); 
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 34;
			npc.height = 50;
			npc.lifeMax = 1000;
			npc.damage = 50;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit54;
			npc.alpha = 125;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.value = 1500f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 0;
			npc.rarity = 6;

			base.aiType = 48;
			base.animationType = 48;
			banner = npc.type;
			bannerItem = ModContent.ItemType<CultistSummonerBanner>();
		}


		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 600)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
				//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1000;
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RuneWizard);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DarkCaster);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Tim);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Necromancer);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.RaggedCasterOpenCoat);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.DiabolistRed);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.GiantCursedSkull);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.BlazingWheel);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletonSniper);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.TacticalSkeleton);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.Paladin);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}


		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedAncientCultist)

				{
					return SpawnCondition.Dungeon.Chance * 0.017f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}
	}

	[AutoloadBossHead]
	public class SummonerBoss : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cultist Grandmaster");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 232;
			npc.boss = true;
			npc.height = 232;
			npc.lifeMax = 50000;
			npc.damage = 500;
			npc.defense = 68;
			npc.HitSound = SoundID.NPCHit55;
			npc.DeathSound = SoundID.NPCDeath59;
			npc.value = 1500f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 0;
			npc.rarity = 7;

			base.aiType = 48;
			base.animationType = 48;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = true;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = true;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = true;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = true;
			//music = MusicID.Boss3;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Cultist");
		}
		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmasterTrophy>());

				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersStaff>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersScroll>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersSigil>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersSpellbook>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(15))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersContainmentChamber>(), 1, false, 0, false, false);


				}
			}
            else
            {



				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmasterTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistBag>(), 1, false, 0, false, false);

				if (Main.rand.NextBool(6))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersRobe>(), 1, false, 0, false, false);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersPants>(), 1, false, 0, false, false);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersHood>(), 1, false, 0, false, false);


				}
			}

		}
		

		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 300)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					NPC.NewNPC((int)npc.Center.X - 100, (int)npc.Center.Y + 40, ModContent.NPCType<SacrificedCultist>(), 0, npc.whoAmI);
					NPC.NewNPC((int)npc.Center.X + 100, (int)npc.Center.Y + 40, ModContent.NPCType<SacrificedCultist>(), 0, npc.whoAmI);

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 70, ModContent.NPCType<SmallBlade>(), 0, npc.whoAmI);

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 60, ModContent.NPCType<Mouth>(), 0, npc.whoAmI);


					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}

			npc.ai[2]++;
			if (npc.ai[2] > 100)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 5;
					Projectile.NewProjectile(position, direction * speed, type, damage * 10, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.InfernoHostileBolt, damage * 1, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.ShadowBeamHostile, damage * 1, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossFireBall, damage * 1, 0f, Main.myPlayer);
					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 60, NPCID.WaterSphere, 0, npc.whoAmI);


					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[2] = 0;
				}
			}
			npc.ai[1]++;
			if (npc.ai[1] > 300)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
						int type = ProjectileID.SaucerMissile;
					int damage = npc.damage / 5;
					Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossLightningOrbArc, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossIceMist, damage, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[1] = 0;
				}
			}

		}

	}

	[AutoloadBossHead]
	public class BulletHellBoss : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark golem head");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 232;
			npc.boss = true;
			npc.height = 232;
			npc.lifeMax = 50000;
			npc.damage = 500;
			npc.defense = 150;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 1500f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 86;
			base.aiType = 48;
			base.animationType = 48;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = true;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = true;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = true;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = true;
			//music = MusicID.Boss3;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Cultist");
		}

		/*public override void NPCLoot()
		{
			if (!Main.expertMode)
			{
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersStaff>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersScroll>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersSigil>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(10))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersSpellbook>(), 1, false, 0, false, false);


				}
				if (Main.rand.NextBool(15))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<GrandmastersContainmentChamber>(), 1, false, 0, false, false);


				}
			}
			else
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistBag>(), 1, false, 0, false, false);

				if (Main.rand.NextBool(6))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersRobe>(), 1, false, 0, false, false);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersPants>(), 1, false, 0, false, false);
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<CultistGrandmastersHood>(), 1, false, 0, false, false);


				}
			}

		}
		*/
		int dagu = 0;
		int dacu = 0;
		int damu = 0;
		int dalu = 0;
		int datu = 0;
		public override void AI()
		{
			dagu++;
			if (dagu > 120)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossIceMist, damage, 0f, Main.myPlayer);



					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					dagu = 0;
				}
			}

			dacu++;
			if (dacu > 80)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, ProjectileID.InfernoHostileBlast, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.PaladinsHammerHostile, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.LostSoulHostile, damage, 0f, Main.myPlayer);



					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					dacu = 0;
				}
			}
			dacu++;
			if (damu > 150)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, ProjectileID.FlamingArrow, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.BulletDeadeye, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CursedFlameHostile, damage, 0f, Main.myPlayer);



					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					damu = 0;
				}
			}
			dalu++;
			if (dalu > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossLightningOrbArc, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossLightningOrb, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossFireBallClone, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossFireBall, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.CultistBossIceMist, damage, 0f, Main.myPlayer);



					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					dalu = 0;
				}
			}
			datu++;
			if (datu > 30)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					//	int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, ProjectileID.SaucerScrap, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.SaucerMissile, damage, 0f, Main.myPlayer);
					Projectile.NewProjectile(position, direction * speed, ProjectileID.SaucerLaser, damage, 0f, Main.myPlayer);



					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					datu = 0;
				}
			}

		}

	}

	[AutoloadBossHead]
	public class GhostBoss : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spirit King");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}
			public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.alpha = 175;
			npc.height = 111;
			npc.noTileCollide = true;
			npc.lifeMax = 30000;
			npc.damage = 200;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 43;
			aiType = NPCID.QueenBee;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Memories");
		}

		public override void OnHitByProjectile(Projectile projectile, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X + 100, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
			NPC.NewNPC((int)npc.Center.X - 100, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);


			if (Main.rand.Next(10) == 0)
			{
				NPC.NewNPC((int)npc.Center.X - 100, (int)npc.Center.Y + 50, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
				NPC.NewNPC((int)npc.Center.X + 100, (int)npc.Center.Y - 50, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);

			}
			if (Main.rand.Next(50) == 0)
			{

				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<SmallBlade>(), 0, npc.whoAmI);
			}


				// Our timer has finished, do something here:
				// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


			}
		public override void OnHitByItem(Player player, Item item, int damage, float knockback, bool crit)
		{
			Vector2 position = npc.Center;
			Vector2 targetPosition = Main.player[npc.target].Center;
			Vector2 direction = targetPosition - position;
			direction.Normalize();
			float speed = 10f;
			//	int type = ProjectileID.LostSoulHostile;
			NPC.NewNPC((int)npc.Center.X + 100, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
			NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);
			NPC.NewNPC((int)npc.Center.X - 100, (int)npc.Center.Y - 500, ModContent.NPCType<LunarSpirit>(), 0, npc.whoAmI);


			if (Main.rand.Next(50) == 0)
			{

				NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, ModContent.NPCType<SmallBlade>(), 0, npc.whoAmI);
			}

			// Our timer has finished, do something here:
			// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.





		}
		int spiri = 0;
		int spirit = 0;
		int spiritb = 0;
		int spiritbl = 0;
		int spiritblt = 0;
		int spiribolt = 0;
		int spiritbolt = 0;
		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{

			spiritbolt++;
			if (spiritbolt> 30)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritbolt = 0;

				}

			}
			spiribolt++;
			if (spiribolt > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DemonSickle;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 1; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiribolt = 0;

				}

			}
			spiri++;
			if (spiri > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DemonSickle;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(5);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiri = 0;

				}

			}
			spirit++;
			if (spirit > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DemonSickle;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(10);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spirit = 0;

				}

			}
			spiritb++;
			if (spiritb > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DemonSickle;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(15);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritb = 0;

				}

			}
			spiritbl++;
			if (spiritbl > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DemonSickle;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(20);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritbl = 0;

				}

			}
			Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = ((targetPosition - npc.position) / 0.9f) * .05f;

		}
	}
	[AutoloadBossHead]
	public class SpaceBoss : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("God of space");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}
		public override void SetDefaults()
		{
			npc.boss = true;
			npc.noTileCollide = true;
			npc.width = 810;
			npc.height = 860;
			npc.lifeMax = 30000;
			npc.damage = 200;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit34;
			npc.DeathSound = SoundID.NPCDeath51;
			npc.aiStyle = 0;
			aiType = NPCID.Harpy;
			animationType = NPCID.Harpy;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			aiType = NPCID.QueenBee;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.noGravity = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Space");
		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{


				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FallenStar, 20);

				}
				if (Main.rand.Next(7) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VoidMaterial>(), 15);

				}

				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofFlight, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofFright, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofMight, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofSight, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofNight, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.SoulofLight, 20);

				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpaceGodsYoyo>(), 1);

				}
				if (Main.rand.Next(4) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<ManaSupercannon>(), 1);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SoulOfMidnight>(), 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SoulOfDaylight>(), 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SoulOfTwilight>(), 20);

				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.FallenStar, 20);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<VoidMaterial>(), 15);

				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SunTrophy>());

				}
				if (Main.rand.NextBool(9))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpaceGodsMask>(), 1, false, 0, false, false);


				}
			}
			else
			{



				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SunTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpaceBag>(), 1, false, 0, false, false);

				if (Main.rand.NextBool(9))
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<SpaceGodsMask>(), 1, false, 0, false, false);
					

				}
			}

		}
		int spiri = 0;
		int spirit = 0;
		int yee = 0;
		int deat = 0;
		int spiritb = 0;
		int spiritbl = 0;
		int spiritblt = 0;
		int death = 0;
		int spiribolt = 0;
		int spiritbolt = 0;
		public override void AI()
		{

			yee++;
			if (yee > 240)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossLightningOrb;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(50);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					yee = 0;

				}

			}


			deat++;
			if (deat > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.SaucerScrap;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(100);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					deat = 0;

				}

			}
			death++;
			if (death > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.SaucerMissile;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(120);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					death = 0;

				}

			}
			spiritbolt++;
			if (spiritbolt > 30)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.LostSoulHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritbolt = 0;

				}

			}
			spiribolt++;
			if (spiribolt > 10)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossFireBall;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 1; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiribolt = 0;

				}

			}

			spiri++;
			if (spiri > 10)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossFireBall;
					int damage = npc.damage / 1;

					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles

					float rotation = MathHelper.ToRadians(15);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 0f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiri = 0;

				}

			}
			spirit++;
			if (spirit > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossLightningOrbArc;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(10);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spirit = 0;

				}

			}
			spiritb++;
			if (spiritb > 10)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossFireBall;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(15);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritb = 0;

				}

			}
			spiritbl++;
			if (spiritbl > 70)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossIceMist;
					int damage = npc.damage / 1;

					float rotation = MathHelper.ToRadians(20);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage, 2f, Main.myPlayer);
					}
					// Our timer has finished, do so
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					spiritbl = 0;

				}

			}
			//		Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = new Vector2(0, 0);

		}
	}
	[AutoloadBossHead]
	public class LaserBoss : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stationary Turret");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 100;
			npc.boss = true;
			npc.height = 100;
			npc.lifeMax = 1000;
			npc.damage = 500;
			npc.defense = 8;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 1500f;
			npc.knockBackResist = 0f;
			//npc.aiStyle = 0;

			base.aiType = 48;
			base.animationType = 48;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = true;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = true;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = true;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = true;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = true;
			//music = MusicID.Boss3;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Lasers");
		}

		public override void NPCLoot()
		{
			if (!Main.expertMode)
			{


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StationaryTurretTrophy>());

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.IronBar, 15, false, 0, false, false);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LeadBar, 15, false, 0, false, false);
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.LaserRifle, 1, false, 0, false, false);
				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ItemID.HealingPotion, 10, false, 0, false, false);
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StationaryTurretMask>());
				}
				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<MinorUpgrade>());

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<DarkGem>());

				}
				if (Main.rand.Next(2) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<Blaustein>(), 50);

				}
				if (Main.rand.Next(3) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LightGem>());

				}
			}
            else
            {


				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StationaryTurretTrophy>());

				}
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<LaserBag>());

				if (Main.rand.Next(10) == 0)
				{
					Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, ModContent.ItemType<StationaryTurretMask>());
				}
			}
		}

		int lagya = 8;
		int lanya = 0;
		int glabla = 0;

		public override void AI()
		{
			lanya++;
			if (lanya > 16)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.EyeBeam;
					int damage = npc.damage / 35;
					float rotation = MathHelper.ToRadians(0);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 3; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}					

					//int numberProjectiles = 3; // 4 or 5 shots
					//	for (int i = 0; i < numberProjectiles; i++)
					//	{
					//		Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					// float scale = 1f - (Main.rand.NextFloat() * .3f);
					// perturbedSpeed = perturbedSpeed * scale; 
					//	Projectile.NewProjectile(position.X, position.Y, Direction, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
					//}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					lanya = 0;
				}
			}

			glabla++;
			if (glabla > 360)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CultistBossLightningOrb;
					int damage = npc.damage / 35;
					float rotation = MathHelper.ToRadians(0);
					for (int i = 0; i < 2; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 2f, Main.myPlayer);
					}

					//int numberProjectiles = 3; // 4 or 5 shots
					//	for (int i = 0; i < numberProjectiles; i++)
					//	{
					//		Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					// float scale = 1f - (Main.rand.NextFloat() * .3f);
					// perturbedSpeed = perturbedSpeed * scale; 
					//	Projectile.NewProjectile(position.X, position.Y, Direction, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
					//}
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					glabla = 0;
				}
			}
			lagya++;
			if (lagya > 16)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.EyeBeam;
					int damage = npc.damage / 35;
					float rotation = MathHelper.ToRadians(15);
					//Vector2 perturbedSpeed = new Vector2(direction.X, direction.Y).RotatedByRandom(MathHelper.ToRadians(60)); // 30 degree spread.
					// If you want to randomize the speed to stagger the projectiles
					for (int i = 0; i < 4; i++)
					{
						Projectile.NewProjectile(position, (speed * direction).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / 2)), type, damage * 1, 0f, Main.myPlayer);
					}

					//int 
					lagya = 0;
				}
			}
		}

	}
	public class LunarSpirit : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar spirit");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[82];
		}

		public override void SetDefaults()
		{
			npc.width = 36;
			npc.height = 52;
			npc.lifeMax = 1300;
			npc.damage = 1000;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit54;
			npc.alpha = 125;
			npc.DeathSound = SoundID.NPCDeath52;
			npc.value = 2500f;
			npc.knockBackResist = 2f;
			npc.aiStyle = 23;
			npc.noTileCollide = true;
			npc.rarity = 4;
			base.aiType = 83;
			base.animationType = 82;

			banner = npc.type;
			bannerItem = ModContent.ItemType<LunarSpiritBanner>();
		}

		public override void AI()
		{
			npc.ai[2]++;
			if (npc.ai[2] > 1)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Nauh>();
					int damage = npc.damage / 1000;
					Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[2] = 0;
				}
			}

		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedMoonlord)

				{
					return SpawnCondition.Dungeon.Chance * 0.02f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}
	}
	public class Blade : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Large sword");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.width = 333;
			npc.height = 66;
			npc.lifeMax = 7500;
			npc.damage = 300;
			npc.defense = 15;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 5000f;
			npc.rarity = 5;
			npc.knockBackResist = 0f;
			npc.aiStyle = 23;
			base.aiType = 48;
			base.animationType = 48;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{

			if (ModContent.GetInstance<GlobalEffects>().ExtraChallenge)
			{
				if (NPC.downedGolemBoss)

				{
					return SpawnCondition.Dungeon.Chance * 0.0137f;
				}
				else
				{
					return SpawnCondition.Dungeon.Chance * 0;
				}
			}
			return 0;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 2; i++)
			{
				int dustType = 30;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}


	public class SmallBlade : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Small sword");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[48];
		}

		public override void SetDefaults()
		{
			npc.width = 36;
			npc.height = 18;
			npc.lifeMax = 1000;
			npc.damage = 80;
			npc.defense = 10;
			npc.HitSound = SoundID.NPCHit4;
			npc.DeathSound = SoundID.NPCDeath6;
			npc.value = 5000f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 23;
			base.aiType = 49;
			base.animationType = 48;
			banner = npc.type;
			bannerItem = ModContent.ItemType<SmallSwordBanner>();
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 2; i++)
			{
				int dustType = 30;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 2)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Nauh>();
					int damage = npc.damage / 5000;
					Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}
		}
	}
	public class Turret : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Martian spiked block");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.width = 32;
			npc.height = 32;
			npc.lifeMax = 600;
			npc.damage = 150;
			npc.defense = 120;
			npc.HitSound = SoundID.NPCHit34;
			npc.DeathSound = SoundID.NPCDeath37;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 23;
			base.aiType = 48;
			base.animationType = 48;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 8;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 10)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPosition = Main.player[npc.target].Center;
					Vector2 direction = targetPosition - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Nauh>();
					int damage = npc.damage / 5000;
					Projectile.NewProjectile(position, direction * speed, type, damage, 0f, Main.myPlayer);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;
				}
			}
		}
	}

	[AutoloadBossHead]
	public class FamiliarImage : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.height = 102;
			npc.noTileCollide = true;
			npc.lifeMax = 75000;
			npc.damage = 450;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			//npc.aiStyle = 11;
			//aiType = NPCID.SkeletronHead;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Memories");
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					//Vector2 direction = targetPos - position;
					//direction.Normalize();
					//float speed = 10f;
					//int type = ModContent.ProjectileType<FamiliarImage");
					//int damage = npc.damage / 500;
					//Projectile.NewProjectile(position, direction * speed, type, damage * 20, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.PrimeLaser);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 40, ModContent.NPCType<FamiliarHand>(), 0, npc.whoAmI);



				}
			}








			Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = ((targetPosition - npc.position) / 2) * .05f;
		}
	}




	/*public class FamiliarImage : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.height = 102;
			npc.noTileCollide = true;
			npc.lifeMax = 300000;
			npc.damage = 450;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 0f;
			npc.knockBackResist = 100f;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = MusicID.Boss2;
		}
		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 5; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}



		public override bool PreDraw(SpriteBatch spriteBatch, Color drawColor)
		{
			/*Vector2 drawPos = npc.position - Main.screenPosition;
			drawPos.X += 1 * 2 - 20 / 2;
			drawPos.Y += 1 * 2 - 20 / 2;




			if (npc.life < 100000)
			{
				
				Texture2D bosstexture = mod.GetTexture("Enemies/ForgottenBee");
				//spriteBatch.Draw(mod.GetTexture("Enemies/ForgottenBee"), drawPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
				spriteBatch.Draw(bosstexture, npc.position - Main.screenPosition, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
			}
			else if (npc.life <200000)
            {

				//spriteBatch.Draw(mod.GetTexture("Enemies/ForgottenEye"), drawPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
				spriteBatch.Draw(mod.GetTexture("Enemies/ForgottenEye"), npc.position - Main.screenPosition, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
			}
			else
			{

				//spriteBatch.Draw(mod.GetTexture("Enemies/FamiliarImage"), drawPos, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
				spriteBatch.Draw(mod.GetTexture("Enemies/FamiliarImage"), npc.position - Main.screenPosition, null, Color.White, 0f, Vector2.Zero, 1f, SpriteEffects.None, 0f);
			}
			



			return false;
		}









		public override void AI()
		{
















			npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					//Vector2 direction = targetPos - position;
					//direction.Normalize();
					//float speed = 10f;
					//int type = ModContent.ProjectileType<FamiliarImage");
					//int damage = npc.damage / 500;
					//Projectile.NewProjectile(position, direction * speed, type, damage * 20, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.PrimeLaser);

					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;

					NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y + 40, ModContent.NPCType<FamiliarHand>(), 0, npc.whoAmI);



				}
			}








			Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = ((targetPosition - npc.position) / 2) * .05f;
		}
	}*/

























	public class FamiliarHand : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.width = 56;
			npc.height = 75;
			npc.lifeMax = 12500;
			npc.damage = 1000;
			npc.defense = 30;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 0f;
			//npc.knockBackResist = 100f;
			//npc.aiStyle = 3;
			base.aiType = NPCID.GreekSkeleton;
			base.animationType = NPCID.AngryNimbus;
		}











		int atk = 160;

		Vector2 jab = new Vector2(0.0f, 0.0f);



		public override void AI()
		{

	
			
			
			
			
			
			
			
			
			
			
			
			
			
			
			NPC owner = Main.npc[(int)npc.ai[0]];
			if (!owner.active || owner.type != ModContent.NPCType<FamiliarImage>())
			{
				npc.active = false;
				return;
			}
			FamiliarImage modOwner = (FamiliarImage)owner.modNPC;
			Vector2 targetPos = new Vector2(npc.ai[1], npc.ai[2]);
			Vector2 direction = targetPos - npc.Center;
			if (direction != Vector2.Zero)
			{
				float speed = direction.Length();
				if (speed > 2f)
				{
					speed = 2f;
				}
				direction.Normalize();
				direction *= speed;
				npc.position += direction;
			}
			else
			{
				npc.localAI[1] = 1f;
			}

			npc.TargetClosest();
			Vector2 targetPosition = Main.player[npc.target].Center;

			npc.ai[1]++;
			if (npc.ai[1] > 60)
			{
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 projdirection = targetPos - position;
					projdirection.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<FamiliarBolt>();
					int damage = npc.damage / 500;
					Projectile.NewProjectile(position, direction * speed, type, damage * 20, 0f, Main.myPlayer);
					

					//Main.PlaySound(SoundID.Roar, targetPosition, 0);


					npc.ai[1] = 0;




				}
			}

			npc.ai[2]++;
			if (npc.ai[2] > 40)
			{
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 projdirection = targetPos - position;
					projdirection.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<VoidBullet>();
					int damage = npc.damage / 500;
					Projectile.NewProjectile(position, direction * speed, type, damage * 20, 0f, Main.myPlayer);


					//Main.PlaySound(SoundID.Roar, targetPosition, 0);


					npc.ai[2] = 0;




				}
			}

			/*npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 target = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<BP1");
					int damage = npc.damage / 50;
					Projectile.NewProjectile(position, direction * speed, type, damage * 20, 0f, Main.myPlayer);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.
					npc.ai[0] = 0;



				}
			}*/








			if (Main.rand.Next(3) == 1)
			{
				atk++;
			}



			if (atk > 180)
			{
				if (atk < 182)
				{
					npc.TargetClosest();
					if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
					{

						//Main.PlaySound(SoundID.Roar, targetPosition, 0);


						//atk = 0;



						jab = ((targetPosition - npc.position) / 2) * .1f;



					}
				}
			}

			if (atk > 220)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{

					Main.PlaySound(SoundID.Unlock, targetPosition, 0);


					atk = 0;



					Vector2 jab = new Vector2(0.0f, 0.0f);




				}
			}









			if (atk < 180)
			{
				npc.velocity = ((targetPosition - npc.position) / 2) * .1f + ((owner.position - npc.position) / 2) * .1f;
				
			}
			else
			{
				npc.velocity = ((targetPosition - npc.position) / 2) * .015f + jab;
				
			}




















	}






	public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}





	/*public class FamiliarHand : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.width = 56;
			npc.height = 75;
			npc.lifeMax = 12500;
			npc.damage = 120;
			npc.defense = 30;
			npc.noTileCollide = true;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 0f;
			base.aiType = NPCID.GreekSkeleton;
			base.animationType = NPCID.AngryNimbus;
		}



		int atk = 160;

		Vector2 jab = new Vector2(0.0f, 0.0f);



		public override void AI()
		{

			NPC owner = Main.npc[(int)npc.ai[0]];
			if (!owner.active || owner.type != ModContent.NPCType<FamiliarImage>())
			{
				npc.active = false;
				return;
			}
			FamiliarImage modOwner = (FamiliarImage)owner.modNPC;
			Vector2 targetPos = new Vector2(npc.ai[1], npc.ai[2]);
			Vector2 direction = targetPos - npc.Center;
			if (direction != Vector2.Zero)
			{
				float speed = direction.Length();
				if (speed > 2f)
				{
					speed = 2f;
				}
				direction.Normalize();
				direction *= speed;
				npc.position += direction;
			}
			else
			{
				npc.localAI[1] = 1f;
			}

			npc.TargetClosest();
			Vector2 targetPosition = Main.player[npc.target].Center;



			if (Main.rand.Next(3) == 1)
			{
				atk++;
			}



			if (atk > 180)
			{
				if (atk < 182)
				{
					npc.TargetClosest();
					if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
					{

						Main.PlaySound(SoundID.Roar, targetPosition, 0);


						//atk = 0;



						jab = ((targetPosition - npc.position) / 2) * .1f;



					}
				}
			}

			if (atk > 220)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{

					Main.PlaySound(SoundID.Shatter, targetPosition, 0);


					atk = 0;



					Vector2 jab = new Vector2(0.0f, 0.0f);




				}
			}









			if (atk < 180)
			{
				npc.velocity = ((targetPosition - npc.position) / 2) * .1f + ((owner.position - npc.position) / 2) * .1f;
			}
			else
			{
				npc.velocity = ((targetPosition - npc.position) / 2) * .015f + jab;
			}



		}






		public override void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 10; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}

	}*/












	public class DarkSkeletron : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dark skeletron");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.height = 102;
			npc.noTileCollide = false;
			npc.lifeMax = 100000;
			npc.damage = 450;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit2;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 11;
			aiType = NPCID.GreekSkeleton;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = MusicID.Boss2;
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 210;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Nauh>();
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 0, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


				}

			}






		}
	}

	[AutoloadBossHead]
	public class ForgottenEye : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.height = 111;
			npc.noTileCollide = true;
			npc.lifeMax = 45000;
			npc.damage = 450;
			npc.defense = 50;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 4;
			aiType = NPCID.EyeofCthulhu;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Memories");
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 60)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.CursedFlameHostile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.


					npc.ai[0] = 0;
				}

			}

			npc.ai[1]++;
			if (npc.ai[1] > 40)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DeathLaser;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					npc.ai[1] = 0;

				}

			}

			npc.ai[2]++;
			if (npc.ai[2] > 120)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.DeathLaser;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 1, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					npc.ai[2] = 0;

				}

			}
			npc.ai[3]++;
			if (npc.ai[3] > 75)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ProjectileID.SaucerMissile;
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 1, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					npc.ai[3] = 0;

				}

			}

			Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = ((targetPosition - npc.position) / 3f) * .05f;

		}
	}

	[AutoloadBossHead]
	public class ForgottenBee : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Forgotten memory");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[NPCID.Harpy];
		}

		public override void SetDefaults()
		{
			npc.boss = true;
			npc.width = 80;
			npc.height = 111;
			npc.noTileCollide = true;
			npc.lifeMax = 30000;
			npc.damage = 200;
			npc.defense = 25;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.value = 0f;
			npc.knockBackResist = 0f;
			npc.aiStyle = 43;
			aiType = NPCID.QueenBee;
			animationType = NPCID.AngryNimbus;
			npc.buffImmune[BuffID.Poisoned] = true;
			npc.buffImmune[BuffID.Confused] = false;
			npc.buffImmune[BuffID.OnFire] = true;
			npc.buffImmune[BuffID.Venom] = false;
			npc.buffImmune[BuffID.CursedInferno] = true;
			npc.buffImmune[BuffID.Frostburn] = false;
			npc.buffImmune[BuffID.ShadowFlame] = true;
			npc.buffImmune[BuffID.Ichor] = false;
			npc.buffImmune[BuffID.Midas] = true;
			npc.buffImmune[BuffID.Suffocation] = false;
			music = mod.GetSoundSlot(SoundType.Music, "Sounds/Music/Memories");
		}

		public override void HitEffect(int hitDirection, double damage)
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < 5; i++)
			{
				int dustType = 5;
				int dustIndex = Dust.NewDust(npc.position, npc.width, npc.height, dustType, 0f, 0f, 0, default(Color), 1f);
				Dust dust = Main.dust[dustIndex];
				dust.velocity.X = dust.velocity.X + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.velocity.Y = dust.velocity.Y + (float)Main.rand.Next(-50, 51) * 0.01f;
				dust.scale *= 1f + (float)Main.rand.Next(-30, 31) * 0.01f;
			}
		}
		public override void AI()
		{
			npc.ai[0]++;
			if (npc.ai[0] > 30)
			{
				npc.TargetClosest();
				if (npc.HasValidTarget && Main.netMode != NetmodeID.MultiplayerClient)
				{
					Vector2 position = npc.Center;
					Vector2 targetPos = Main.player[npc.target].Center;
					Vector2 direction = targetPos - position;
					direction.Normalize();
					float speed = 10f;
					int type = ModContent.ProjectileType<Nauh>();
					int damage = npc.damage / 1;
					Projectile.NewProjectile(position, direction * speed, type, damage * 2, 0f, Main.myPlayer);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					//NPC.NewNPC((int)npc.Center.X, (int)npc.Center.Y, NPCID.SkeletronHand);
					// Our timer has finished, do something here:
					// Main.PlaySound, Dust.NewDust, Projectile.NewProjectile, etc. Up to you.

					npc.ai[0] = 0;

				}

			}

			Vector2 targetPosition = Main.player[npc.target].Center;
			npc.velocity = ((targetPosition - npc.position) / 0.75f) * .05f;

		}
	}
}









/*if(projectile.ai[0] > 50)
{
  doThing();
}*/
