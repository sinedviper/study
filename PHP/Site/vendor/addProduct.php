<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Product</title>
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
$title = "Product";
require_once "../config/connect.php";

?>
<h2 align="center">Add new products</h2>
<div class="container">
    <form action="addP.php" method="post">
        <p>Name</p>
        <input type="text" name="name" class="form-control">
        <p>Cost(lv)</p>
        <input type="number" name="cost" class="form-control"><br>
        <input value="Add" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../product.php"'>
    </form>
</div>
<?php

require "../Block/footer.php";
$connect -> close();
?>
