<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Orders</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css" rel="stylesheet">
    <style>
        table {
            margin: auto;
            border: 2px solid #000000; /* Рамка вокруг таблицы */
        }
        td {
            text-align: center;
        }
    </style>
</head>
<body>
<?php
session_start();
$title = "Orders";
require_once "../config/connect.php";
$client = mysqli_query($connect, "SELECT * FROM `clients`");
$client = mysqli_fetch_all($client);
$product = mysqli_query($connect, "SELECT * FROM `product`");
$product = mysqli_fetch_all($product);
?>
<h2 align="center">Add new orders</h2>
<div class="container">
    <form action="addO.php" method="post">
        <p>Name</p>
        <select name="nameC" class="form-select" aria-label="Default select example">
            <option selected="selected">Select name</option>
            <?php foreach ($client as $client){?>
            <option value="<?= $client[1]?>"><?= $client[1];}?></option>
        </select>
        <p>Product name</p>
        <select name="productN" class="form-select" aria-label="Default select example">
            <option selected="selected">Select product</option>

            <?php foreach ($product as $product){?>
            <option value="<?= $product[1]?>"><?= $product[1];}?></option>
        </select>
        <p>Quantity product</p>
        <input type="number" name="productQ" class="form-control">
        <p>Type pay</p>
        <select name="pay" class="form-select" aria-label="Default select example">
            <option selected="selected">Select pay</option>
            <option value="1">Paid order</option>
            <option value="2">Prepayment 15%</option>
            <option value="3">Consignment</option>
        </select><br>
        <input value="Add" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../orders.php"'>
    </form>
</div>
<?php

require "../Block/footer.php";
$connect -> close();
?>
