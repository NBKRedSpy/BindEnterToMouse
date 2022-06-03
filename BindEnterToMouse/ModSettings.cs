using InControl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BindEnterToMouse
{
    public class ModSettings
    {

        /// <summary>
        /// Backwards compatibility
        /// </summary>
        public Mouse MouseBind
        {
            set
            {
                EnterMouseBind = value;
            }
        }

        public Mouse EnterMouseBind { get; set; } = Mouse.Button4;

        public Mouse EscapeMouseBind { get; set; } = Mouse.Button5;
    }
}
