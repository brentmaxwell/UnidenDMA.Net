using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnidenDMA
{
    public abstract class Command : ICommand
    {
        private string _cmd;
        public abstract string CommandText { get; }

        public string Execute()
        {
            return this.CommandText;
        }
    }
}
