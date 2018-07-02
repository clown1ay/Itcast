<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookTypeEdit.aspx.cs" Inherits="Shop.Web.Admin.BookTypeEdit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        编号：<%=BtModel.TypeId %>
        <input type="hidden" name="tid" value="<%=BtModel.TypeId %>"/>
        <br/>
        名称：<input type="text" name="tTitle" value="<%=BtModel.TypeTitle %>"/>
        <input type="hidden" name="tpid" value="<%=BtModel.TypeParentId %>"/>
        <br/>
        <input type="submit" value="修改"/>
    </form>
</body>
</html>
