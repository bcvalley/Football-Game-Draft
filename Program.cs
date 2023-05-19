namespace Football2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Coach c1 = new Coach("Boiko Borisov", 44);
            Coach c2 = new Coach("Dimitar Berbatov", 44);
            Striker s1 = new Striker("Atanas", 44, 11, 170);
            Striker s2 = new Striker("Pencho", 44, 11, 170);
            Striker s3 = new Striker("Plamen", 44, 11, 170);
            Striker s4 = new Striker("Slavqn", 44, 11, 170);
            Goalkeeper goalkeeper1 = new Goalkeeper("Qsen",1,39,170);
            Striker s5 = new Striker("Nikolai", 44, 11, 170);
            Striker s6 = new Striker("Stamen", 44, 11, 170);
            Striker s7 = new Striker("Petko", 44, 11, 170);
            Striker s8 = new Striker("Qvor", 44, 11, 170);
            Striker s9 = new Striker("Petko", 44, 11, 170);
            Striker s10 = new Striker("Qvor", 44, 11, 170);
            Player[] playersT1 = {s1,s2,s3,s4,s5,s6,s7,s8,s9,s10,goalkeeper1};
            Striker t1 = new Striker("Atanas", 44, 11, 170);
            Striker t2 = new Striker("Pencho", 44, 11, 170);
            Striker t3 = new Striker("Plamen", 44, 11, 170);
            Striker t4 = new Striker("Slavqn", 44, 11, 170);
            Goalkeeper goalkeeper2 = new Goalkeeper("Qsen",1,39,170);
            Striker t5 = new Striker("Nikolai", 44, 11, 170);
            Striker t6 = new Striker("Stamen", 44, 11, 170);
            Striker t7 = new Striker("Petko", 44, 11, 170);
            Striker t8 = new Striker("Qvor", 44, 11, 170);
            Striker t9 = new Striker("Petko", 44, 11, 170);
            Striker t10 = new Striker("Qvor", 44, 11, 170);
            Player[] playersT2 = {t1,t2,t3,t4,t5,t6,t7,t8,t9,t10,goalkeeper2};
            Team team1 = new Team(c1,playersT1);
            Team team2 = new Team(c2,playersT2);
            Ref reff = new Ref("Jokovich", 80);
            Ref assreff1 = new Ref("Stancho", 90);
            Ref assreff2 = new Ref("Jokovich", 100);
            Game game = new Game(team1,playersT1,team2,playersT2,reff,assreff1,assreff2);
            
            
        }
    }
}