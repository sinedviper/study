<?php
session_start();
$title = "Product";
require_once "Block/header.php";
require_once "config/connect.php";
?>

    <h1 align="center">Product</h1>
    <div class="container">
        <table class="table" id="myTable2">
            <thead class="table-dark">
                <td onclick="sortTable(0)">Id</td>
                <td onclick="sortTable(0)">Name</td>
                <td onclick="sortTable(0)">Cost(lv)</td>
                <td>Edit</td>
                <td>Delete</td>
            </thead>
            <?php
            $product = mysqli_query($connect,"SELECT * FROM `product`");
            $product = mysqli_fetch_all($product);
            foreach ($product as $products){
                ?>
                <tr>
                    <td><?= $products[0]?></td>
                    <td><?= $products[1]?></td>
                    <td><?= $products[2]?></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/editProduct.php?id=<?= $products[0]?>"'><img src="Image/Edit.gif" alt=""></button></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/deleteP.php?id=<?= $products[0]?>"''><img src="Image/Delete.gif" alt=""></button></td>
                </tr>
                <?php
            }
            ?>
        </table >
        <table class="table">
            <tr>
                <td>
                    <form action="vendor/addProduct.php" method="post">
                        <h5>Add new product
                            <button type="button" class="btn btn-outline-secondary" onclick='location.href="vendor/addProduct.php"'><img src="Image/Add.gif" alt=""></button></td>
                </h5>
                </form>
            </tr>
        </table>
    </div>

<?php
$connect->close();
require "Block/footer.php";
?>