<?php
require_once "../config/connect.php";

$id = $_GET['id'];

mysqli_query($connect, "DELETE FROM `product` WHERE `product`.`id`='$id'");

header( 'Location: ../product.php');

