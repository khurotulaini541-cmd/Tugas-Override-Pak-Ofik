using System;

namespace TugasSetelahOvr_AttackSystem
{
    public class MeleeAttack : Attack
    {
        private float armorPen; 
        
        public MeleeAttack() : base("Heavy Slash", 50f, 1.5f)
        {
            armorPen = 0.25f;
        }

        
        public MeleeAttack(string name, float damage, float range, float armorPen)
            : base(name, damage, range)
        {
            this.armorPen = armorPen;
        }

        
        public override float ExecuteAttack()
        {
            Console.WriteLine($"\n[{attackName}] Melakukan serangan jarak dekat dengan Armor Pen {armorPen * 100}%!");
            return baseDamage * (1f + armorPen);
        }
    }
}