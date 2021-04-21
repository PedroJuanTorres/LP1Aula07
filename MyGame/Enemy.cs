namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Construtor
        public Enemy(string name){
            SetName(name);
            health = 100;
            shield = 0;
        }
        public string GetName(){
            return name;
        }

        public float GetHealth(){
            return health;
        }
        public float GetShield(){
            return shield;
        }
        public void TakeDamage(float damage){
            shield -= damage;
            if(shield < 0){
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if(health < 0) health = 0;
            }
        }
        public void SetName(string name){
            this.name = name.Trim();
        }

        public void PickupPowerUp(PowerUp pu, float gain)
        {
            if(pu == PowerUp.Health)
            {
                health += gain;
                if(health > 100) health = 100;
                if(health < 0) health = 0;
            }
            else if(pu == PowerUp.Shield){
                shield += gain;
                if(shield > 100) shield = 100;
                if(shield < 0) shield = 0;
            }
        }
    }
}