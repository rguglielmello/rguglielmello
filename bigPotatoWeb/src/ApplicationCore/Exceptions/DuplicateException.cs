using System;

namespace Microsoft.bigPotatoWeb.ApplicationCore.Exceptions;

public class DuplicateException : Exception
{
    public DuplicateException(string message) : base(message)
    {

    }

}
