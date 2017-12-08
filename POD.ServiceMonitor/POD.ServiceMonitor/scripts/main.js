$(document).ready(function() {
    var service1 = {
        x: ["Mon", "Tue", "Wed", "Thu", "Fri"],
        y: [10, 15, 13, 17, 23],
        name: 'service 1',
        type: 'bar',
        marker: { color: '#20c997' }
    };
    var service2 = {
        x: ["Mon", "Tue", "Wed", "Thu", "Fri"],
        y: [16, 5, 11, 9, 22],
        name:'service 2',
        type: 'bar',
        marker: { color: '#2196F3' }
    };
    var data = [service1, service2];

    Plotly.newPlot('myDiv', data);
});
