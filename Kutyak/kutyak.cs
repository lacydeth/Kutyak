using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    internal class kutyak
    {
        int vizsgAzon;
        int fajtaAzon;
        int nevAzon;
        int kutyaKor;
        DateTime utolsoEll;

        public kutyak(string sor)
        {
            this.vizsgAzon = int.Parse(sor.Split(";")[0].Trim());
            this.fajtaAzon = int.Parse(sor.Split(";")[1].Trim());
            this.nevAzon = int.Parse(sor.Split(";")[2].Trim());
            this.kutyaKor = int.Parse(sor.Split(";")[3].Trim());
            this.utolsoEll = DateTime.Parse(sor.Split(";")[4]);
        }

        public int VizsgAzon { get => vizsgAzon;  }
        public int FajtaAzon { get => fajtaAzon;  }
        public int NevAzon { get => nevAzon;  }
        public int KutyaKor { get => kutyaKor;  }
        public DateTime UtolsoEll { get => utolsoEll;  }
    }
}
