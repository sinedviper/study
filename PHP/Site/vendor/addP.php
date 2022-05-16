<?php
require_once "../config/connect.php";
$name =$_POST['name'];
$cost =$_POST['cost'];

mysqli_query($connect,"INSERT INTO `product`(`id`,`product_name`,`cash`) VALUES (NULL,'$name','$cost')");

header( 'Location: ../product.php');
