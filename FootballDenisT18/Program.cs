using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballDenisT18
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Coach coach1 = new Coach { Name = "Пеп Гуардиола", Age = 45 };
            Coach coach2 = new Coach { Name = "Шави Ернандес", Age = 42 };

            List<Football_player> team1Players = new List<Football_player>
{
    new Football_player { Name = "Едерсон", Age = 26 },
    new Football_player { Name = "Уолкър", Age = 31 },
    new Football_player { Name = "Стоунс", Age = 29 },
    new Football_player { Name = "Лапорт", Age = 27 },
    new Football_player { Name = "Зафер", Age = 20 },
    new Football_player { Name = "Кевин Де Бройне", Age = 31 },
    new Football_player { Name = "Гюндоган", Age = 32 },
    new Football_player { Name = "Фоудън", Age = 21 },
    new Football_player { Name = "Алварез", Age = 22 },
    new Football_player { Name = "Халанд", Age = 22 },
    new Football_player { Name = "Грийлиш", Age = 24 }
};
            Team team1 = new Team { Name = "Манчестър Сити", Coach = coach1, Players = team1Players };

            List<Football_player> team2Players = new List<Football_player>
{
    new Football_player { Name = "Тер Стеген", Age = 31 },
    new Football_player { Name = "Балде", Age = 19 },
    new Football_player { Name = "Араухо", Age = 22 },
    new Football_player { Name = "Кунде", Age = 24 },
    new Football_player { Name = "Кристенсен", Age = 28 },
    new Football_player { Name = "Де Йонг", Age = 25 },
    new Football_player { Name = "Гави", Age = 19 },
    new Football_player { Name = "Педри", Age = 21 },
    new Football_player { Name = "Дембеле", Age = 26 },
    new Football_player { Name = "Робърт Левандовски", Age = 34 },
    new Football_player { Name = "Рафиня", Age = 28 },
};
            Team team2 = new Team { Name = "Барселона",Coach = coach2, Players = team2Players };
            ;
            foreach (var player in team1Players)
            {
                Console.WriteLine("Футболисти на Манчестър Сити: {0}", player.Name);
            }
            foreach (var player in team2Players)
            {
                Console.WriteLine("Футболисти на Барселона: {0}", player.Name);
            }


            Game game = new Game
            {
                Team1 = team1,
                Team2 = team2,
                Referee = new Referee { Name = "Георги Кабаков", Age = 40 },
                AssistantReferees = new List<AssistantReferee>
            {
                  new AssistantReferee { Name = "Ивайло Стоянов", Age = 35 },
                  new AssistantReferee { Name = "Волен Чинков", Age = 38 }

            },
                Goals = new List<Goal>(),
                Result = "2-6",
                Winner = team2
            };
            
           
            Console.WriteLine("Треньор на домакините: {0}", coach1.Name);
            Console.WriteLine("Треньор на гостите: {0}", coach2.Name);
            Console.WriteLine("Главен рефер: {0}", game.Referee.Name);
            Console.WriteLine("Средната възраст на футболистите от Манчестър Сити: " + team1.AveragePlayerAge);
            Console.WriteLine("Средната възраст на футболистите от Барселона: " + team2.AveragePlayerAge);
            Console.WriteLine("Краен резултат: {0}", game.Result);
            Console.WriteLine("Победител: {0}", team2.Name);
        }
    }
}
