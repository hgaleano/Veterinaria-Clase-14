@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Plantillas/Dashboard.vbhtml"
End Code

<h2>Matenimiento de Razas</h2>
<button onclick="abrirModal()" type="button" class="btn btn-success" data-bs-toggle="modal" data-bs-target="#exampleModal">
    Nueva Raza
</button>
<div id="DivRaza">

</div>

<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">

            <input type="hidden" class="form-control limpiar" id="txtRazaID">

            <div class="modal-header">
                <h5 class="modal-title" id="exampleModalLabel">Raza</h5>
                <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
            </div>
            <div class="modal-body">
                <div class="mb-3">
                    <label for="descripcion" class="form-label">Descripción</label>
                    <input type="text" class="form-control limpiar" id="txtDescripcion">
                </div>

                <div class="mb-3">
                    <label for="esta_activo" class="form-label">Esta Activo?</label>
                    <select class="form-select limpiar" id="cboEstaActivo">
                        <option value="S">Si</option>
                        <option value="N">No</option>
                    </select>
                </div>

            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-secondary" id="btnCerrar" data-bs-dismiss="modal">Cerrar</button>
                <button type="button" class="btn btn-primary" onclick="Guardar()">Guardar</button>
            </div>
        </div>
    </div>
</div>

<!-- Modal Eliminar -->
<div class="modal fade" id="confirm-delete" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog">
        <div class="modal-content">

            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title" id="myModalLabel">Confirm Delete</h4>
            </div>

            <div class="modal-body">
                <p>You are about to delete one track, this procedure is irreversible.</p>
                <p>Do you want to proceed?</p>
                <p class="debug-url"></p>
            </div>

            <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">Cancel</button>
                <a class="btn btn-danger btn-ok">Delete</a>
            </div>
        </div>
    </div>
</div>

<script src="~/scripts/js/jquery-3.6.0.min.js"></script>
<script src="~/scripts/js/raza.js"></script>