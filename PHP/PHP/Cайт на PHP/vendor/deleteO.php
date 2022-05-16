<?php
require_once "../config/connect.php";

$id = $_GET['id'];

mysqli_query($connect, "DELETE FROM `orders` WHERE `orders`.`id`='$id'");

header( 'Location: ../orders.php');

