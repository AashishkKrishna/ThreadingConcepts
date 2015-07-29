using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingNewTaskWithReturnType
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(
                () =>
                {
                    return 10;
                }
                );
            // no need to specify t.wait(),if return type is there then wait will be taken care internally
            Console.WriteLine("{0}",t.Result);
        }
    }
}
