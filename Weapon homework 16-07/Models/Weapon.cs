using Weapon_homework_16_07.behindthestage;
using Weapon_homework_16_07.Exceptions;

namespace Weapon_homework_16_07.Models
{
    public class Weapon : BaseEntity
    {
        private static int _id;
        private Queue<Bullet> Bullets { get; set; }
        public WeaponName ChosenWeaponName { get; set; }
        public BulletType BulletTypeOfWeapon { get; set; }
        public int BulletCapacity { get; set; }
        public Weapon(int bulletCapacity, BulletType bulletTypeOfWeapon)
        {
            Id = ++_id;
            BulletTypeOfWeapon = bulletTypeOfWeapon;
            BulletCapacity = bulletCapacity;
            Bullets = new Queue<Bullet>();
        }
        public enum WeaponName
        {
            M416,
            AKM,
            VSS,
            UMP45,
            AWM,
            Crossbow,
            M249,
            M762,
        }
        public void Fire()
        {
            if (Bullets.Count > 0)
            {
                var bullet = Bullets.Dequeue();
                Console.WriteLine($"Action executed, \n{BulletTypeOfWeapon} bullet fired. Bullets remaining: {Bullets.Count}.");
            }
            throw new NoBulletRemainingException("No bullets remaining!");
        }

        public void Fill(BulletType bulletType)
        {
            while (Bullets.Count == 0)
            {
                for (int i = 0; i < BulletCapacity; i++)
                {
                    Bullets.Enqueue(new Bullet(bulletType));
                }
                Console.WriteLine($"Weapon automatically filled. \nYou now have {Bullets.Count} remaining.");
                return;
            }

        }

        public void Reload(BulletType bulletType)
        {
            if (Bullets.Count < BulletCapacity)
            {
                int BulletsToBeAdded = BulletCapacity - Bullets.Count;
                for (int i = 0; i < BulletsToBeAdded; i++)
                {
                    Bullets.Enqueue(new Bullet(bulletType));
                }
                Console.WriteLine($"{BulletsToBeAdded} bullets reloaded. \nYou now have {Bullets.Count} bullets.");
            }
            Console.WriteLine($"Weapon is already fully loaded. \n({Bullets.Count}/{BulletCapacity} bullets remaining.)");
        }
        public void WeaponInfo()
        {
            Console.WriteLine($"IdWeapon name: {ChosenWeaponName.ToString()}, Bullet type: {BulletTypeOfWeapon.ToString()}, Capacity: {BulletCapacity}");
        }

    }
}
