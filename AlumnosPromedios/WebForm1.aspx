<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="AlumnosPromedios.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
  <!-- Bootstrap CSS -->
  <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"
    integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous">

    <!---<link rel="stylesheet" href="css/index.css">-->
  <title>Inicio</title>
</head>

<body>
  <form id="form1" runat="server">
    <div style="width: 95%;">
      <h1 style="padding:30px;">Registrar Empleado</h1>
      <div class="formulario" style="padding:30px;">
        <div class="form-row">
          <div class="col-md-3 mb-3">
            
            <asp:Label ID="Label1" runat="server" Text="Carnet"></asp:Label>
            <asp:TextBox ID="txtCarnet" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="col-md-3 mb-3">
            <asp:Label ID="Label2" runat="server" Text="Nota 1"></asp:Label>
            <asp:TextBox ID="txtNota1" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
  
        <div class="form-row">
          <div class="col-md-3 mb-3">
            <asp:Label ID="Label3" runat="server" Text="Nota 2"></asp:Label>
            <asp:TextBox ID="txtNota2" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="col-md-3 mb-3">
            <asp:Label ID="Label4" runat="server" Text="Nota 3"></asp:Label>
            <asp:TextBox ID="txtNota3" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
      </div>

      <div class="form-group">
        <div class="form-check">

          <asp:Button ID="btnMostar" runat="server" Text="Mostar" CssClass="btn btn-outline-primary" />

          <asp:Button ID="btnIngresar" runat="server" Text="Registrar" OnClick="btnIngresar_Click"
            CssClass="btn btn-outline-success" />

          <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"
            CssClass=" btn btn-outline-info" />

          <asp:Button ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click"
            CssClass="btn btn-outline-warning" />

          <asp:Button ID="btnConfirmar" runat="server" Text="Confirmar Actualizacion" OnClick="btnConfirmar_Click" CssClass="btn btn-outline-success" />

          <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click"
            CssClass="btn btn-outline-danger" />
        </div>
      </div>
      <br /> <br /> <br />
    </div>
    <div class="card text-center">
      <div class="card-header">
        Lista Alumnos
      </div>
      <div class="card-body text-center">
        <h5 class="card-title"></h5>
        <p class="card-text text-center" style="text-align:center;">
          <asp:GridView ID="GridView1" runat="server" CssClass="table"></asp:GridView>
        </p>
      </div>
      <div class="card-footer text-muted">
        <asp:Label ID="noti" runat="server"></asp:Label>
      </div>
    </div>

  </form>
  <!-- Optional JavaScript -->
  <!-- jQuery first, then Popper.js, then Bootstrap JS -->
  <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"
    integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous">
  </script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"
    integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous">
  </script>
  <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"
    integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous">
  </script>
</body>

</html>