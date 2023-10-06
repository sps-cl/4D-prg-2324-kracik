using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Event_Managment_System.Exceptions
{
    public class InvitationNotFoundException : Exception {
        public InvitationNotFoundException(string message = "Invitation not found") : base(message) {
        }
    }
}
