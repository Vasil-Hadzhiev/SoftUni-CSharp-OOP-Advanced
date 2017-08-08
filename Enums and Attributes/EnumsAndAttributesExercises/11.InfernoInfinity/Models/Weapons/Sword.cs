﻿using _11.InfernoInfinity.Enums;

namespace _11.InfernoInfinity.Models.Weapons
{
    public class Sword : Weapon
    {
        private const int MinDamage = 4;
        private const int MaxDamage = 6;
        private const int SocketsNumber = 3;

        public Sword(string name, WeaponRarity rarity) 
            : base(name, rarity, MinDamage, MaxDamage, SocketsNumber)
        {
        }
    }
}
