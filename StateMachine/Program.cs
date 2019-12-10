using StateMachine.States;
using System;

namespace StateMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            StateHandler handler = new StateHandler(new TicketWaitingState());
            while (true)
            {
                string Command = Console.ReadLine();
                handler.HandleCommand(Command);
            }
        }
    }
}
