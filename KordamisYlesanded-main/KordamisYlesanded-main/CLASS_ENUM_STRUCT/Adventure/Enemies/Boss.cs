using System;
namespace Adventure.Enemies
{
    public class Boss : Enemy
    {
        public string BossWeaponName { get; set; }
        public int BossWeaponHitPower { get; set; }
        public Boss(string weapon, int weaponpower, string naem, int health)
    }
}
