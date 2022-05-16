<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title><?php echo $title ?></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet">

    <script>
        function sortTable(n) {
            var table, rows, switching, i, x, y, shouldSwitch, dir, switchcount = 0;
            table = document.getElementById("myTable2");
            switching = true;
            dir = "asc";
            while (switching) {
                switching = false;
                rows = table.getElementsByTagName("TR");
                for (i = 1; i < (rows.length - 1); i++) {
                    shouldSwitch = false;
                    x = rows[i].getElementsByTagName("TD")[n];
                    y = rows[i + 1].getElementsByTagName("TD")[n];
                    if (dir == "asc") {
                        if (x.innerHTML.toLowerCase() > y.innerHTML.toLowerCase()) {
                            shouldSwitch = true;
                            break;
                        }
                    } else if (dir == "desc") {
                        if (x.innerHTML.toLowerCase() < y.innerHTML.toLowerCase()) {
                            shouldSwitch = true;
                            break;
                        }
                    }
                }
                if (shouldSwitch) {
                    rows[i].parentNode.insertBefore(rows[i + 1], rows[i]);
                    switching = true;
                    switchcount ++;
                } else {

                    if (switchcount == 0 && dir == "asc") {
                        dir = "desc";
                        switching = true;
                    }
                }
            }
        }
    </script>

    <style>

        a.text:active,
        a.text:hover,
        a.text {
            text-decoration: none;
            color: #000;
        }
        table{
            margin: auto;
            border: 2px solid #000000;
        }
        td {
            text-align: center;
        }
    </style>

</head>
<body>
<header>
    <div class="container">
    <table class="table">
        <thead class="table-dark">
            <td><a href="index.php" class="text" style="color: white"><h3>Home</h3> </a></td>
            <td><a href="client.php" class="text" style="color: white"><h3>Client</h3> </a></td>
            <td><a href="product.php" class="text" style="color: white"><h3>Product</h3> </a></td>
            <td><a href="orders.php" class="text" style="color: white"><h3>Orders</h3> </a></td>
        </thead>

    </table>

    </div>
</header>
