using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Team team = new Team("SU");
            Person person = new Person("aaaa", "bbbb", 12, 1000);
            team.AddPlayer(person);
            Console.WriteLine(team.FirstTeam.Count);
            Console.WriteLine(team.ReserveTeam.Count);
        }
    }
}
