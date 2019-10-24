$(document).ready(function () {
    $('#ClinicaNew').bootstrapValidator({
        feedbackIcons: {
            valid: 'glyphicon glyphicon-ok',
            invalid: 'glyphicon glyphicon-remove',
            validating: 'glyphicon glyphicon-refresh'
        },
        fields: {
            clinica: {
                validators: {
                    notEmpty: {
                        message: 'La clinica es requerida'
                    }
                }
            },
            descripcion: {
                validators: {
                    notEmpty: {
                        message: 'La descripcion es requerida'
                    }
                }
            }
        }
    });
});