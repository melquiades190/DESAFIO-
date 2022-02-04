namespace Poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name,int Lavel,string HeroType)  // Método construtor
        {
            this.Name = Name;
            this.Lavel = Lavel;
            this.HeroType = HeroType;


        }
        public override string Attack()
        {
            return this.Name + "Atacou com sua espada ";
        
    }
    public string Attack(int Bonus) // Método
        {
            if (Bonus > 6){

                return this.Name +  "  Lançou magia super efetiva com bonos de ataque de  "  + Bonus;

            }else{
                return this.Name  + "Lançao magia com força frava com bonus de " + Bonus;
            }
             
        
    }
        
    }
}