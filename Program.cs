namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            City Pawnee = new City("Springfield");
            Pawnee.AddMayor("Mayor Quimby");

            Building FiveOneTwoEighth = new Building("512 8th Avenue");
            FiveOneTwoEighth.Width = 2;
            FiveOneTwoEighth.Depth = 3;
            FiveOneTwoEighth.Stories = 20;
            FiveOneTwoEighth.Construct();
            FiveOneTwoEighth.Purchase("Chris");
            Pawnee.AddBuilding(FiveOneTwoEighth);

            Building OneTwoFake = new Building("12 Fake Street");
            OneTwoFake.Width = 10;
            OneTwoFake.Depth = 0;
            OneTwoFake.Stories = 1;
            OneTwoFake.Construct();
            OneTwoFake.Purchase("Tyler");
            Pawnee.AddBuilding(OneTwoFake);

            Pawnee.ListBuildings();
        }
    }
}