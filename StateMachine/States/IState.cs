using System;
using System.Collections.Generic;
using System.Text;

namespace StateMachine.States
{
    interface IState
    {
        IState Go();
        IState Pay();
        IState InsertTicket();
    }

    abstract class State : IState
    {
        public string StateName { get; set; } = "State";
        public abstract IState Go();
        public abstract IState InsertTicket();
        public abstract IState Pay();
    }
}
