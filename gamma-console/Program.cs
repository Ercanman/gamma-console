using gamma_console;
using gamma_console.Models;
using gamma_console.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var inputManager = new InputManager();
        inputManager.GetInput();
    }
}