using Rocket.Core.Plugins;
using SDG.Unturned;
using Steamworks;

namespace FRVehicleDamageControl
{
    public class Plugin : RocketPlugin<VehicleDamageControlConfiguration>
    {
        public static Plugin Instance;

        protected override void Load()
        {
            Instance = this;
            VehicleManager.onDamageVehicleRequested += OnVehicleGetDamage;
        }

        protected override void Unload()
        {
            Instance = null;
            VehicleManager.onDamageVehicleRequested -= OnVehicleGetDamage;
        }

        public void OnVehicleGetDamage(CSteamID instigatorSteamId, InteractableVehicle vehicle, ref ushort pendingTotalDamage, ref bool canRepair, ref bool shouldAllow, EDamageOrigin damageOrigin)
        {
            switch (damageOrigin)
            {
                case EDamageOrigin.Bullet_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromBulletExplosion);
                    break;
                case EDamageOrigin.Animal_Attack:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromAnimalAttack);
                    break;
                case EDamageOrigin.Flamable_Zombie_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromFlammableZombieExplosion);
                    break;
                case EDamageOrigin.Food_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromFoodExplosion);
                    break;
                case EDamageOrigin.Mega_Zombie_Boulder:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromMegaZombieBoulder);
                    break;
                case EDamageOrigin.Radioactive_Zombie_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromRadioactiveZombieExplosion);
                    break;
                case EDamageOrigin.Rocket_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromRocketExplosion);
                    break;
                case EDamageOrigin.Sentry:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromSentry);
                    break;
                case EDamageOrigin.Trap_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromTrapExplosion);
                    break;
                case EDamageOrigin.Useable_Gun:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromUseableGun);
                    break;
                case EDamageOrigin.Useable_Melee:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromUseableMelee);
                    break;
                case EDamageOrigin.Vehicle_Explosion:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromVehicleExplosion);
                    break;
                case EDamageOrigin.Zombie_Electric_Shock:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromZombieElectricShock);
                    break;
                case EDamageOrigin.Zombie_Fire_Breath:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromZombieFireBreath);
                    break;
                case EDamageOrigin.Zombie_Stomp:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromZombieStomp);
                    break;
                case EDamageOrigin.Zombie_Swipe:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromZombieSwipe);
                    break;
                case EDamageOrigin.Vehicle_Collision_Self_Damage:
                    pendingTotalDamage = (ushort)(pendingTotalDamage * Instance.Configuration.Instance.DamageFromVehicleCollisionSelfDamage);
                    break;
            }
        }
    }
}
