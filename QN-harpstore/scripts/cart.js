// add2cart = function(){
//     console.log('1');
//     var proId = $('#idItem').val();
//     console.log(proId);
// }
var cart = [];
function add2cart(id) {
    
    var proId = id;
    var proImage = $('#imageItem'+id+'').attr('src');
    var proName = $('#nameItem'+id+'').val();
    var proPrice = +$('#priceItem'+id+'').val();
    var proQuantity = +$('#quantity'+id+'').val();
    var Item = {
        id: proId,
        itemName: proName,
        itemPrice: proPrice,
        itemImage: proImage,
        itemQuantity: proQuantity,
    };
    //check san pham
    var flag = false;
    for(var i = 0; i < cart.length; i++) {
        if(cart[i].id == Item.id) {
            flag=true;
            break;
        }
    }
    //san pham chua co
    if (flag===false) {
        cart.push(Item)
        bootbox.alert({
            message: "Sản phẩm đã được thêm vào giỏ hàng!"
        })
    }
    //san pham da co
    else{
        bootbox.alert({
            message: "Số lượng sản phẩm đã được cập nhật trong giỏ hàng!"
        })
        cart[i].itemQuantity += proQuantity;
    }
    drawCart();
}
function drawCart(){
    $('#tbCart tbody').empty();
    var cartUnit="";
    var totalMonney=0;
    cart.length > 0
    for (var i = 0; i < cart.length; i++) {
        totalMonney += cart[i].itemPrice*cart[i].itemQuantity
        cartUnit+= 
        `<tr>
            <td><img id="Image" src="${cart[i].itemImage}" width='100px' height='70px'></td>
            <td>${cart[i].itemName}</td>
            <td>${convertCurency(cart[i].itemPrice)}&#8363;</td>
            <td><input type="text" class="form-control" id="input1" value="${cart[i].itemQuantity}"></td>
            <td>${convertCurency((cart[i].itemPrice)*(cart[i].itemQuantity))}</td>
            <td><a class="btn btn-danger"href='javascript:void(0);' title='remove item' onclick="deleteItem(${cart[i].id})"><i class="fa fa-ban" aria-hidden="true"></i></a></td>
        </tr>`
            
    };
    document.getElementById('totalMoney').innerHTML=convertCurency(totalMonney);
    $('#tbCart tbody').append(cartUnit);

}
function openModalCart(){
    $('#cartModal').modal('show');
};

function deleteItem(id){
    bootbox.confirm({
        title: "Xóa sản phẩm",
        message: "Bạn có chắc muốn xóa sản phẩm này khỏi giỏ hàng?",
        buttons: {
            confirm: {
                label: '<i class="fa fa-check"></i> Có'
            },
            cancel: {
                label: '<i class="fa fa-times"></i> Không'
            }
        },
        callback: function () {
            var flag = false;
            for(var i = 0; i < cart.length; i++) {
            if(cart[i].id == id) {
                cart.splice(i,1);
            break;
        }
    }    
    bootbox.alert("Sản phẩm đã được xóa thành công!")
        drawCart();
    }
})
}

//$(document).ready(function(){
   
        
    
// })



