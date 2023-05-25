using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class KutyaNevek
    {
        int kutyaId;
        string kutyaNev;

        public KutyaNevek(string sor)
        {
            this.kutyaId = int.Parse(sor.Split(";")[0].Trim());
            this.kutyaNev = sor.Split(";")[1].Trim();
        }

        public int KutyaId { get => kutyaId;  }
        public string KutyaNev { get => kutyaNev;  }
    }
}
