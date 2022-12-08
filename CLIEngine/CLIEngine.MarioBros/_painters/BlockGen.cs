namespace CLIEngine.MarioBros._painters;

// Generates a block with char x and size (x, y)
public class BlockGen : IPainter
{
    Rich blockChar;
    (int, int) size;

    public BlockGen(Rich blockCharSrc, (int, int) sizeSrc) {
        blockChar = blockCharSrc;
        size = sizeSrc;
    }

    public List<List<Rich>> Paint() {
        List<List<Rich>> output = new List<List<Rich>>();
        List<Rich> blockLine = Enumerable.Repeat(blockChar, size.Item1).ToList();
        output.AddRange(Enumerable.Repeat(blockLine, size.Item2));
        return output;
    }
}
