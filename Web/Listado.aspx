<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Listado.aspx.cs" Inherits="Web.Listado" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div title="Webform">
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
                <Columns>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="id" SortExpression="id">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl7" runat="server" DataField="id" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl7" runat="server" DataField="id" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="ApellidoNombre" SortExpression="ApellidoNombre">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="ApellidoNombre" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl1" runat="server" DataField="ApellidoNombre" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Dni" SortExpression="Dni">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="Dni" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl2" runat="server" DataField="Dni" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Email" SortExpression="Email">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl3" runat="server" DataField="Email" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl3" runat="server" DataField="Email" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="FechaNacimiento" SortExpression="FechaNacimiento">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl4" runat="server" DataField="FechaNacimiento" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl4" runat="server" DataField="FechaNacimiento" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="NotaPromedio" SortExpression="NotaPromedio">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl5" runat="server" DataField="NotaPromedio" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl5" runat="server" DataField="NotaPromedio" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField ConvertEmptyStringToNull="False" HeaderText="Edad" SortExpression="Edad">
                        <EditItemTemplate>
                            <asp:DynamicControl ID="DynamicControl6" runat="server" DataField="Edad" Mode="Edit" />
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:DynamicControl ID="DynamicControl6" runat="server" DataField="Edad" Mode="ReadOnly" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="RecuperarTodos" TypeName="Negocio.AlumnoLogic"></asp:ObjectDataSource>
    </form>
</body>
</html>
