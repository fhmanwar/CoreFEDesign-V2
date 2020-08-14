var table = null;

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
            url: "/accounts/loadAccount",
            type: "GET",
            dataType: "json",
            dataSrc: "",
        },
        "columns": [
            {
                "data": "id_acc",
                render: function (data, type, row, meta) {
                    return meta.row + meta.settings._iDisplayStart + 1;
                }
            },
            {
                "render": function (data, type, row) {
                    return row.name + '<br/><small>' + row.uname + '</small>'
                }
            },
            { "data": "mail" },
            { "data": "access" },
            {
                "sortable": false,
                "render": function (data, type, row) {
                    //console.log(row);
                    $('[data-toggle="tooltip"]').tooltip();
                    return '<button class="btn btn-link btn-md btn-warning " data-placement="left" data-toggle="tooltip" data-animation="false" title="Edit" onclick="return GetById(' + row.id_acc + ')" ><i class="fa fa-lg fa-edit"></i></button>'
                        + '&nbsp;'
                        + '<button class="btn btn-link btn-md btn-danger" data-placement="right" data-toggle="tooltip" data-animation="false" title="Delete" onclick="return Delete(' + row.id_acc + ')" ><i class="fa fa-lg fa-times"></i></button>'
                }
            }
        ]
    });
});

function ClearScreen() {
    $('#Id').val('');
    $('#Name').val('');
    $('#Uname').val('');
    $('#Email').val('');
    $('#Pass').val('');
    $('#Addr').val('');
    $('#Phone').val('');
    $('#Access').val('');
    $('#update').hide();
    $('#add').show();
}

function GetById(id) {
    //debugger;
    $.ajax({
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
        $('#add').hide();
        $('#update').show();
        $('#myModal').modal('show');
    })
}

function Save() {
    //debugger;
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
        } else {
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
                url: "/accounts/Delete/",
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