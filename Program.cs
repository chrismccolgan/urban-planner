namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Springfield = new City("Springfield");
            Springfield.AddMayor("Mayor Quimby");

            Building FiveOneTwoEighth = new Building("512 8th Avenue");
            FiveOneTwoEighth.Width = 2;
            FiveOneTwoEighth.Depth = 3;
            FiveOneTwoEighth.Stories = 20;
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Chris");
            Springfield.AddBuilding(FiveOneTwoEighth);

            Building OneTwoFake = new Building("12 Fake Street");
            OneTwoFake.Width = 10;
            OneTwoFake.Depth = 0;
            OneTwoFake.Stories = 1;
            OneTwoFake.Construct();
            OneTwoFake.Purchase("Tyler");
            Springfield.AddBuilding(OneTwoFake);

            Springfield.ListBuildings();
        }
    }
}