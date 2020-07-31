using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesExercise.Logic
{
    public abstract class Bee
    {
        private float _health = 100;
        public Bee(string type, float minHealth)
        {
            Type = type;
            Health = _health;
            MinHealth = minHealth;
        }

        public virtual string Type { get; set; }
        public virtual float MinHealth { get; set; }

        public virtual float Health
        {
            get { return _health; } 
            private set
            {
                if(value >= 0 && value <= 100)
                {
                    _health = value;
                }
                else
                {
                   _health = 0;
                }
            }
        }

        public virtual bool Alive 
        { 
            get 
            { 
                if (Health >= MinHealth)
                { 
                    return true;
                }
                else 
                {
                    return false;
                }
            
            }
        }

        public virtual void Damage(int dmg)
        {
            if(Alive == true && dmg >= 0 && dmg <= 100)
            {
                this.Health -= dmg;
            }
            else
            {
                this.Health -= 0;
            }
            
        }

        public override string ToString()
        {
            return $"{Type}";
        }
    }
}
