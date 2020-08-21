var table = null;
var arrCar = [];
var arrKonsumen = [];

$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    });

    $('#Start').on('change', function () {
        $('#endCol').show();
        $('#End').on('change', function () {
            $('#carCol').show();
            $('#CarOption').on('change', function () {
                $('#totalCol').show();
                //alert(this.value);
                var start = new Date($('#Start').val());
                var end = new Date($('#End').val());
                var diff = new Date(end - start);
                var days = diff / 1000 / 60 / 60 / 24;
                //alert(days);
                $.ajax({
                    url: "/cars/GetById/",
                    data: { id: this.value }
                }).then((result) => {
                    //debugger;
                    //alert(result.price);
                    var tot = parseInt(result.price * days);
                    //console.log(tot)
                    //alert(tot);
                    var total = $('#Total').val(tot);

                })
            });
        });
    });

    //debugger;
    table = $("#myTable").DataTable({
        "processing": true,
        "responsive": true,
        "pagination": true,
        "stateSave": true,
        "ajax": {
            url: "/user/LoadData",
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
                "data": "id_reserve",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                "render": function (data, type, row) {
                    return row.carName + '<br/><small>' + row.carMerk + '</small>'
                }
            },
            {
                "data": "start_date",
                'render': function (jsonDate) {
                    //var date = new Date(jsonDate).toDateString();
                    //return date;
                    var date = new Date(jsonDate);
                    return ("0" + date.getDate()).slice(-2) + '-' + ("0" + (date.getMonth() + 1)).slice(-2) + '-' + date.getFullYear();
                }
            },
            {
                "data": "end_date",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    return ("0" + date.getDate()).slice(-2) + '-' + ("0" + (date.getMonth() + 1)).slice(-2) + '-' + date.getFullYear();
                }
            },

            {
                "data": "total",
                'render': $.fn.dataTable.render.number(',', '.', 2, 'Rp '),
            },
            {
                "data": "tgl_bayar",
                'render': function (jsonDate) {
                    var date = new Date(jsonDate);
                    var result = ("0" + date.getDate()).slice(-2) + '-' + ("0" + (date.getMonth() + 1)).slice(-2) + '-' + date.getFullYear();
                    if (result != "01-01-2000") {
                        return ("0" + date.getDate()).slice(-2) + '-' + ("0" + (date.getMonth() + 1)).slice(-2) + '-' + date.getFullYear();
                    } else {
                        return "Null";
                    }
                }
            },
            { "data": "status" },
        ]
    });
    ClearScreen();
});

function ClearScreen() {
    $('#Id').val('');
    $('#Start').val('');
    $('#End').val('');
    $('#Total').val('');
    $('#Bayar').val('');
    $('#endCol').hide();
    $('#carCol').hide();
    $('#totalCol').hide();
    $('#bayarCol').hide();
    $('#statusCol').hide();
    $('#update').hide();
    $('#add').show();
}

function LoadCar(element) {
    //debugger;
    if (arrCar.length === 0) {
        $.ajax({
            type: "Get",
            url: "/cars/loadcar",
            success: function (data) {
                arrCar = data;
                renderCar(element);
            }
        });
    }
    else {
        renderCar(element);
    }
}

function renderCar(element) {
    var $option = $(element);
    $option.empty();
    $option.append($('<option/>').val('0').text('Select Car').hide());
    $.each(arrCar, function (i, val) {
        $option.append($('<option/>').val(val.id_car).text(val.nm_car))
    });
}

LoadCar($('#CarOption'))


function Save(id) {
    debugger;
    var Reserve = new Object();
    Reserve.start_date = $('#Start').val();
    Reserve.end_date = $('#End').val();
    Reserve.status = "Belum";
    Reserve.total = $('#Total').val();
    Reserve.tgl_bayar = "2000-01-01";
    Reserve.carID = $('#CarOption').val();
    Reserve.accountID = id;
    $.ajax({
        type: 'POST',
        url: "/reserves/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Reserve
    }).then((result) => {
        debugger;
        if (result.statusCode == 200) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Data inserted Successfully',
                showConfirmButton: false,
                timer: 1500,
            })
            table.ajax.reload(null, false);
        } else {
            Swal.fire('Error', 'Failed to Input', 'error');
            ClearScreen();
        }
    })
}