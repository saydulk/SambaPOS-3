﻿using Samba.Infrastructure.Data;

namespace Samba.Domain.Models.Automation
{
    public class AutomationCommandMap : AbstractMap
    {
        public int AutomationCommandId { get; set; }
        public bool DisplayOnTicket { get; set; }
        public bool DisplayOnPayment { get; set; }
        public bool DisplayOnOrders { get; set; }
        public int VisualBehaviour { get; set; } // 0 = Normal, 1 = Disable when ticket locked, 2 = Show when ticket locked,3=Disable when ticket active,4 = Display when ticket active
        public string EnabledStates { get; set; }
        public string VisibleStates { get; set; }
    }
}
