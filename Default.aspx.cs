using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DropDownFiliais.DataSource = Funcionario.RetornarFiliais(); ;
            DropDownFiliais.DataTextField = "Filial";
            DropDownFiliais.DataValueField = "Filial";
            DropDownFiliais.DataBind();

            GridFuncionarios.DataSource = Funcionario.Retornar();
            GridFuncionarios.DataBind();
        }
    }

    protected void DropDownFiliais_SelectedIndexChanged(object sender, EventArgs e)
    {
        GridFuncionarios.DataSource = Funcionario.RetornarPorFilial((sender as DropDownList).SelectedValue.ToString());
        GridFuncionarios.DataBind();
    }
}