
using NFL;
using System;

namespace Driver

{
    class DriverClass
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Welcome to the AFC!");
            callAFC();
            callNFC();
            printStuffFromTheOtherFile();
        }

        static void callAFC()
        {
            NFL.Conference conference = new NFL.Conference("AFC");
            conference.printConference();

        }

        static void callNFC()
        {
            NFL.Conference conference = new NFL.Conference("NFC");
            conference.printConference();

        }

        static void printStuffFromTheOtherFile()
        {
            SomeNamespaceInADifferentFile.AClassFromAnotherFile someObject = new SomeNamespaceInADifferentFile.AClassFromAnotherFile();
            Console.WriteLine(someObject.aMessageFromAnotherFile());
        }

    }
}

namespace NFL

{
    class Conference
    {

        string conferenceName;

        public Conference(string name)
        {
            this.conferenceName = name;
        }

        public void printConference()
        {
            Console.WriteLine(this.conferenceName);
        }

    }

    class Division : Conference
    {
        string divisionName;
        public Division(string divisionName, string name) : base(name)
        {
            this.divisionName = divisionName;
        }

    }

    class Team : Division
    {
        string teamName;
        public Team(string teamName, string divisionName, string conferenceName) : base(divisionName, conferenceName)
        {
            this.teamName = teamName;
        }

    }
}

namespace Owners
{

    class Owner
    {

        private int netWorth;
        string name;
        public Owner(string name, int netWorth)
        {
            this.netWorth = netWorth;
            this.name = name;
        }

        public void hireGM()
        {

        }

        public void fireGM()
        {

        }

        public void hireCoach()
        {

        }

        public void fireCoach()
        {

        }

        public void buyTeam()
        {

        }

        public void sellTeam()
        {

        }

        public void moveTeam()
        {

        }
    }

}

namespace Players
{
    class Player
    {

        string name;
        public float height;

        public Player(string name, float height)
        {

            this.name = name;
            this.height = height;

        }
    }
}

