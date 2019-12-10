using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.States
{
    class OpenGateState : State
    {

        public OpenGateState()
        {
            StateName = "Apertura sbarra";
        }
        public override IState Go()
        {
            Console.WriteLine("Buon viaggio");
            return new TicketWaitingState();
        }

        public override IState InsertTicket()
        {
            return new OpenGateState();
        }

        public override IState Pay()
        {
            return new OpenGateState();
        }
    }
}
