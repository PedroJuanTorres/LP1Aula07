namespace MyGame
{
    class Enemy
    {
        private string name;
        private float health;
        private float shield;

        //Construtor
        public Enemy(string name){
            this.name = name;
            health = 100;
            shield = 0;
        }
    }
}