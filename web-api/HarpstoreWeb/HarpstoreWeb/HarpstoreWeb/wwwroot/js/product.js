var product = {} || product;
var producerId = 0;
product.drawTable = function () {
    $.ajax({
        url: `/Product/GetbyProducer/${producerId}`,
        method: "GET",
        dataType: "json",
        success: function (data) {
            $('#tbProduct tbody').empty();
            $.each(data.dataProductView, function (i, v) {
                $('#tbProduct tbody').append(
                    `<tr>
                        <td>
                        <a href="/Product/Details/${v.productId}" title="Product Details">${v.productName}</a> 
                        </td>
                        <td>${v.avataPath}</td>
                        <td>${v.proTypeName}</td>
                        <td>${v.productPrice}</td>
                        <td>
                            <a href="javascripts:;" class="btn btn-success"
                                           onclick="home.get(${v.productId})">Edit</a> 
                            <a href="javascripts:;" class="btn btn-danger"
                                           onclick="home.delete(${v.productName})">Remove</a>
                        </td>
                    </tr>`
                )
            });
        }
    })
}
product.init = function () {
    product.drawTable();
};
// modified
product.save = function () {
    var saveObj = {};
    saveObj.DepartmentName = $('#DepartmentName').val();
    saveObj.DepartmentId = parseInt($('#DepartmentId').val());
    $.ajax({
        url: `/Home/Save/`,
        method: "POST",
        dataType: "json",
        contentType: "application/json",
        data: JSON.stringify(saveObj),
        success: function (data) {
            $('#addEditdepartment').modal('hide');
            bootbox.alert(data.result.message);
            employee.drawTable();
        }
    });
}
product.uploadImage = function (input) {
    if (input.files && input.files[0]) {
        var reader = new FileReader();
        reader.onload = function (e) {
            $('#Image').attr('src', e.target.result);
            console.log(e.target.result);
        };
        reader.readAsDataURL(input.files[0]);
    }
};

$(document).ready(function () {
    producerId = $('#ProducerId').val();
    product.init();
});