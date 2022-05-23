namespace MagicalInheritance
{
    public class Pupile{
        public string Title{
            get; private set;
        }
        public Pupile(string title){
            Title = title;

        }

        public Storm CastWindStorm(){
            Storm s1 = new Storm("wind",false,this.Title);
            return s1;
        }

    }
    
}