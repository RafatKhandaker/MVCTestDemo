$(document).ready(function () {
    var data;
    const dataTable = $('#data-table');

    function refreshTable(data){
        dataTable.empty();
        $.each(data, function (i, items) {
            var rows =
                "<tr>" +
                    "<td>" + items.FundName + "</td>" +
                    "<td>" + items.Ticket + "</td>" +
                    "<td>" + items.MorningStar + "</td>" +
                    "<td>" + items.OneMo + "</td>" +
                    "<td>" + items.ThirdMo + "</td>" +
                    "<td>" + items.OneYr + "</td>" +
                    "<td>" + items.FiveYr + "</td>" +
                    "<td>" + items.InceptionToDate + "</td>" +
                +"</tr>";
            dataTable.append(rows);
        })
    };

    $('#searchBtn').on('click', function () {
        $.ajax({
            type: 'POST',
            url: '/home/SearchIndex',
            datatype: JSON,
            data: { 'search': $('input[name=search]').val() },
            success: function (data) { refreshTable(data); },
            error: function (data) { alert('failed to return JSON Data'); }
            })
    })
})