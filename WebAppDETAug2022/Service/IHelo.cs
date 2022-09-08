namespace WebAppDETAug2022.Service
{
    public interface IHelo
    {
        string SayHelo(string name);
    }
    public class Helo1 : IHelo
    {
        public string SayHelo(string name)
        {
            return $"Helo {name}, Welcome to ASP. NET Core";
        }
    }
    public class Helo2 : IHelo
    {
        public string SayHelo(string name)
        {
            return $" hii, Helo {name}, howz the day";
        }
    }
}
