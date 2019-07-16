using Rocket.API;

namespace FRVehicleDamageControl
{
    public class VehicleDamageControlConfiguration : IRocketPluginConfiguration
    {
        public float DamageFromBulletExplosion;
        public float DamageFromAnimalAttack;
        public float DamageFromFlammableZombieExplosion;
        public float DamageFromFoodExplosion;
        public float DamageFromMegaZombieBoulder;
        public float DamageFromPunch;
        public float DamageFromRadioactiveZombieExplosion;
        public float DamageFromRocketExplosion;
        public float DamageFromSentry;
        public float DamageFromTrapExplosion;
        public float DamageFromUseableGun;
        public float DamageFromUseableMelee;
        public float DamageFromVehicleBumper;
        public float DamageFromVehicleExplosion;
        public float DamageFromZombieElectricShock;
        public float DamageFromZombieFireBreath;
        public float DamageFromZombieStomp;
        public float DamageFromZombieSwipe;


        public void LoadDefaults()
        {
            DamageFromBulletExplosion = 0.2f;
            DamageFromAnimalAttack = 0.3f;
            DamageFromFlammableZombieExplosion = 0.2f;
            DamageFromFoodExplosion = 0.4f;
            DamageFromMegaZombieBoulder = 0.7f;
            DamageFromPunch = 0.0f;
            DamageFromRadioactiveZombieExplosion = 0.2f;
            DamageFromRocketExplosion = 0.7f;
            DamageFromSentry = 0.2f;
            DamageFromTrapExplosion = 0.4f;
            DamageFromUseableGun = 0.2f;
            DamageFromUseableMelee = 0.0f;
            DamageFromVehicleBumper = 0.5f;
            DamageFromVehicleExplosion = 1.0f;
            DamageFromZombieElectricShock = 0.2f;
            DamageFromZombieFireBreath = 0.2f;
            DamageFromZombieStomp = 0.2f;
            DamageFromZombieSwipe = 0.2f;
        }
    }
}
