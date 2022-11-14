namespace CLIEngine.MarioBros;

// Takes a canvas or analog object and generates a composite of each layer.
public class Renderer
{
    private List<List<List<Rich>>> buffer;
    private List<List<Rich>> final;
    private List<dynamic> contexts;

    public Renderer() {
        buffer = new List<List<List<Rich>>>();
        final = new List<List<Rich>>();
        contexts = new List<dynamic>();
    }
    
    public void Stash(dynamic context) {
        contexts.Add(context);
    }

    public string Process() {
        foreach(dynamic contextObject in contexts) {
            if (contextObject.getType() == typeof(Canvas)) {
                Console.WriteLine("EILJFDIEWWWWWWSENFSENF");
            }
        }
        return "kwjelkw";
    }
}
