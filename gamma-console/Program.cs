using gamma_console.Client;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Write teamname: ");
        MemberClient mc = new MemberClient();
        var tmp=mc.GetMember(new Guid("79492e57-2638-46ab-ba6e-08da76c71246"));
        mc.getTeamMember("gamma");
        

    }
}