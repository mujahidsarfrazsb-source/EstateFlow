using System;
using System.Windows.Forms;

namespace EstateFlow;

internal static class Program
{
    [STAThread]
    private static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new Forms.LoginForm());
    }
}
