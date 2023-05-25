using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class KutyaFajtak
    {
        int kutyaId;
        string kutyaNev;
        string kutyaEredeti;

        public KutyaFajtak(string sor)
        {
            this.kutyaId = int.Parse(sor.Split(";")[0].Trim());
            this.kutyaNev = sor.Split(";")[1].Trim();
            this.kutyaEredeti = sor.Split(";")[2].Trim();
        }

        public int KutyaId { get => kutyaId; set => kutyaId = value; }
        public string KutyaNev { get => kutyaNev; set => kutyaNev = value; }
        public string KutyaEredeti { get => kutyaEredeti; set => kutyaEredeti = value; }
    }
}
