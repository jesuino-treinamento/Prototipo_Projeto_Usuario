(function () {
    'use strict';
    
    $(document).ready(function () {
            $('a#btn-salvarregistro').click(function () {
                var value = 0;
                
                $('#frm-registro').find("input:text, input:password").each(function (i) {
                    console.log($(this).val());
                    var resultado = $(this).val();
                    if (resultado != "") { value++ };
                    
                });

                if (value == 5)
                {
                    var href = $(this).attr('href');
                    var data = $('#frm-registro').serialize();
                    $.post(href, data, function (result)
                    {
                        console.log("success");
                        if (result.sucesso)
                            bootbox.alert('Registro salvo com sucesso!', function () {
                                document.location.reload(true);
                            });
                        else
                            bootbox.alert('Não foi possível salvar o registro.');
                    }).fail(function (e) { bootbox.alert(e); });

                    return false;
                }
                else {
                    bootbox.alert('Todos os campos são obrigatórios.');
                    return false;
                }
                });
        });    
})();