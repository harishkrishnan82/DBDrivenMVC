<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<DBDrivenMVC.Models.TemplateInfo>" %>

<fieldset>
    <legend>Partial View Rendering for : <b><%= this.Model.TempName %></b></legend>

     <div class="display-label">
        <%: Html.DisplayNameFor(model => model.TempID) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TempID) %>
        <br />

    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.TempName) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TempName) %>
    </div>
        <br />
    <div class="display-label">
        <%: Html.DisplayNameFor(model => model.TempPath) %>
    </div>
    <div class="display-field">
        <%: Html.DisplayFor(model => model.TempPath) %>
    </div>
</fieldset>
<p>

</p>
