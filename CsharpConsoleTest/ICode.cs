using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpConsoleTest
{
    public interface ICode
    {
        string GenerateCode(bool extraversion, bool sensing, bool thinking, bool judging);
    }
}
