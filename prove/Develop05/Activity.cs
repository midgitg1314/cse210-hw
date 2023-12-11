abstract class Activity
{
    protected int Duration;

    public virtual void Run()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000);

        RunActivity();

        DisplayEndingMessage();
        Thread.Sleep(3000);
    }

    protected abstract void DisplayStartingMessage();
    protected abstract void RunActivity();
    protected abstract void DisplayEndingMessage();

}