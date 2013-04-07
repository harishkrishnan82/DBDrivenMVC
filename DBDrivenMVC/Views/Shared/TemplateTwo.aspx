<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<DBDrivenMVC.Models.IPhoneClass>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>TemplateTwo</title>
</head>
<body>
    <div>
        <table>
         
        <tr>
            <td>
                <%= this.Model.Heading %>
            </td>
            <td>
                <%= this.Model.Title %>
            </td>
           
            
        </tr>
            <tr>

                <td>

                    <% Html.RenderPartial("Partial_TemplateInfo",this.Model.TemplateInfos); %>

                </td>

            </tr>
    
            </table>
    </div>
</body>
</html>
