using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CommandManager commandManager = new CommandManager();

            Command command1 = new Command("Команда 1");
            Command command2 = new Command("Команда 2");

            commandManager.Execute(command1);
            commandManager.Execute(command2);

            commandManager.Undo(); 
            commandManager.Redo(); 
            commandManager.Undo();  
            commandManager.Undo();  
            commandManager.Undo();  
        }
    }
}
