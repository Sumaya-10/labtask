using System.IO;

namespace _16oktclassroomtask;

public class Weapon
{
    public int GunCapasity { get; set; }
    public int BulletCount { get; set; }
    public float GunDischarge { get; set; }
    public string ShootMood { get; set; }
    public Weapon()
    {

    }
    public Weapon(int gunCapasity, int bulletCount, float gunDischarge, string shootMood)
    {
        if (gunCapasity < 0 || bulletCount < 0 || gunDischarge <= 0)
            return;
        GunCapasity = gunCapasity;
        BulletCount = bulletCount;
        GunDischarge = gunDischarge;
        ShootMood = shootMood;
    }

    public void Shoot()
    {
        if (BulletCount > 0)
        {
            BulletCount--;
            Console.WriteLine("new bullet count; " + BulletCount);
        }
        else
        {
            Console.WriteLine("Hal-hazirda daraqda gulle yoxdur");
        }
    }
    public void Fire()
    {
        if (BulletCount > 0)
        {
            if (ShootMood == "Auto")
            {
                float spentTime = (BulletCount * GunDischarge) / GunCapasity;
                Console.WriteLine($"{BulletCount} gulle istifade edildi. Ates {spentTime} saniye davam etdi");

                BulletCount = 0;
            }
            else
            {
                Shoot();
            }
        }
         else
         {
            Console.WriteLine("Hal-hazirda daraqda gulle yoxdur!!!");
         }

    }

    public int GetRemainBulletCount()
    {
        int remainBulletsCount = GunCapasity - BulletCount;
        return remainBulletsCount;
    }

    public void Reload()
    {
        if (BulletCount != GunCapasity)
        {
            Console.WriteLine("Daraq deyisdirildi");
            BulletCount = GunCapasity;
        }
        else
        {
            Console.WriteLine("doludur!");
        }
    }

    public void ChangeMod()
    {
        if (ShootMood == "Auto")
        {
            ShootMood = "Single";
        }
        else
        {
            ShootMood = "Auto";
        }

        Console.WriteLine("Atis modu" + ShootMood + "olaraq deyisdirildi");
    }
}
