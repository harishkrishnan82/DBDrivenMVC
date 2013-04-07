<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<DBDrivenMVC.Models.AspNetOneClass>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <link href="../../Content/Site.css" rel="stylesheet" />
    <meta name="viewport" content="width=device-width" />
    <title><%= this.Model.PageTitle %></title>
</head>
<body>
   <header id="master-header" class="clearfix" role="banner">

		<hgroup>
			<h1 id="site-title"><%= this.Model.MainHeading %></h1>
			<h2 id="site-description"><%= this.Model.Heading1 %></h2>
		</hgroup>

	</header>

    <div id="main" class="row clearfix">

	<!-- Main navigation -->
	<nav class="main-navigation clearfix span12" role="navigation">
		<h3 class="assistive-text">Main menu</h3>
		<ul>
			<li class="current"><a href="#"><%= this.Model.Menu1 %></a></li>
			<li>
				<a href="#"><%= this.Model.Menu2 %></a>
				<ul class="sub-menu">
					<li><a href="#"><%= this.Model.SubMenu1 %></a></li>
					<li><a href="#"><%= this.Model.SubMenu2 %></a></li>
				</ul>
			</li>
			<li><a href="#"><%= this.Model.Menu3 %></a></li>
		</ul>
	</nav> <!-- #main-navigation -->

   <div id="content" role="main" class="span7">

	<article class="post hentry">

		<header class="entry-header">
			<h1 class="entry-title">
				<a href="#" title="<%=this.Model.PostHeading %>" rel="bookmark"><%=this.Model.PostHeading %></a>
			</h1>

			<a href="#" title="Post Heading"><img src="../../Content/images/200x200.gif" alt="Post thumbnail" class="thumbnail" /></a>
		</header>

		<div class="entry-content">
			<p>
				<%=this.Model.PostContent %>
			</p>

			<p><a href="#" class="more-link">Continue reading <span class="meta-nav">&rarr;</span></a></p>
		</div>

		

	</article>

       <article class="post hentry">

		<header class="entry-header">
			<h1 class="entry-title">
				<a href="#" title="<%=this.Model.PostHeading1 %>" rel="bookmark"><%=this.Model.PostHeading1 %></a>
			</h1>

			<a href="#" title="Post Heading"><img src="../../Content/images/200x200.gif" alt="Post thumbnail" class="thumbnail" /></a>
		</header>

		<div class="entry-content">
			<p>
				<%=this.Model.PostContent1 %>
			</p>

			<p><a href="#" class="more-link">Continue reading <span class="meta-nav">&rarr;</span></a></p>
		</div>

		

	</article>

	
</div> <!-- #content -->
        </div> <!-- #main -->

    <footer id="footer" role="contentinfo">
		
		<p>
			Copyright &copy; 2012 <a href="#"><%=this.Model.SiteFooter %><a>
			<span class="sep">|</span>
			Design by <a href="#"><%=this.Model.SiteName %></a>
		</p>
	</footer> <!-- #footer -->

</body>
</html>
