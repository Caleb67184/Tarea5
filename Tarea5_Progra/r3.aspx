<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="r3.aspx.cs" Inherits="Tarea5_Progra.r3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 367px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Pregunta 3<br />
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem>a</asp:ListItem>
                <asp:ListItem>b</asp:ListItem>
                <asp:ListItem>c</asp:ListItem>
                <asp:ListItem>d</asp:ListItem>
                <asp:ListItem>e</asp:ListItem>
                <asp:ListItem>f</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Button ID="Bsalvar" runat="server" Height="54px" Text="Guardar" Width="128px" OnClick="Bsalvar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="Bnuevo" runat="server" Height="55px" Text="Nueva encuesta" Width="131px" OnClick="Bnuevo_Click" />
                        <br />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <br />
                        <asp:GridView ID="GridView1" runat="server">
                        </asp:GridView>
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="406px" ImageUrl="~/Images/Pregunta3.png" Width="506px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
