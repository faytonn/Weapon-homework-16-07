using Weapon_homework_16_07.behindthestage;
using Weapon_homework_16_07.Models;
bool systemProcess = true;





Console.WriteLine("Welcome! Please choose your weapon:");

foreach (var weapon in Enum.GetNames<WeaponName>())
{
    var weaponInfo = Weapon.GetWeaponInfo(weapon);
    Console.WriteLine(weaponInfo);

}

WeaponName chosenWeapon = new WeaponName(); 
Console.Write("Choose the weapon you want to use: ");
string weaponChoice = Console.ReadLine();

switch (weaponChoice)
{
    case 
}


