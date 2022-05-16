<?php
require_once "../config/connect.php";
$id = $_POST['id'];
$name = $_POST['nameClient'];
$email= $_POST['emailClient'];

mysqli_query($connect,"UPDATE `clients` SET `name` = '$name', `email` = '$email' WHERE `clients`.`id`='$id'");

header( 'Location: ../client.php');

