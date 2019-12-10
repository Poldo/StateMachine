using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.States
{
    class TicketWaitingState : State
    {

        public TicketWaitingState()
        {
            StateName = "Inserisci il biglietto";
        }

        
        public override IState Go()
        {
            Console.WriteLine("Scatto la foto");
            return new TicketWaitingState();
        }

        public override IState InsertTicket()
        {
            Console.WriteLine("Biglietto inserito");
            return new MoneyWaitingState();
        }

        public override IState Pay()
        {
            return new TicketWaitingState();
        }
    }
}
