<?php
$title = 'Home';
require_once "Block/header.php";
require_once "config/connect.php";
$result = $connect->query("SELECT * FROM `orders`");
$orders = mysqli_query($connect, "SELECT * FROM `orders`");
$orders = mysqli_fetch_all($orders);
$total = 0;
foreach ($orders as $order){
    $total += $order[5];
}
?>
<div class="container">
<h1 align="center">Home</h1>
<table class="table table-dark table-striped">
    <tr>
        <td>Quantity orders</td>
        <td><?= $result->num_rows ?></td>
    </tr>
    <tr>
        <td>Total amount</td>
        <td><?=$total?></td>
    </tr>
</table>
</div>
<?php
$connect->close();
require "Block/footer.php";
?>