namespace UnitTestsDemoPart3
{
    public class Greeter
    {
        private readonly IEmailer emailer;
        private readonly IDatabaseRepository databaseRepository;

        public Greeter(IEmailer emailer, IDatabaseRepository databaseRepository)
        {
            this.emailer = emailer;
            this.databaseRepository = databaseRepository;
        }

        //public Greeter()
        //{
        //    emailer = new Emailer();
        //    databaseRepository = new DatabaseRepository();
        //}

        public string SayHello(string name)
        {
            emailer.SendWelcomeEmail(name);
            databaseRepository.SaveName(name);

            return $"Hello, {name}!";
        }
    }

    public interface IEmailer
    {
        public void SendWelcomeEmail(string name);
    }

    public interface IDatabaseRepository
    {
        public void SaveName(string name);
    }

    public class Emailer : IEmailer
    {
        public void SendWelcomeEmail(string name)
        {
            // send out email here
        }
    }

    public class DatabaseRepository : IDatabaseRepository
    {
        public void SaveName(string name)
        {
            // save to database here
        }
    }
}
