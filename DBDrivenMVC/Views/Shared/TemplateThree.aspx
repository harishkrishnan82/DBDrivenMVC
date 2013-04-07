<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<DBDrivenMVC.Models.IPhoneClass>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    
    <title><%= this.Model.Title %></title>
</head>
<body>
    <div>
        <table style="width:100%;height:100%;background-color:aliceblue" border="1" >

            <tr>

               <td style="width:30%;height:80%; background-color:lightgoldenrodyellow;">

                   
               </td>
                <td style="width:70%;height:80%;">
                    <%=  this.Model.Heading %>
    </div>
</body>
</html>
