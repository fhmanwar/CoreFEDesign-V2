var table = null;
<<<<<<< HEAD
=======
var arrMerk = [];
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6

$(document).ready(function () {
    $(function () {
        $('[data-toggle="tooltip"]').tooltip()
    })

    //debugger;
    table = $("#myTable").DataTable({
        "processing": true,
        "responsive": true,
        "pagination": true,
        "stateSave": true,
        "ajax": {
<<<<<<< HEAD
            url: "/accounts/loadAccount",
=======
            url: "/konsumens/LoadKonsumen",
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
<<<<<<< HEAD
                "data": "id_acc",
=======
                "data": "id",
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
<<<<<<< HEAD
            {
                "render": function (data, type, row) {
                    return row.name + '<br/><small>' + row.uname + '</small>'
                }
            },
            { "data": "mail" },
            { "data": "access" },
=======
            { "data": "nama" },
            { "data": "alamat" },
            { "data": "tlp" },
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
            {
                "sortable": false,
                "render": function (data, type, row) {
                    //console.log(row);
                    $('[data-toggle="tooltip"]').tooltip();
<<<<<<< HEAD
                    return '<button class="btn btn-link btn-md btn-warning " data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return GetById(' + row.id_acc + ')" ><i class="fa fa-lg fa-edit"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-link btn-md btn-danger" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Delete(' + row.id_acc + ')" ><i class="fa fa-lg fa-times"></i></button>'
=======
                    return '<button class="btn btn-link btn-md btn-warning " data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return GetById(' + row.id_konsumen + ')" ><i class="fa fa-lg fa-edit"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-link btn-md btn-danger" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Delete(' + row.id_konsumen + ')" ><i class="fa fa-lg fa-times"></i></button>'
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
                }
            }
        ]
    });
});

function ClearScreen() {
    $('#Id').val('');
    $('#Name').val('');
<<<<<<< HEAD
    $('#Uname').val('');
    $('#Email').val('');
    $('#Pass').val('');
    $('#Addr').val('');
    $('#Phone').val('');
    $('#Access').val('');
=======
    $('#Addrs').val('');
    $('#Phone').val('');
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
    $('#update').hide();
    $('#add').show();
}

function GetById(id) {
    //debugger;
    $.ajax({
<<<<<<< HEAD
        url: "/accounts/GetById/",
        data: { id: id }
    }).then((result) => {
        //debugger;
        $('#Id').val(result.id_acc);
        $('#Name').val(result.name);
        $('#Uname').val(result.uname);
        $('#Email').val(result.mail);
        $('#Pass').val('');
        $('#Access').val(result.access);
        $('#Addr').val(result.addr);
        $('#Phone').val(result.phone);
=======
        url: "/konsumens/GetById/",
        data: { id: id }
    }).then((result) => {
        //debugger;
        $('#Id').val(result.id_konsumen);
        $('#Name').val(result.nama);
        $('#Addrs').val(result.alamat);
        $('#Phone').val(result.tlp);
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
        $('#add').hide();
        $('#update').show();
        $('#myModal').modal('show');
    })
}

function Save() {
    //debugger;
<<<<<<< HEAD
    var account = new Object();
    account.name = $('#Name').val();
    account.uname = $('#Uname').val();
    account.mail = $('#Email').val();
    account.pass = $('#Pass').val();
    account.access = $('#Access').val();
    account.addr = $('#Addr').val();
    account.phone = $('#Phone').val();
    $.ajax({
        type: 'POST',
        url: "/accounts/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: account
=======
    var Konsumen = new Object();
    Konsumen.nama = $('#Name').val();
    Konsumen.alamat = $('#Addrs').val();
    Konsumen.tlp = $('#Phone').val();
    $.ajax({
        type: 'POST',
        url: "/konsumens/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Konsumen
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
    }).then((result) => {
        //debugger;
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

function Update() {
<<<<<<< HEAD
    //debugger;
    var account = new Object();
    account.id_acc = $('#Id').val();
    account.name = $('#Name').val();
    account.uname = $('#Uname').val();
    account.mail = $('#Email').val();
    if ($('#Pass').val() != null) {
        account.pass = $('#Pass').val();
    }
    account.access = $('#Access').val();
    account.addr = $('#Addr').val();
    account.phone = $('#Phone').val();
    $.ajax({
        type: 'POST',
        url: "/accounts/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: account
=======
    var Konsumen = new Object();
    Konsumen.id_konsumen = $('#Id').val();
    Konsumen.nama = $('#Name').val();
    Konsumen.alamat = $('#Addrs').val();
    Konsumen.tlp = $('#Phone').val();
    $.ajax({
        type: 'POST',
        url: "/konsumens/InsertOrUpdate/",
        cache: false,
        dataType: "JSON",
        data: Konsumen
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
    }).then((result) => {
        //debugger;
        if (result.statusCode == 200) {
            Swal.fire({
                position: 'center',
                icon: 'success',
                title: 'Updated Successfully',
                showConfirmButton: false,
                timer: 1500,
            });
            table.ajax.reload(null, false);
<<<<<<< HEAD
        } else {
=======
        } else {s
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
            Swal.fire('Error', 'Failed to Input', 'error');
            ClearScreen();
        }
    })
}

function Delete(id) {
    Swal.fire({
        title: 'Are you sure?',
        text: "You won't be able to revert this!",
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'Yes, delete it!',
    }).then((result) => {
        if (result.value) {
            //debugger;
            $.ajax({
<<<<<<< HEAD
                url: "/accounts/Delete/",
=======
                url: "/konsumens/Delete/",
>>>>>>> f65659c69753d9ccb46fb78d7b64b52a63d078c6
                data: { id: id }
            }).then((result) => {
                //debugger;
                if (result.statusCode == 200) {
                    Swal.fire({
                        position: 'center',
                        icon: 'success',
                        title: 'Delete Successfully',
                        showConfirmButton: false,
                        timer: 1500,
                    });
                    table.ajax.reload();
                } else {
                    Swal.fire('Error', 'Failed to Delete', 'error');
                    ClearScreen();
                }
            })
        };
    });
}