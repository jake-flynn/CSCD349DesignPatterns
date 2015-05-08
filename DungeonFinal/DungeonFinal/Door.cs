using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonFinal
{
    public class Door
    {

        private bool _isOpen;


        public bool IsOpen()
        {
            return _isOpen;
        }

        public void Open()
        {
            _isOpen = true;
        }


        public void Shut()
        {
            _isOpen = false;
        }

        public bool CanPass()
        {
            if (_isOpen)
                return true;
            return false;
        }

    }
}
