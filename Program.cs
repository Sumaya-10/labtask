namespace _16oktclassroomtask;

 public class Program
{
    static void Main(string[] args)
    {
        Weapon weapon = new Weapon(70, 40, 3.6f, "Auto");
        int number = 0;
        bool process = true;
        while (process)
        {
            number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:

                    Console.WriteLine("number verildi");
                    break;

                case 1:
                    {
                        weapon.Shoot();
                        break;
                    }

                case 2:
                    weapon.Fire();
                    break;

                case 3:
                    Console.WriteLine(weapon.GetRemainBulletCount());
                    break;
                case 4:
                    weapon.Reload();
                    break;

                case 5:
                    weapon.ChangeMod();
                    break;

                case 6:
                    Console.WriteLine("prases bitdi");
                    process = false;
                    break;

                default:

                    Console.WriteLine("Duzgun number daxil edilmedi");
                break;
                }
            }
        }
    }
 
