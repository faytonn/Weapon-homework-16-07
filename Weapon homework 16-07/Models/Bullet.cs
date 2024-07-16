using Weapon_homework_16_07.behindthestage;

namespace Weapon_homework_16_07.Models
{
    public class Bullet : BaseEntity
    {
        private static int _id;
        public BulletType Type { get; set; }
        public Bullet(BulletType type)
        {
            Id = ++_id;
            Type = type;
        }
    }
}
