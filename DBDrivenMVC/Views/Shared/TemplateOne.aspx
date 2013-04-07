<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<DBDrivenMVC.Models.TempMapping>>" %>


<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>TemplateOne</title>
</head>
<body>
    <div>
        <table>
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
        
    </div>
</body>
</html>
