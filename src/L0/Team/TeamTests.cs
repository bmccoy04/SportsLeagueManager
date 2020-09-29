using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace L0.Team
{
    public class TeamTests
    {
        [Fact]
        public void Can_Create_Team_Object()
        {
            var team = new Team("Team Number One", "Tiger", new Coach());
            
            team.ShouldNotBeNull();
            team.Name.ShouldBe("Team Number One");
            team.Mascot.ShouldBe("Tiger");
            team.Coach.ShouldNotBeNull();
        }
    }

    public class Team
    {
        public Team(string name, string mascot, Coach coach)
        {
            Name = name;
            Mascot = mascot;
            Coach = coach;
        }
        public string Name { get; private set; }     
        public string Mascot { get; private set; }
        public Coach Coach { get; private set; }

        public void ChangeCoach(Coach coach)
        {
            this.Coach = coach;
        }
    }

    public class Coach
    {
    }
}