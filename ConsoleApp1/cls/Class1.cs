using ConsoleApp1.utils;

namespace ConsoleApp1.cls;

public class Class1
{
    public int A;

    public void ShowMe()
    {
        Logger.Log($"Class1.A={A}");
    }
}