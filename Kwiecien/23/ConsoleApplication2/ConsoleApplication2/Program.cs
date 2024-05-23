namespace ConsoleApplication2
{
    class Zwierze
    {
        public void DajGlos()
        {
            
        }
    }

    class Kot : Zwierze
    {
        public void drapMeble()
        {
            
        }
    }

    class NorwieskiLesny : Kot
    {
        public void gubSierc()
        {
            
        }
    }

    class Pers : Kot
    {}

    class Pies : Zwierze
    {
        public void GryzKapcie()
        {
            
        }
    }

    class Doberman : Pies
    {
        public void gonListonosza()
        {
            
        }
    }

    class Jamnik : Pies
    {
        
    }
    internal class Program
    {
        public static void Main(string[] args)
        {
            Doberman dob = new Doberman();
            dob.DajGlos();
            dob.GryzKapcie();
            dob.gonListonosza();
        }
    }
}