﻿var PermissionController = {
    actionsButtons: function (value, row, index) {
        return '<div class="btn-group btn-group-sm"> <button type="button" class="btn btn-default dropdown-toggle menuButton" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"> <span class="caret"></span> <span class="sr-only">Toggle Dropdown</span> </button> </div>';
    },
    ConfirmDelete: function (idElement) {
        var id = idElement;
        if (currentLang.includes("es")) {
            messageEmptyFields = "Todas las relaciones con Permission serán eliminadas.";
            typeOfAlert = "¿Estás seguro?";
            confirmButton = "¡Si, Eliminar!";
            cancelButton = "¡No, Cancelar!";
        }
        else {

            messageEmptyFields = "All relationships with Permission will be removed.";
            typeOfAlert = "Are you sure?";
            confirmButton = "Yes, delete it!";
            cancelButton = "No, cancel plx!";
        }
        swal({
            title: typeOfAlert,
            text: messageEmptyFields,
            type: "warning",
            showCancelButton: true,
            confirmButtonClass: "btn-danger",
            confirmButtonText: confirmButton,
            cancelButtonText: cancelButton,
            closeOnConfirm: false
        },
        function (isConfirm) {
            if (isConfirm) {
                $.post('/Permission/DeleteConfirm/' + id);
                location.reload("Index");
            }
            else {

                swal({ closeOnCancel: true });
            }

        });
        return;
    }
}

$(document).ready(function () {
    if (!String.prototype.includes) {
        String.prototype.includes = function () {
            'use strict';
            return String.prototype.indexOf.apply(this, arguments) !== -1;
        };
    }

    PermissionController.Initiate;
});