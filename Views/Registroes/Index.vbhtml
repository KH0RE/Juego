@ModelType IEnumerable(Of CrudDemoMvc.tblRegistro)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.nombre)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.apellido)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.user)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.nombre)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.apellido)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.user)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.password)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.id }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.id }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.id })
        </td>
    </tr>
Next

</table>
