using System;

namespace TugasSetelahOvr_AttackSystem
{
    public class RangedAttack : Attack
    {
        private float projectileSpeed;

        
        public RangedAttack() : base("Sniper Shot", 40f, 20f)
        {
            projectileSpeed = 50f;
        }

       
        public RangedAttack(string name, float damage, float range, float projectileSpeed)
            : base(name, damage, range)
        {
            this.projectileSpeed = projectileSpeed;
        }

        public override float ExecuteAttack()
        {
            Console.WriteLine($"\n[{attackName}] Menembak dari jarak {range}m dengan Kecepatan Proyektil {projectileSpeed} m/s!");
            float totalDamage = baseDamage + (projectileSpeed * 0.1f);
            return totalDamage;
        }
    }
}