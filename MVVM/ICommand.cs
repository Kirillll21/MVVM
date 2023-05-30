using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM
{
    public interface ICommand
    {
        event EventHandler CanExecuteChanged;
        void Execute(object parametr);
        bool CanExecute(object parametr);
    }
}
