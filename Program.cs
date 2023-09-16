namespace BossAzConsole
{
    enum MyEnum
    {
        Murad =1,
        Anvar, 
        Rasul
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Email.SendMail("muradqocayevi20@gmail.com", "Hello");

            Enum[] enums = { MyEnum.Murad, MyEnum.Anvar, MyEnum.Rasul };
            Enum answer = Display.ShowWithvariants(enums);
            //App.Start();


        }
    }
}