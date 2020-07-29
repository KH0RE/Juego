@ModelType CrudDemoMvc.tblRegistro
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>tblRegistro</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.nombre)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.apellido)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.apellido)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.user)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.user)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.password)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
