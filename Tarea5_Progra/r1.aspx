<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="r1.aspx.cs" Inherits="Tarea5_Progra.r1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 356px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2">Pregunta 1<br />
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
                        <asp:Button ID="Bavanzar" runat="server" Height="54px" OnClick="Bavanzar_Click" Text="Continuar" Width="128px" />
                    </td>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="406px" ImageUrl="~/Images/Pregunta1.png" Width="506px" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
