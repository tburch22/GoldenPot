namespace CLIEngine.MarioBros;

// Takes a canvas or analog object and generates a composite of each layer.
public class Renderer
{
    List<List<List<Rich>>> buffer;
    List<List<Rich>> final;
    List<dynamic> tasks;

    public Renderer() {
        buffer = new List<List<List<Rich>>>();
        final = new List<List<Rich>>();
        tasks = new List<dynamic>();
    }

    
}
