<?php
require_once "../config/connect.php";
$id = $_POST['id'];
$name = $_POST['name'];
$cost= $_POST['cost'];

mysqli_query($connect,"UPDATE `product` SET `product_name` = '$name', `cash` = '$cost' WHERE `product`.`id`='$id'");

header( 'Location: ../product.php');


