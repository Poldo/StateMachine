using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.States
{
    class MoneyWaitingState : State
    {

        public MoneyWaitingState()
        {
            StateName = "Inserisci Soldi";
        }

        public override IState Go()
        {
            Console.WriteLine("Scatto la foto");
            return new TicketWaitingState();
        }

        public override IState InsertTicket()
        {
            return new MoneyWaitingState();
        }

        public override IState Pay()
        {
            Console.WriteLine("Soldi inseriti");
            return new OpenGateState();
        }
    }
}
