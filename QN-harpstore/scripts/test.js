var cart = {} || cart;

cart.draw = function() {
    cart.getInfo();
    $.ajax({
        url:' http://localhost:3000/productObj',
        method:'GET',
        dataType:'JSON',
        contentType: "application/json",
        success: function(data){
            $('#tbCart tbody').empty();
            $.each(data,function(i,v){
                $('#tbCart tbody').append(
                    "<tr>"+
                    "<td><img src='"+ v.image +"' width='100px' height='70px' /></td>" +
                    "<td>"+ v.name +"</td>" +
                    "<td>"+ v.price +" ₫"+"</td>" +
                    '<td class="qty"><input type="text" class="form-control" id="input1" value="2"></td>'+
                    '<td>178$</td>'+
                    '<td></td>'+
                  "</tr>"
                )
            })
        }
    })
};

cart.addCart = function(id){

}
cart.openModal = function() {
    $('#cartModal').modal('show');
}
cart.init = function() {

};
$(document).ready(function() {
    cart.init();
});