@ModelType IEnumerable(Of Mvc_App_Crud.Aluno)
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
            @Html.DisplayNameFor(Function(model) model.AlunoNome)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Assunto.Assunto1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Departamento.DepartamentoNome)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AlunoNome)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Assunto.Assunto1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.Departamento.DepartamentoNome)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.AlunoId }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.AlunoId }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.AlunoId })
        </td>
    </tr>
Next

</table>
