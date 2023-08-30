
// Write your JavaScript code.
function callCoin() {
    $.ajax({
        url: 'Coin/CoinHistoricValues',
        type: "GET",
        data: "",

    }).done(function (data) {

        CanvasLineView(data.data5y);

        CanvasCandlestickView(data.data30ds);

    }).fail(function (jqXHR, textStatus) {
        console.log("Request failed: " + textStatus);

    }).always(function () {
        console.log("completou");
    });
}

function CanvasLineView(data) {
    var date = [];
    var value = [];
    for (var i = 0; i <= data.length - 1; i++) {
        date.push(data[i].time_close);
        value.push(data[i].price_close)
    }
    var path = $('#speedChart');
    new Chart(path, {
        type: 'line',
        data: {
            labels: date,
            datasets: [{
                label: 'Preço do bitcoin em 5 anos',
                data: value,
                backgroundColor: 'rgba(54, 162, 235, 0.2)',
                borderColor: 'rgba(54, 162, 235, 1)',
                borderWidth: 1
            }]
        },
        options: {
            legend: {
                display: true
            }  
        }
    });
   
}

function CanvasCandlestickView(data) {
    var dataPoints = [];

    for (var i = 0; i <= data.length - 1; i++) {
        dataPoints.push({
            x: new Date(data[i].time_close),
            y: [(data[i].price_open),
                (data[i].price_high),
                (data[i].price_low),
                (data[i].price_close)],
           
        });
    }


    var options = {
        animationEnabled: true,
        theme: "light2",
        exportEnabled: true,
        title: {
            text: "Gráfico candlestick BTC dos ultimos 30 dias"
        },
        axisX: {
            interval: 2,

          //valueFormatString: "DD MM YYYY"
        },
        axisY: {
            prefix: "$",
            includeZero: false,
            title: "Price (in USD)"
        },
        data: [{
            type: "candlestick",
            risingColor: "#F79B8E",
            yValueFormatString: "$###0.00",
            //xValueFormatString: "DD MM YYYY",

            dataPoints: dataPoints
        }]
    };
    $("#candlestick").CanvasJSChart(options);
}
