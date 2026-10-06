using System;

namespace TugasSetelahOvr_AttackSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("       DEMO SISTEM SERANGAN (ATTACK SYSTEM)       ");
            Console.WriteLine("==================================================\n");

            
            MeleeAttack swordSlash = new MeleeAttack("Sword Slash", 60f, 2f, 0.3f);
            swordSlash.DisplayAttackInfo();

            float meleeDmg = swordSlash.ExecuteAttack();
            Console.WriteLine($"Total Damage Melee: {meleeDmg}");

            Console.WriteLine("\n--------------------------------------------------");

            
            RangedAttack arrowShot = new RangedAttack("Fire Arrow", 45f, 15f, 80f);
            arrowShot.DisplayAttackInfo();

            float rangedDmg = arrowShot.ExecuteAttack();
            Console.WriteLine($"Total Damage Ranged: {rangedDmg}");

            Console.WriteLine("\n==================================================");
            Console.WriteLine("          DEMO METHOD OVERLOADING AYNIEE                 ");
            Console.WriteLine("==================================================");

            
            float dmg1 = swordSlash.ExecuteAttack(15f);
            Console.WriteLine($"Hasil Damage (Defense 15): {dmg1}");

            float dmg2 = swordSlash.ExecuteAttack(10f, 0.2f);
            Console.WriteLine($"Hasil Damage (Defense 10, Dodge 20%): {dmg2}");

            float dmgHead = arrowShot.ExecuteAttack("head");
            Console.WriteLine($"Hasil Damage (Hit Head): {dmgHead}");

            float dmgLeg = arrowShot.ExecuteAttack("leg");
            Console.WriteLine($"Hasil Damage (Hit Leg): {dmgLeg}");

            Console.WriteLine("\nTekan sembarang tombol untuk keluar...");
            Console.ReadKey();
        }
    }
}