abstract class Command
{
    public abstract string Execute(ref TerminalManager tm, params string[] options);
}