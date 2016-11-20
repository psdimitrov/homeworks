using System.Linq;
using System.Reflection;

namespace Blobs.Models
{
    using System;

    using Contracts;

    public class Blob : IBlob
    {
        private readonly int initialHealth;

        private string name;
        private int health;
        private int damage;
        private bool dead;
        private IAttack attack;
        private IBehavior behavior;
        private readonly string behaviorType;
        private bool behaviorTriggered;

        public Blob(string name, int health, int damage, IAttack attack, string behaviorType)
        {
            this.Name = name;
            this.Health = health;
            this.initialHealth = Health;
            this.Damage = damage;
            this.attack = attack;
            this.behaviorType = behaviorType;
            this.dead = false;

        }

        public string Name
        {
            get
            {
                return this.name;
                
            }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                this.name = value;
            }
        }

        public bool Dead
        {
            get { return this.dead; }
            private set
            {
                if (value)
                {
                    this.dead = true;
                }
            }

        }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(this.damage), "Attack damage cannot be negative.");
                }
                this.damage = value;
            }
        }
        public int Health
        {
            get
            {
                return this.health;
            }

            set
            {
                this.health = value < 0 ? 0 : value;
            }
        }

        public IAttack Attack => this.attack;

        public void AttackEnemy(IBlob enemyBlob, IAttack attackType)
        {
            this.Health = attackType.ChangeHealth(this.Health);
            CheckBehaviorDuringAttack();
            
            enemyBlob.Health -= attackType.ChangeDamage(this.Damage);
        }

        private void CheckBehaviorDuringAttack()
        {
            if (this.Health <= this.initialHealth/2)
            {
                if (this.behavior == null)
                {
                    this.TriggerBehavior();
                    this.behaviorTriggered = true;
                }
            }
        }

        public void Update()
        {
            if (this.Health <= this.initialHealth / 2)
            {
                if (this.behavior == null)
                {
                    TriggerBehavior();
                    return;
                }
            }
            if (this.behaviorTriggered)
            {
                this.behaviorTriggered = false;
            }
            else
            {
                if (this.behavior != null)
                {
                    this.behavior.Behave(this);
                }

            }

            if (this.Health == 0)
            {
                this.Dead = true;
            }
        }

        private void TriggerBehavior()
        {
            var type = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name == behaviorType);

            if (type == null)
            {
                throw new ArgumentException("Unknown behavior type.");
            }

            this.behavior = (IBehavior) Activator.CreateInstance(type, this);
        }

        public override string ToString()
        {
            string result;

            if (this.Dead)
            {
                result = string.Format("Blob {0} KILLED", this.Name);
            }
            else
            {
                result = string.Format("Blob {0}: {1} HP, {2} Damage", this.Name, this.Health, this.Damage);
            }

            return result;
        }
    }
}
