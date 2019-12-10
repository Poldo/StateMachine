using StateMachine.States;
using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine
{
    class StateHandler
    {
        private IState state;

        public StateHandler(State state)
        {
            this.state = state;
            HandleCommand("0");
        }

        public IState State
        {
            get { return state; }
            set
            {
                state = value;
                handle();
            }
        }

        internal void HandleCommand(string command)
        {
            switch (command)
            {

                case "1": // Inserisci ticket
                    state = state.InsertTicket();
                    break;
                case "2": // Paga
                    state = state.Pay();
                    break;
                case "3": // Vai
                    state = state.Go();
                    break;
                case "0": // Vai
                    Console.WriteLine("Lista comandi:");
                    Console.WriteLine("1: Inserisci il biglietto");
                    Console.WriteLine("2: Inserisci i soldi");
                    Console.WriteLine("3: Vai");
                    Console.WriteLine("0: Aiuto"); break;
                case "43":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Comando non riconosciuto");
                    break;
            }
            handle();
        }

        private void handle()
        {
            Console.WriteLine($"{((State)state).StateName }");
        }
    }
}
