var producer = {} || producer;
producer.drawTable = function () {
    $.ajax({
        url : "/Producer/GetAll",
        method : "GET",
        dataType : "json",
        success : function (data) {
            $('#tbProducer tbody').empty();
            $.each(data.listProducer, function (i, v) {
                var products = v.products > 0 ?
                    `<a href="/Product/OfProducer/${v.producerId}" title="Product list">${v.products}</a>` :
                    `${v.products}`;
                $('#tbProducer tbody').append(
                    `<tr>
                        <td>${v.producerId}</td>
                        <td>${v.producerName}</td>
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
producer.init = function () {
    producer.drawTable();
};
$(document).ready(function () {
    producer.init();
});