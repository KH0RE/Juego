Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports CrudDemoMvc

Namespace Controllers
    Public Class RegistroesController
        Inherits System.Web.Mvc.Controller

        Private db As New ECOEntities

        ' GET: Registroes
        Async Function Index() As Task(Of ActionResult)
            Return View(Await db.tblRegistro.ToListAsync())
        End Function

        ' GET: Registroes/Details/5
        Async Function Details(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblRegistro As tblRegistro = Await db.tblRegistro.FindAsync(id)
            If IsNothing(tblRegistro) Then
                Return HttpNotFound()
            End If
            Return View(tblRegistro)
        End Function

        ' GET: Registroes/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Registroes/Create
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Create(<Bind(Include:="id,nombre,apellido,user,password")> ByVal tblRegistro As tblRegistro) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.tblRegistro.Add(tblRegistro)
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tblRegistro)
        End Function

        ' GET: Registroes/Edit/5
        Async Function Edit(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblRegistro As tblRegistro = Await db.tblRegistro.FindAsync(id)
            If IsNothing(tblRegistro) Then
                Return HttpNotFound()
            End If
            Return View(tblRegistro)
        End Function

        ' POST: Registroes/Edit/5
        'Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        'más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Async Function Edit(<Bind(Include:="id,nombre,apellido,user,password")> ByVal tblRegistro As tblRegistro) As Task(Of ActionResult)
            If ModelState.IsValid Then
                db.Entry(tblRegistro).State = EntityState.Modified
                Await db.SaveChangesAsync()
                Return RedirectToAction("Index")
            End If
            Return View(tblRegistro)
        End Function

        ' GET: Registroes/Delete/5
        Async Function Delete(ByVal id As Integer?) As Task(Of ActionResult)
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim tblRegistro As tblRegistro = Await db.tblRegistro.FindAsync(id)
            If IsNothing(tblRegistro) Then
                Return HttpNotFound()
            End If
            Return View(tblRegistro)
        End Function

        ' POST: Registroes/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Async Function DeleteConfirmed(ByVal id As Integer) As Task(Of ActionResult)
            Dim tblRegistro As tblRegistro = Await db.tblRegistro.FindAsync(id)
            db.tblRegistro.Remove(tblRegistro)
            Await db.SaveChangesAsync()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
