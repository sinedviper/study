<?php
session_start();
require_once "../config/connect.php";
$id = $_GET['id'];
$product = mysqli_query($connect,"SELECT * FROM `product` WHERE `id` = '$id'");
$product = mysqli_fetch_assoc($product);
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Product</title>
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

<h2 align="center">Update products</h2>
<div class="container">
    <form action="updateP.php" method="post">
        <input type="hidden" name="id" value="<?= $product['id']?>">
        <p>Name</p>
        <input type="text" name="name" class="form-control" value="<?= $product['product_name']?>">
        <p>Email</p>
        <input type="number" name="cost" class="form-control" value="<?= $product['cash'] ?>"><br>
        <input value="Update" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../product.php"'>
    </form>
</div>
<?php
$connect -> close();
require "../Block/footer.php";
?>
