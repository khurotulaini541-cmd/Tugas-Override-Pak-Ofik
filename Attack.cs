using System;

namespace TugasSetelahOvr_AttackSystem
{
    public class Attack
    {
        protected string attackName;
        protected float baseDamage;
        protected float range;

        
        public Attack()
        {
            attackName = "Basic Attack";
            baseDamage = 20f;
            range = 1f;
        }

       
        public Attack(string name, float damage, float range)
        {
            attackName = name;
            baseDamage = damage;
            this.range = range;
        }

        
        public virtual float ExecuteAttack()
        {
            Console.WriteLine($"\n[{attackName}] Menggunakan serangan dasar...");
            return baseDamage;
        }

        public float ExecuteAttack(float defense)
        {
            Console.WriteLine($"\n[{attackName}] Menyerang musuh dengan pertahanan {defense}...");
            float damage = baseDamage - defense;
            return damage < 0 ? 0 : damage;
        }

        
        public float ExecuteAttack(float defense, float dodgeChance)
        {
            Console.WriteLine($"\n[{attackName}] Menyerang musuh (Defense: {defense}, Dodge: {dodgeChance * 100}%)...");

            Random rand = new Random();
            if (rand.NextDouble() < dodgeChance)
            {
                Console.WriteLine("-> Musuh berhasil menghindar (Dodge)!");
                return 0f;
            }

            float damage = baseDamage - defense;
            return damage < 0 ? 0 : damage;
        }

        
        public float ExecuteAttack(string hitLocation)
        {
            Console.WriteLine($"\n[{attackName}] Menyerang area {hitLocation}...");
            float multiplier = 1.0f;

            switch (hitLocation.ToLower())
            {
                case "head":
                    multiplier = 2.0f;
                    break;
                case "body":
                    multiplier = 1.0f;
                    break;
                case "leg":
                    multiplier = 0.8f;
                    break;
                default:
                    Console.WriteLine("-> Lokasi serangan tidak dikenal, menggunakan damage standar.");
                    break;
            }

            return baseDamage * multiplier;
        }

        public virtual void DisplayAttackInfo()
        {
            Console.WriteLine($"--- ATTACK INFO ---");
            Console.WriteLine($"Attack Name : {attackName}");
            Console.WriteLine($"Base Damage : {baseDamage}");
            Console.WriteLine($"Range       : {range}m");
        }
    }
}