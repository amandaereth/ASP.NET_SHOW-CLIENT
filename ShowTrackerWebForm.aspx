<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShowTrackerWebForm.aspx.cs" Inherits="ShowTrackerWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownListArtist" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListArtist_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridViewArtist" runat="server"></asp:GridView>
        

        </div>
         
        <br/>
        <br/>

        <div>
        <asp:DropDownList ID="DropDownListVenue" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownListVenue_SelectedIndexChanged"></asp:DropDownList>
        <asp:GridView ID="GridViewVenue" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
