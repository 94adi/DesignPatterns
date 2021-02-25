using System;
using System.Collections.Generic;
using System.Text;

namespace CommandFactory.Interfaces
{
    public interface IDataSourceCommand : ICommand
    {
        public string ConnectionString { get; }
    }
}
