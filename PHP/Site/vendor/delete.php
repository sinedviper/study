<?php
require_once "../config/connect.php";

$id = $_GET['id'];

mysqli_query($connect, "DELETE FROM `clients` WHERE `clients`.`id`='$id'");

header( 'Location: ../client.php');