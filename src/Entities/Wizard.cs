namespace Poo.src.Entities
{

    public class Wizard : Hero // Herança
    {
        public Wizard (string Name,int Lavel,string HeroType)  // Método construtor
        {
            this.Name = Name;
            this.Lavel = Lavel;
            this.HeroType = HeroType;


        }
        
        public override string Attack()
        {
            return this.Name + "Lançou magia ";
        
    }
    public string Attack(int Bonus) // Método
        {
            if (Bonus>6){

                return this.Name +   " Lançou magia super efetiva com Bonus de "  + Bonus; // encapsulamento 
            }else{
                return this.Name +  "lançou magia com força fraca com bonus de" + Bonus;
            }
           
        
    }
    

    }
}