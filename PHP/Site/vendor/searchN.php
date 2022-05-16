<?php
session_start();
require_once "../config/connect.php";
$total = $_POST['total'];
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Orders</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        table {
            margin: auto;
            border: 2px solid #000000;
        }
        td {
            text-align: center;
        }
    </style>
</head>
<body>
<h2 align="center">Client</h2>
<div class="container">
    <table class="table">
        <thead class="table-dark">
        <td>Id</td>
        <td>Name</td>
        <td>Product name</td>
        <td>Quantity product</td>
        <td>Cost product</td>
        <td>Total amount</td>
        <td>Type pay</td>
        </thead>
        <?php
        $orders = mysqli_query($connect,"SELECT * FROM `orders` WHERE `pay` < '$total'");
        $orders = mysqli_fetch_all($orders);
        foreach ($orders as $orders) {?>
            <tr>
                <td><?= $orders[0]?></td>
                <td><?= $orders[1]?></td>
                <td><?= $orders[2]?></td>
                <td><?= $orders[3]?></td>
                <td><?= $orders[4]?></td>
                <td><?= $orders[5]?></td>
                <td><?php switch ($orders[6]) {
                        case 1: echo "Pair order";
                            break;
                        case 2: echo "Prepayment 15%";
                            break;
                        case 3: echo "Consignment";
                            break;
                    };?>
                </td>
            </tr>
            <?php
        }
        ?>
    </table>
    <table class="table">
        <tr>
            <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../orders.php"'>
        </tr>
    </table>
</div>

<?php
$connect -> close();
require "../Block/footer.php";
?>

