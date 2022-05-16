<?php
session_start();
require_once "../config/connect.php";
$id = $_GET['id'];
$orders = mysqli_query($connect,"SELECT * FROM `orders` WHERE `id` = '$id'");
$orders = mysqli_fetch_assoc($orders);
$client = mysqli_query($connect, "SELECT * FROM `clients`");
$client = mysqli_fetch_all($client);
$product = mysqli_query($connect, "SELECT * FROM `product`");
$product = mysqli_fetch_all($product);
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

<h2 align="center">Update orders</h2>
<div class="container">
    <form action="updateO.php" method="post">
        <input type="hidden" name="id" value="<?= $orders['id']?>">
        <p>Name</p>
        <select name="nameC" class="form-select" aria-label="Default select example">
            <option selected value="<?= $orders['name']?>"><?= $orders['name']?></option>
            <?php foreach ($client as $client){?>
            <option value="<?= $client[1]?>"><?= $client[1];}?></option>
        </select>
        <p>Product name</p>
        <select name="productN" class="form-select" aria-label="Default select example">
            <option selected value="<?= $orders['product_name']?>"><?= $orders['product_name']?></option>
            <?php foreach ($product as $product){?>
            <option value="<?= $product[1]?>"><?= $product[1];}?></option>
        </select>
        <p>Quantity product</p>
        <input type="number" name="productQ" class="form-control" value="<?=$orders['quantity']?>">
        <p>Type pay</p>
        <select name="pay" class="form-select" aria-label="Default select example">
            <option value="<?= $orders['type_payment']?>"><?php switch ($orders['type_payment']) {
                    case 1: echo "Pair order";
                        break;
                    case 2: echo "Prepayment 15%";
                        break;
                    case 3: echo "Consignment";
                        break;
                }?></option>
            <option value="1">Paid order</option>
            <option value="2">Prepayment 15%</option>
            <option value="3">Consignment</option>
        </select><br>
        <input value="Update" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../orders.php"'>
    </form>
</div>
<?php
$connect -> close();
require "../Block/footer.php";
?>
