﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Health_System_v3._0
{
    public abstract class CHARACTER
    {
        //fields:
        protected string _name;
        protected int _health;

        //methods:
        public void TakeDamage(int damage) 
        {
            ErrorCheck(damage);
            Console.WriteLine("         " + this._name + " took " + damage + " points of Damage");
            _health -= damage;
        
        }
        public void Heal(int healing) 
        {
            ErrorCheck(healing);
            Console.WriteLine("         "+this._name+" Healed "+healing+" Points");
            _health += healing;
        }
        public void CheckRange() 
        {
            if (_health >= 101) { _health = 100; }
            if (_health <= 0) { _health = 0; }

        }
        public void ErrorCheck(int input)
        {
            if (input <= 0) { Console.WriteLine("ERROR: input cannot be negative"); }
            else { return; }

        }
        //debug:
        public void debugSetHealth(int health) 
        {
            _health = health;
            Console.WriteLine("         setting " + this._name + " Health to "+ health);
        
        }


    }
}
