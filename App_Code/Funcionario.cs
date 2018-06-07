using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Funcionario
/// </summary>
public class Funcionario
{

    public static DataTable RetornarPorID(int id)
    {

        return clsDados
            .Instance
            .Query(@"select i_func_id ID,
                    vc_func_nome Nome, 
                    vc_func_funcional Funcional,
                    vc_func_filial Filial
                    from TB_FUNCIONARIOS WHERE i_func_id = @id", new SqlParameter("@id", id));
    }

    public static DataTable Retornar()
    {
        return clsDados
            .Instance
            .Query(@"select i_func_id ID,
                    vc_func_nome Nome, 
                    vc_func_funcional Funcional,
                    vc_func_filial Filial
                    from TB_FUNCIONARIOS");
    }

    public static DataTable RetornarPorFilial(string filial)
    {
        return clsDados
             .Instance
             .Query(@"select i_func_id ID,
                    vc_func_nome Nome, 
                    vc_func_funcional Funcional,
                    vc_func_filial Filial
                    from TB_FUNCIONARIOS WHERE vc_func_filial = @filial", new SqlParameter("@filial", filial));
    }
    public static DataTable RetornarFiliais()
    {
        return clsDados
            .Instance
            .Query("select distinct vc_func_filial Filial from TB_FUNCIONARIOS");
    }
}