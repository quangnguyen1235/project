var customer ={} || customer;
customer.openModal = function() {
    customer.reset();
    $('#customerInformation').modal('show')
}
customer.drawTable = function() {
    $.ajax({
        url:"http://localhost:3000/orderInfomation",
        method:"GET",
        dataType:"JSON",
        success: function(data){
            $('#tbOrder tbody').empty();
            $.each(data,function(i,v){
                $('#tbOrder tbody').append(
                    `
                    <tr>
                        <td>${v.id}</td>
                        <td>${v.name}</td>
                        <td>${v.address}</td>
                        <td>${v.phonenumber}</td>
                        <td>
                            <a href='javascript:void(0);' title='edit order' onclick='customer.get(${v.id})'><i class='fa fa-edit'></i></a>
                            <a href='javascript:void(0);' title='remove order' onclick='customer.remove(${v.id})'><i class='fa fa-trash'></i></a>
                        </td>
                    </tr>

                    `
                )
            })
        }
    })
},
customer.save = function(){
    if($('#formAddOrderInfomation').valid()){        
        if ($('#customerId').val() == 0) {
            var addObj = {};
            addObj.name = $('#customerName').val();
            addObj.address = $('#customerAddress').val();
            addObj.id = parseInt($('#customerId').val());
            addObj.phonenumber = $('#customerPhoneNumber').val();
    
            $.ajax({
                url: "http://localhost:3000/orderInfomation/",
                method : "POST",
                data : JSON.stringify(addObj),
                dataType: "json",
                contentType: "application/json",
                success : function(data){
                    $('#formAddOrderInfomation').modal('hide');
                    bootbox.alert("Đơn hàng đã được thêm thành công!");
                    customer.drawTable();
                }
            });
        } else {
            var addObj = {};
            addObj.name = $('#customerName').val();
            addObj.address = $('#customerAddress').val();
            addObj.id = parseInt($('#customerId').val());
            addObj.phonenumber = $('#customerPhoneNumber').val();
    
            $.ajax({
                url: "http://localhost:3000/orderInfomation/" + addObj.id,
                method : "PUT",
                data : JSON.stringify(addObj),
                dataType: "json",
                contentType: "application/json",
                success : function(data){
                    $('#formAddOrderInfomation').modal('hide');
                    bootbox.alert("Thông tin đơn hàng đã cập nhật thành công!");
                    customer.drawTable();
                }
            });
        }
    }
};
customer.get = function(id){
    console.log(id);
    $.ajax({
        url : "http://localhost:3000/orderInfomation/"+id,
        method : "GET",
        contentType : "JSON",
        success : function(data){
            $("#customerName").val(data.name);
            $("#customerAddress").val(data.address);
            $("#customerId").val(data.id);
            $("#customerPhoneNumber").val(data.phonenumber);
            $("#customerInformation").modal('show');
        }
    });
};
customer.remove = function(id){
    bootbox.confirm({
        title: "Xóa đơn hàng",
        message: "Bạn có chắc muốn xóa đơn hàng này?",
        buttons: {
            confirm: {
                label: '<i class="fa fa-check"></i> Có'
            },
            cancel: {
                label: '<i class="fa fa-times"></i> Không'
            }
        },
        callback: function (result) {
            if(result){
                $.ajax({
                    url: "http://localhost:3000/orderInfomation/" + id,
                    method : "DELETE",
                    contentType : "JSON",
                    success : function(data){
                        bootbox.alert("Đơn hàng đã được xóa thành công!");
                        customer.drawTable();
                    }
                });
            }
        }
    });
};
customer.init = function(){
    customer.drawTable();
};
$(document).ready(function(){
    customer.init();
});
customer.reset = function(){
    $("#customerName").val('');
    $("#customerAddress").val('');
    $("#customerId").val('0');
    $("#customerPhoneNumber").val('');
    var validator = $("#formAddOrderInfomation").validate();
    validator.resetForm();
}
