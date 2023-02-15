using Automovel.Domain;
using DAO;
using DTIDAO.Core;
using System;
using System.Collections.Generic;
using UtilDLL;

namespace Automovel.DAO
{
    public class AutomovelDAO : IDAOBase<Automoveis, AutomovelDTO>
    {
        public string delete(Automoveis dominio)
        {
            var sqlString = $"DELETE FROM AUTOMOVEIS WHERE ID_AUTOMOVEL = {dominio.idAutomovel}";
            return BDOracle.executaComandoCommit(sqlString);
        }

        public Automoveis Get(int id)
        {
            var sqlString =
            "SELECT ID_AUTOMOVEL,\n" +
            "       MODELO_AUTOMOVEL,\n" +
            "       ANO_AUTOMOVEL\n" +
            "FROM AUTOMOVEIS \n" +
            $"WHERE AUTOMOVEIS.ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                var registro = dt.Rows[0];
                var automovel = new Automoveis();

                automovel.idAutomovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                automovel.modeloAutomovel = registro["MODELO_AUTOMOVEL"].ToString();
                automovel.anoAutomovel = Convert.ToInt32(registro["ANO_AUTOMOVEL"]);

                return automovel;
            }
            catch
            {
                return null;
            }
        }

        public AutomovelDTO GetDTO(int id)
        {
            var sqlString =
                        "SELECT ID_AUTOMOVEL,\n" +
                        "       MODELO_AUTOMOVEL,\n" +
                        "       ANO_AUTOMOVEL\n" +
                        "FROM AUTOMOVEIS \n" +
                       $"WHERE AUTOMOVEIS.ID_AUTOMOVEL = {id}";

            var dt = BDOracle.getDataTable(sqlString);

            try
            {
                var registro = dt.Rows[0];
                var automovel = new AutomovelDTO();

                automovel.id_automovel = Convert.ToInt32(registro["ID_AUTOMOVEL"]);
                automovel.modelo_automovel = registro["MODELO_AUTOMOVEL"].ToString();
                automovel.ano_automovel = Convert.ToInt32(registro["ANO_AUTOMOVEL"]);

                return automovel;
            }
            catch
            {
                return null;
            }
        }
    

        public string insert(Automoveis dominio)
        {
            var camposInsert = new ListaCampos();   //MODELO = NOME - ANIMAL NO CASO

            camposInsert.Add("MODELO_AUTOMOVEL", Util.strNULL(dominio.modeloAutomovel));
            camposInsert.Add("ANO_AUTOMOVEL", Util.intNULL(dominio.anoAutomovel));

            var nomeTabela = "AUTOMOVEIS";
            var sqlString = Util.montaSQLInsert(nomeTabela, camposInsert);

            var id = 0;
            var retorno = BDOracle.executaComandoCommitHandle(sqlString, "ID_AUTOMOVEL", ref id);
            dominio.idAutomovel = id;
            return retorno;

        }

        public List<AutomovelDTO> Listar(NTIFiltro filtro)
        {
            var sqlString =
            "SELECT ID_AUTOMOVEL,\n" +
            "       MODELO_AUTOMOVEL,\n" +
            "       ANO_AUTOMOVEL\n" +
            "FROM AUTOMOVEIS \n" +
            $"WHERE 1=1";

            if (filtro != null)
                sqlString += filtro.getExpressoes();

            var dt = BDOracle.getDataTable(sqlString);

            var lista = dt.DataTableToList<AutomovelDTO>();
            return lista;
        }

        public string update(Automoveis dominio)
        {
            var camposUpdate = new ListaCampos();

            camposUpdate.Add("MODELO_AUTOMOVEL", Util.strNULL(dominio.modeloAutomovel));
            camposUpdate.Add("ANO_AUTOMOVEL", Util.intNULL(dominio.anoAutomovel));

            var nomeTabela = "AUTOMOVEIS";
            var sqlString = Util.montaSQLUpdate(nomeTabela, camposUpdate);
            sqlString += $"ID_AUTOMOVEL = {dominio.idAutomovel}";

            return BDOracle.executaComandoCommit(sqlString);
        }
    }
}
