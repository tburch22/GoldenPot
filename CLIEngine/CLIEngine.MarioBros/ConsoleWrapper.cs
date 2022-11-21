namespace CLIEngine.MarioBros;

public static class ConsoleWrapper
{
    public static void flush(String charFlow) {
        Console.Clear();
        Console.Write(charFlow);
    }

    public static void throttle(int delta) {
        System.Threading.Thread.Sleep(1000/delta);
    }
}
