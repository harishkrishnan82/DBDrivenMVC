<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>DisplayRoutes</title>
</head>
<body>
    <div>
<h1>Current Routes</h1>
	<% 
	foreach (System.Web.Routing.Route route in (System.Web.Routing.RouteCollection)ViewData["routes"])
	{
		Response.Write(string.Format("<h3>Url Pattern: {0}</h3>", route.Url));
		
		foreach (KeyValuePair<string, object> kvp in route.Defaults)
		{
			string constraint = route.Constraints.ContainsKey(kvp.Key) ? route.Constraints[kvp.Key].ToString() : string.Empty;
			Response.Write(string.Format("Default: <b>{0}</b>, Value: <b>{1}</b>, Constraint: <b>{2}</b><br />", kvp.Key, kvp.Value, constraint));
		}
	} 
	%>
    </div>
</body>
</html>
