namespace CLIEngine.MarioBros._painters;

// 2D Char array to Rich converter.
public class Surface : IPainter
{
    List<List<Rich>> output;

    public Surface(String surfaceInput, Color surfaceColor, BGColor surfaceBG) {
        output = new List<List<Rich>>();
        string[] lines = surfaceInput.Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );
        foreach(String line in lines) {
            List<Rich> tmpLine = new List<Rich>();
            foreach(Char tmpChar in line) {
                tmpLine.Add(new Rich(tmpChar.ToString(), surfaceColor, surfaceBG));
            }
            output.Add(tmpLine);
        }
    }

    public List<List<Rich>> Paint() {
        return output;
    }
}
