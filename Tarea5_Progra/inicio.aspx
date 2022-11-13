<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="inicio.aspx.cs" Inherits="Tarea5_Progra.inicio" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 12px;
            text-align: center;
            font-size: xx-large;
        }
        .auto-style3 {
            width: 593px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">PREGUNTAS INTELIGENCIA</td>
                </tr>
                <tr>
                    <td class="auto-style3">Cedula:&nbsp;
                        <asp:TextBox ID="Tcedula" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Nombre:&nbsp;
                        <asp:TextBox ID="Tnombre" runat="server"></asp:TextBox>
                        <br />
                        <br />
                        Genero:&nbsp;
                        <asp:RadioButton ID="RM" runat="server" Text="Masculino" />
                        <asp:RadioButton ID="RF" runat="server" Text="Femenino" />
                        <br />
                        <br />
                        <asp:Button ID="Bsiguiente" runat="server" Height="60px" Text="Siguiente" Width="134px" OnClick="Bsiguiente_Click1" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
