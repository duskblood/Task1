using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    
    public class CommandManager
    {
        private Stack<Command> executedCommands = new Stack<Command>();
        private Stack<Command> undoneCommands = new Stack<Command>();

        public void Execute(Command command)
        {
            command.Execute();
            executedCommands.Push(command);
            undoneCommands.Clear(); 
        }

        public void Undo()
        {
            if (executedCommands.Count > 0)
            {
                Command command = executedCommands.Pop();
                command.Undo();
                undoneCommands.Push(command);
            }
            else
            {
                Console.WriteLine("Никаких команд для отмены.");
            }
        }

        public void Redo()
        {
            if (undoneCommands.Count > 0)
            {
                Command command = undoneCommands.Pop();
                command.Execute();
                executedCommands.Push(command);
            }
            else
            {
                Console.WriteLine("Никаких команд для повтора.");
            }
        }

    }
}
