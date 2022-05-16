<?php
session_start();
require_once "../config/connect.php";
$id = $_GET['id'];
$client = mysqli_query($connect,"SELECT * FROM `clients` WHERE `id` = '$id'");
$client = mysqli_fetch_assoc($client);
?>
<!doctype html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Client</title>
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

<h2 align="center">Update clients</h2>
<div class="container">
    <form action="update.php" method="post">
        <input type="hidden" name="id" value="<?= $client['id']?>">
        <p>Name</p>
        <input type="text" name="nameClient" class="form-control" value="<?= $client['name']?>">
        <p>Email</p>
        <input type="email" name="emailClient" class="form-control" value="<?= $client['email'] ?>"><br>
        <input value="Update" class="btn btn-outline-secondary" type="submit">
        <input value="Exit" class="btn btn-outline-secondary" onclick='location.href="../client.php"'>
    </form>
</div>
<?php
$connect -> close();
require "../Block/footer.php";
?>