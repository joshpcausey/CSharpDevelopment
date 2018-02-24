//ts-check
$(document).ready(function () {
    loadItems();
});

function loadItems() {
    var contentRows = $('#contentRows');

    $.ajax({
        type: 'GET',
        url: 'http://localhost:8080/items',
        success: function (itemArray) {
            $.each(itemArray, function (index, item) {
                id = item.id;
                name = item.name;
                price = item.price;
                quantity = item.quantity;

                var row = '<div class="col"><div class="card" style="width: 18rem;"><div class="card-body">';
                row += '<p>' + id + '</p>';
                row += '<h5 class="card-title text-center">' + name + '</h5>';
                row += '<p class="card-text text-center">' + price + '</p>';
                row += '<p class="text-center">Quantity Left: ' + quantity + '</p>';
                row += '</div></div></div>';
                contentRows.append(row);
            })
        },
        error: function () {

        }
    });
}