<?php
session_start();
$title = "Orders";
require_once "Block/header.php";
require_once "config/connect.php";
?>

    <h1 align="center">Orders</h1>
    <div class="container">
        <table class="table" id="myTable2" >
            <thead class="table-dark">
                <td onclick="sortTable(1)">Id</td>
                <td onclick="sortTable(0)" >Name</td>
                <td onclick="sortTable(0)">Product name</td>
                <td onclick="sortTable(0)">Quantity product</td>
                <td onclick="sortTable(1)">Cost product</td>
                <td onclick="sortTable(1)">Total amount</td>
                <td onclick="sortTable(1)">Type pay</td>
                <td>Edit</td>
                <td>Delete</td>
            </tr>
            </thead>
            <?php
            $orders = mysqli_query($connect,"SELECT * FROM `orders`");
            $orders = mysqli_fetch_all($orders);
            foreach ($orders as $orders){
                ?>
                    <tbody>
                    <td><?= $orders[0]?></td>
                    <td><?= $orders[1]?></td>
                    <td><?= $orders[2]?></td>
                    <td><?= $orders[3]?></td>
                    <td><?= $orders[4]?></td>
                    <td><?= $orders[5]?></td>
                    <td><?php switch ($orders[6]) {
                        case 1: echo "Pair order";
                            break;
                        case 2: echo "Prepayment 15%";
                            break;
                        case 3: echo "Consignment";
                            break;
                    }?></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/editOrders.php?id=<?=$orders[0]?>"'><img src="Image/Edit.gif" alt=""></button></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/deleteO.php?id=<?=$orders[0]?>"''><img src="Image/Delete.gif" alt=""></button></td>
                    </tr>
                    </tbody>
                <?php } ?>
        </table>
        <input type="hidden" id="name_order" value="asc">
        <input type="hidden" id="age_order" value="asc">
        <table class="table">
                <td>
                    <form action="vendor/addOrders.php" method="post">
                        <h5>Add new orders
                            <button type="button" class="btn btn-outline-secondary" onclick='location.href="vendor/addOrders.php"'><img src="Image/Add.gif" alt=""></button></td>
                </h5>
                </form>
        </table>
        <table class="table">
                <form action="vendor/search.php" method="post">
                    <td>
                        <input type="text" name="name" class="form-control" value="Enter name">
                    </td>
                    <td>
                        <button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/search.php"'>Search client</button>
                    </td>
                </form>
        </table>
        <table class="table">
                <form action="vendor/searchM.php" method="post">
                    <td>
                        <input type="number" name="total" class="form-control" value="0">
                    </td>
                    <td>
                        <button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/searchM.php"'>Search total max</button>
                    </td>
                </form>
        </table>
        <table class="table">
                <form action="vendor/searchN.php" method="post">
                    <td>
                        <input type="number" name="total" class="form-control" value="0">
                    </td>
                    <td>
                        <button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/searchM.php"'>Search total min</button>
                    </td>
                </form>
        </table>
    </div>

<?php
$connect->close();
require "Block/footer.php";
?>