<?php
require_once "../config/connect.php";
$nameClient =$_POST['nameClient'];
$emailClient =$_POST['emailClient'];

mysqli_query($connect,"INSERT INTO `clients`(`id`,`name`,`email`) VALUES (NULL,'$nameClient','$emailClient')");

header( 'Location: ../client.php');