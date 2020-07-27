var protype = {} || protype;
protype.drawTable = function () {
    $.ajax({
        url : "/Protype/GetAll",
        method : "GET",
        dataType : "json",
        success : function (data) {
            $('#tbProType tbody').empty();
            $.each(data.listProType, function (i, v) {
                var products = v.products > 0 ?
                    `<a href="/Product/OfProType/${v.proTypeId}" title="Product list">${v.products}</a>` :
                    `${v.products}`;
                $('#tbProType tbody').append(
                    `<tr>
                        <td>${v.proTypeId}</td>
                        <td>${v.proTypeName}</td>
                        <td>${products}</td>
                        <td>
                            <a href="javascripts:;" class="btn btn-success"
                                           onclick="home.get(${v.producerId})">Edit</a> 
                            <a href="javascripts:;" class="btn btn-danger"
                                           onclick="home.delete(${v.producerId})">Remove</a>
                        </td>
                    </tr>`
                )
            });
        }
    })
};
protype.init = function () {
    protype.drawTable();
};
$(document).ready(function () {
    protype.init();
});