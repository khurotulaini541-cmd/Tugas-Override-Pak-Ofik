using System;

namespace GameOverrideDemo
{
    public class PhysicalSkill : Skill
    {
       
        private float critRate;

        
        public PhysicalSkill() : base()
        {
            critRate = 0.2f;
        }

        public PhysicalSkill(string name, float power, float cost, float critRate)
            : base(name, power, cost)
        {
            this.critRate = critRate;
        }

        
        public override float CalculateDamage()
        {
            Console.WriteLine("[PhysicalSkill.CalculateDamage] Menghitung damage fisik dengan critical hit...");
            return basePower * (1 + critRate);
        }

        
        public float CalculateDamage(bool isBackstab)
        {
            Console.WriteLine($"[PhysicalSkill.CalculateDamage] Menghitung damage fisik dengan backstab: {isBackstab}");
            float damage = basePower * (1 + critRate);
            if (isBackstab)
            {
                damage *= 1.5f;
            }
            return damage;
        }
    }
}