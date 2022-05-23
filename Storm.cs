namespace MagicalInheritance
{
    public class Storm{
        public string Essence{
            get; set;
        }
        public bool IsStrong{
            get; set;
        }
        public string Caster{
            get; set;
        }

        public Storm(string essence,bool isstrong, string caster){
            Essence = essence;
            IsStrong = isstrong;
            Caster = caster;
        }

        public void Announce(){
            Console.WriteLine($"{Caster} cast a {IsStrong} {Essence} storm");
        }

    }
    
}