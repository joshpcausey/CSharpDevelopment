//ts-check
$(document).ready(function() {
  loadItems();

  $('#contentRows').on("click", ".clickedCard", function() {
    var id = $(this).find('p').attr('id');;
    $('#itemNumber').attr('placeholder', id);
  });
});



function loadItems() {
  var contentRows = $('#contentRows');

  $.ajax({
    type: 'GET',
    url: 'http://localhost:8080/items',
    success: function(itemArray) {
      $.each(itemArray, function(index, item) {
        id = item.id;
        name = item.name;
        price = item.price;
        quantity = item.quantity;

        var row = '<div class="col"><div class="card" style="width: 18rem;"><div class="card-body clickedCard">';
        row += '<p id="' + id + '"">' + id + '</p>';
        row += '<h5 class="card-title text-center">' + name + '</h5>';
        row += '<p class="card-text text-center">$' + price + '</p>';
        row += '<p class="text-center">Quantity Left: ' + quantity + '</p>';
        row += '</div></div></div>';
        contentRows.append(row);
      });
    },
    error: function() {
      $('#errorMessage')
        .append($('<li>')
          .attr({
            class: 'list-group-item list-group-item-danger'
          })
          .text('Error calling web service, please try again later'));
    }
  });
}
