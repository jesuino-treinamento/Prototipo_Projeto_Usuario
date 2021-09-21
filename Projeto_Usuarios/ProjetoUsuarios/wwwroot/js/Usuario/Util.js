//Mascara Telefone
function mask(o, f) {
    setTimeout(function () {
        var v = mphone(o.value);
        if (v != o.value) {
            o.value = v;
        }
    }, 1);
}

function mphone(v) {
    var r = v.replace(/\D/g, "");
    r = r.replace(/^0/, "");
    if (r.length > 10) {
        r = r.replace(/^(\d\d)(\d{5})(\d{4}).*/, "($1) $2-$3");
    } else if (r.length > 5) {
        r = r.replace(/^(\d\d)(\d{4})(\d{0,4}).*/, "($1) $2-$3");
    } else if (r.length > 2) {
        r = r.replace(/^(\d\d)(\d{0,5})/, "($1) $2");
    } else if (r.length > 1) {
        r = r.replace(/^(\d*)/, "($1");
    }
    return r;
}

//Valida E-mail
function validacaoEmail(field) {
    usuario = field.value.substring(0, field.value.indexOf("@"));
    dominio = field.value.substring(field.value.indexOf("@") + 1, field.value.length);

    if ((usuario.length >= 1) &&
        (dominio.length >= 3) &&
        (usuario.search("@") == -1) &&
        (dominio.search("@") == -1) &&
        (usuario.search(" ") == -1) &&
        (dominio.search(" ") == -1) &&
        (dominio.search(".") != -1) &&
        (dominio.indexOf(".") >= 1) &&
        (dominio.lastIndexOf(".") < dominio.length - 1)) {
        document.getElementById("msgemail").innerHTML = "";
    }
    else {
        document.getElementById("msgemail").innerHTML = "<font color='red'>E-mail inválido </font>";
    }
}

//Ordenar tabela

//// Material Design example
//$(document).ready(function () {
//    $('#tabela').DataTable();
//    $('#tabela_wrapper').find('label').each(function () {
//        $(this).parent().append($(this).children());
//    });
//    $('#tabela_wrapper .dataTables_filter').find('input').each(function () {
//        const $this = $(this);
//        $this.attr("placeholder", "Search");
//        $this.removeClass('form-control-sm');
//    });
//    $('#tabela_wrapper .dataTables_length').addClass('d-flex flex-row');
//    $('#tabela_wrapper .dataTables_filter').addClass('md-form');
//    $('#tabela_wrapper select').removeClass('custom-select custom-select-sm form-control form-control-sm');
//    $('#tabela_wrapper select').addClass('mdb-select');
//    $('#tabela_wrapper .mdb-select').materialSelect();
//    $('#tabela_wrapper .dataTables_filter').find('label').remove();
//});


//$(document).ready(function () {
//    $('#tabela').DataTable();
//    $('.dataTables_length').addClass('bs-select');
//});

//function sortTable(table, col, reverse) {
//    var tb = table.tBodies[0],
//        tr = Array.prototype.slice.call(tb.rows, 0),
//        i;
//    reverse = -((+reverse) || -1);
//    var str1;
//    var str2;
//    tr = tr.sort(function (a, b) {
//        if (a.cells[col].children[0] === undefined) {
//            str1 = a.cells[col].textContent.trim();
//            str2 = b.cells[col].textContent.trim();
//        } else {
//            str1 = a.cells[col].getElementsByTagName(a.cells[col].children[0].tagName)[0].value;
//            str2 = b.cells[col].getElementsByTagName(a.cells[col].children[0].tagName)[0].value;
//        }

//        if (!isNaN(str1)) {
//            if (str1.length === 1) {
//                str1 = '0' + str1;
//            }
//            if (str2.length === 1) {
//                str2 = '0' + str2;
//            }
//        }
//        return reverse * (str1.localeCompare(str2));
//    });
//    for (i = 0; i < tr.length; ++i)
//        tb.appendChild(tr[i]);
//}

//function makeSortable(table) {
//    var th = table.tHead,
//        i;
//    th && (th = th.rows[0]) && (th = th.cells);
//    if (th)
//        i = th.length;
//    else
//        return;
//    while (--i >= 0)
//        (function (i) {
//            var dir = 1;
//            th[i].addEventListener('click', function () {
//                sortTable(table, i, (dir = 1 - dir));
//            });
//        }(i));
//}

//function makeAllSortable(parent) {
//    parent = parent || document.body;
//    var t = parent.getElementsByTagName('table'),
//        i = t.length;
//    while (--i >= 0) {
//        if (t[i].attributes['data-sortable'] !== undefined) {
//            makeSortable(t[i]);
//        }
//    }
//}
//makeAllSortable();