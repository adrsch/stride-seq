using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Stride.Core;

namespace Stride.Engine
{
    public struct CommandInfo
    {
        public List<Type> Params;
        public List<Type> OptionalParams;
        public Func<object[], Task> Exec;
        public string Help;
    }
}
