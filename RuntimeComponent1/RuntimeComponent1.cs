// ExampleBackgroundTask.cs
using Windows.ApplicationModel.Background;

namespace Tasks
{
    public sealed class RuntimeComponent1 : IBackgroundTask
    {
        public void Run(IBackgroundTaskInstance taskInstance)
        {
            System.Console.WriteLine("background task event received");
        }
    }
}