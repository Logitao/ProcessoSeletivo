<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="updateGrid" runat="server">
                <ContentTemplate>
                    <asp:GridView ID="GridFuncionarios" runat="server">
                    </asp:GridView>
                    <asp:DropDownList ID="DropDownFiliais" runat="server" OnSelectedIndexChanged="DropDownFiliais_SelectedIndexChanged" AutoPostBack="true" EnableViewState="true">
                    </asp:DropDownList>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="DropDownFiliais" EventName="SelectedIndexChanged" />
                </Triggers>
            </asp:UpdatePanel>

        </div>
    </form>
</body>
</html>
