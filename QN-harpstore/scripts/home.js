var home = {} || home;
var indexSlide = 0;


home.load = function() {
    $.ajax({
        url:' http://localhost:3000/productObj',
        method:'GEt',
        dataType:'JSON',
        success: function(data){
            $('#main').empty();
            $.each(data,function(index,value){
                $('#main').append(
                    '<div class="col-lg-3 col-md-6 mb-4" id="pro-'+value.id+'">' +
                        '<div class="card h-100">'+
                        '<input type="text" hidden id="nameItem'+value.id+'" name="nameItem" value="'+value.name+'">'+
                        '<input type="text" hidden id="priceItem'+value.id+'" name="priceItem" value="'+value.price+'">'+
                        '<img class=""  width="200px" height="200px" hidden id="imageItem'+value.id+'" src="'+ value.image +'" alt="'+ value.name +'">'+
                            '<img class="card-img-top"  width="200px" height="200px" src="'+ value.image +'" alt="'+ value.name +'">'+
                            '<div class="card-body">'+
                                '<h4 class="card-title" id="productName" >'+ value.name +'</h4>'+
                                '<p class="card-text" id="productPrice" >'+ convertCurency(value.price) +"&#8363;" +'</p>'+
                            '</div>' +
                            '<div class="card-footer">'+
                                '<input type="number" id="quantity'+ value.id +'" class="input-text qty text" step="1" min="1" max="9999" name="quantity" value="1" title="SL" size="1" inputmode="numeric">'+
                                '<br>'+      
                                '<br>'+                        
                                '<button class="btn btn-primary"  onclick="add2cart('+value.id+')"  >Add To Cart</button>'+
                        
                            '</div>'+
                        '</div>'+
                    '</div>'
                )
            });
        }
    });
}
home.init = function(){
    home.load();
}

$(document).ready(function(){
    home.init();
});
home.buy = function(){
    bootbox.alert({
        message: "Sản phẩm đã được thêm vào giỏ hàng!"
    })
}

function convertCurency (val) {
    return val.toString().replace(/(\d)(?=(\d\d\d)+(?!\d))/g, "$1,")
}
