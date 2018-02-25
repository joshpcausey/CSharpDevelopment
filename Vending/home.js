//ts-check
$(document).ready(function() {
  loadItems();

  $('#contentRows').on("click", ".clickedCard", function() {
    changeItem($(this));
  });

  $('#addDollar').on('click', function() {
    addDollar();
  });

  $('#addQuarter').on('click', function() {
    addQuarter();
  });

  $('#addDime').on('click', function() {
    addDime();
  });

  $('#addNickel').on('click', function() {
    addNickel();
  });

  $('#buyItem').on('click', function() {
    buyItem();
  });

  $('#changeReturn').on('click', function() {
    changeReturn();
  });
});

var totalAmmount = 0.00;

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

function changeReturn() {
  totalAmmount = 0.00;
  $('#changeReturnAmmount').attr('placeholder', "");
  $('#itemNumber').attr('placeholder', "");
  $('#totalAmmountAdded').attr('placeholder', 0.00);
}

function buyItem() {
  var itemNumberSelected = $('#itemNumber').attr('placeholder');
  var ammountOfMoney = $('#totalAmmountAdded').attr('placeholder');
  //url: 'http://localhost:8080/money/' + ammountOfMoney + '/item/' + itemNumberSelected,
  $.ajax({
    type: 'GET',
    url: 'http://localhost:8080/money/' + ammountOfMoney + '/item/' + itemNumberSelected,
    success: function(change) {
      var quarters = change.quarters;
      var dimes = change.dimes;
      var nickels = change.nickels;
      var pennies = change.pennies;
      var messageForChange = "";
      if (quarters > 0) {
        messageForChange += " Quarter(s): " + quarters;
      }
      if (dimes > 0) {
        messageForChange += " Dime(s): " + dimes;
      }
      if (nickels > 0) {
        messageForChange += " Nickle(s): " + nickels;
      }
      if (pennies > 0) {
        messageForChange += " Pennie(s): " + pennies;
      }
      $('#changeReturnAmmount').attr('placeholder', messageForChange);
      removeItems();
      loadItems();
    },
    error: function(xhr, ajaxOptions, thrownError) {
      console.log(xhr.responseText);
      var json = xhr.responseText;
      var messageParsed = JSON.parse(json);
      $('#errorMessages').attr('placeholder', messageParsed.message);
    }
  });
}

function removeItems() {
  $('#contentRows').children('.col').remove();
}

function changeItem(clickedCard) {
  var id = $(clickedCard).find('p').attr('id');;
  $('#itemNumber').attr('placeholder', id);
}

function precisionRound(number, precision) {
  var factor = Math.pow(10, precision);
  return Math.round(number * factor) / factor;
}

function addNickel() {
  $('#totalAmmountAdded').attr('placeholder', totalAmmount = precisionRound(totalAmmount += 0.05, 2));

}

function addDime() {
  $('#totalAmmountAdded').attr('placeholder', totalAmmount = precisionRound(totalAmmount += 0.10, 2));
}

function addDollar() {
  $('#totalAmmountAdded').attr('placeholder', totalAmmount = precisionRound(totalAmmount += 1.00, 2));
}

function addQuarter() {
  $('#totalAmmountAdded').attr('placeholder', totalAmmount = precisionRound(totalAmmount += 0.25, 2));
}
