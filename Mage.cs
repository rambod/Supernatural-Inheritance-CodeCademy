namespace MagicalInheritance
{

    public class Mage : Pupile {


        public Mage(string title) : base(title){
            
        }
        public Storm CastRainStorm(){
            Storm s = new Storm("wind",true,"Mage");
            return s;
        }

    }
    
}