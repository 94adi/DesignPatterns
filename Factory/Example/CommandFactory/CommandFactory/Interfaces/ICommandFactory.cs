using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Interfaces
{
    public interface ICommandFactory
    {
        ICommand Create();
    }
}
