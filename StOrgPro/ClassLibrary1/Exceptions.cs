using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class FailedLogin : Exception { }

    public class NoDBConnection : Exception { }

    public class FailedToRemove : Exception { }

    public class WrongUserType : Exception { }
}
