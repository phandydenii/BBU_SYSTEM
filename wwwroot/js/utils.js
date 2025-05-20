
function campus() {
    const campus = localStorage.getItem("campus");
    const token = localStorage.getItem("token");
    console.log(campus);
    if (campus == "") {
        window.location.href = "/user/login";
    }
    if (token == "") {
        window.location.href = "/user/login";
    }
    return campus;
}
function formatDate(dateStr) {
    const date = new Date(dateStr);
    return date.toDateString("dd-MMMMyyyy");
}
function alertMessage(msg){
    alert(msg);
}


function fetchData(url, tbl, columns, onEdit) {
    const tableId = tbl.replace("#", ""); // Simplified string conversion
    const dtColumns = columns.map(col => ({ data: col }));
    // Add action column
    dtColumns.push({
        data: null,
        render: function (data, type, row) {
            // Properly pass the row data to the onEdit function
            return `<button class="btn btn-success btn-sm" onclick="(${onEdit})(\`${JSON.stringify('1')}\`)">Edit</button>`;
        }
    });
    

    // Initialize DataTable
    $(`#${tableId}`).DataTable({
        responsive: true,
        lengthChange: true,
        autoWidth: true,
        destroy: true,
        ajax: {
            url: `/api/mis/${campus()}/${url}`,
            type: "GET",
            dataSrc: "data"
        },
        columns: dtColumns
    })
        .buttons()
        .container()
        .appendTo(`#${tableId}_wrapper .col-md-6:eq(0)`); // Fixed wrapper selector
}

function bindDropdown(cbo, data, value, display) {
    const select = document.getElementById(`${cbo}`);
    select.innerText = "";
    const option = document.createElement("option");
    option.value = value;
    option.text = display;
    select.appendChild(option);
}