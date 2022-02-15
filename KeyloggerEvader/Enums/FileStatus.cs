namespace KeyloggerEvader.Enums
{
    /// <summary>
    /// Represents the file status that is running in the sandbox.
    /// Ready: Means that the file is ready to be executed into the sandbox.
    /// Running: Means that the file is running inside the sandbox.
    /// Error: Means that the application encountered an error when running inside the sandbox.
    /// Finished: Means that the application finished successfully from the sandbox.
    /// </summary>
    public enum FileStatus
    {
        Ready = 0,
        Running = 1,
        Error = 2,
        Finished = 3
    }
}