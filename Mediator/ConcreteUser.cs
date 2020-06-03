using System;

namespace Mediator
{
    public class ConcreteUser : User
    {
        public ConcreteUser(IFacebookGroupMediator mediator, string name) : base(mediator, name)
        {
        }

        public override void Receive(string message)
        {
            Console.WriteLine(name + ": Received Message:" + message);
        }

        public override void Send(string message)
        {
            Console.WriteLine(name + ": Sending Message=" + message + "\n");
            mediator.SendMessage(message, this);
        }
    }
}