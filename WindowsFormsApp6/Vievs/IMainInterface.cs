using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6.Vievs
{
    public interface IMainInterface
    {
        EventHandler<EventArgs> SaveButton { get; set; }
        string NameText { get; set; }
        string SurnameText { get; set; }
    }
}
