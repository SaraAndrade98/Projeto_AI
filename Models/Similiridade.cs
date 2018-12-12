using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_AI.Models
{
    public class Similiridade
    {
        public double SimiliridadeAno(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            if(disp.Ano == dispBD.Ano)
                return 0.5;
            if (disp.Ano < dispBD.Ano)
            {
                if (((disp.Ano - 1) >= dispBD.Ano))
                    return 0.6;

                if (((disp.Ano - 2) <= dispBD.Ano))
                    return 0.7;

                if (((disp.Ano - 3) <= dispBD.Ano))
                    return 0.8;

                if (((disp.Ano - 4) <= dispBD.Ano))
                    return 0.9;
                else
                    return 1;

            }
            if (disp.Ano > dispBD.Ano) { 
                if (((disp.Ano + 1) >= dispBD.Ano) && ((disp.Ano + 2) <= DateTime.Now.Year))
                    return 0.4;

                if (((disp.Ano + 2) >= dispBD.Ano) && ((disp.Ano + 2) <= DateTime.Now.Year))
                    return 0.3;

                if (((disp.Ano + 3) >= dispBD.Ano) && ((disp.Ano + 2) <= DateTime.Now.Year))
                    return 0.2;
                if (((disp.Ano + 4) >= dispBD.Ano) && ((disp.Ano + 2) <= DateTime.Now.Year))
                    return 0.1;
                else
                    return 0;

            }

            return 0;
        }

        public double SimiliridadeMarca(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
          
            return 0;
        }

        public double SimiliridadeNome(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            return 0;
        }

        public double SimiliridadeEstado(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            return 0;
        }

        public double SimiliridadeIncidentesAquaticos(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            return 0;
        }

        public double SimiliridadeAcessorios(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            return 0;
        }

        public double SimiliridadePreco(DispositivoEletronico disp, DispositivoEletronico dispBD)
        {
            return 0;
        }
    }
}
