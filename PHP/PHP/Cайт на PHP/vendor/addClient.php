<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <title>Client</title>
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
$title = "Client";
require_once "../config/connect.php";

?>
<h2 align="center">Add new clients</h2>
<div class="container">
    <form action="add.php" method="post">
        <p>Name</p>
        <input type="text" name="nameClient" class="form-control">
        <p>Email</p>
        <input type="email" name="emailClient" class="form-control"><br>
        <input value="Add" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../client.php"'>
    </form>
</div>
<?php

require "../Block/footer.php";
$connect -> close();
?>