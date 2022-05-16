<?php
require_once "../config/connect.php";
$id = $_POST['id'];
$name =$_POST['nameC'];
$productN =$_POST['productN'];
$productQ =$_POST['productQ'];
$pay =$_POST['pay'];

$amount = mysqli_query($connect,"SELECT * FROM `product` WHERE `product_name`='$productN'");
$amount = mysqli_fetch_assoc($amount);
$amountP = $amount['cash'];
$total = $amount['cash'] * $productQ;

mysqli_query($connect,"UPDATE `orders` SET `name` = '$name', `product_name` = '$productN', `quantity` = '$productQ', `amount_product` = '$amountP', `pay` = '$total', `type_payment`='$pay' WHERE `orders`.`id`='$id'");


header( 'Location: ../orders.php');

