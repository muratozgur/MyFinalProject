using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Starting point for the fundemental voids
    public interface IResult
    {
        bool Success { get; }
        String Message { get; }
    }
}
