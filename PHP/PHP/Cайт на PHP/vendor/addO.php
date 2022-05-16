<?php
require_once "../config/connect.php";
$name =$_POST['nameC'];
$productN =$_POST['productN'];
$productQ =$_POST['productQ'];
$pay =$_POST['pay'];

$amount = mysqli_query($connect,"SELECT * FROM `product` WHERE `product_name`='$productN'");
$amount = mysqli_fetch_assoc($amount);
$amountP = $amount['cash'];
$total = $amount['cash'] * $productQ;

mysqli_query($connect,"INSERT INTO `orders`(`id`,`name`,`product_name`,`quantity`,`amount_product`,`pay`,`type_payment`) VALUES (NULL,'$name','$productN','$productQ','$amountP','$total','$pay')");

header( 'Location: ../orders.php');