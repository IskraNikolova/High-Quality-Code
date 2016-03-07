namespace Bridge.AppendersModels
{
    using System.IO;

    public class FileAppender : Appender
    {
        public override void Append(string message)
        {
            using (var sw = new StreamWriter("file.txt"))
            {
                sw.WriteLine(this.Formatter.Format(message));
            }
        }
    }
}
