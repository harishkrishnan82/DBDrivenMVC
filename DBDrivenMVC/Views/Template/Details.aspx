<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<DBDrivenMVC.Models.TempMapping>>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Details</title>
</head>
<body>
    <p>
        <%: Html.ActionLink("Create New", "Create") %>
    </p>
    <table>
        <tr>
            <th>
                <%: Html.DisplayNameFor(model => model.TempID) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.Key) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.Value) %>
            </th>
            <th>
                <%: Html.DisplayNameFor(model => model.RouteID) %>
            </th>
            <th></th>
        </tr>
    
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.DisplayFor(modelItem => item.TempID) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Key) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.Value) %>
            </td>
            <td>
                <%: Html.DisplayFor(modelItem => item.RouteID) %>
            </td>
            
        </tr>
    <% } %>
    
    </table>
</body>
</html>
