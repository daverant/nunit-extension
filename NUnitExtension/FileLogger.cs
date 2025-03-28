using NUnit.Engine;
using NUnit.Engine.Extensibility;

namespace NUnitExtension;

[Extension(EngineVersion="3.4")]
public class FileLogger : ITestEventListener
{
    public void OnTestEvent(string report)
    {
        File.AppendAllLines($"{nameof(NUnitExtension)}.{nameof(FileLogger)}.txt", [report]);
    }
}