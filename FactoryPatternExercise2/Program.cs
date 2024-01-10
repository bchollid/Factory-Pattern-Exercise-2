namespace FactoryPatternExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Which database would you like to use?");
            var userResponse = Console.ReadLine();
            if(userResponse == null)
            {
                Console.WriteLine("Please enter a valid database");
            }
            else
            {
                IDataAccess newDataAccess = DataAccessFactory.GetDataAccessType(userResponse);
                newDataAccess.LoadData();
                newDataAccess.SaveData();
            }


        }
    }
}
