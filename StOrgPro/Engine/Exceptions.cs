using System;
using System.Collections.Generic;
using System.Text;

namespace Engine
{
    public class FailedLogin : Exception { }

    public class NoDBConnection : Exception { }

    public class FailedToRemove : Exception { }

    public class WrongUserType : Exception { }
}
