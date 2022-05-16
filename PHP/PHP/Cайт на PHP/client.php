<?php
session_start();
$title = "Client";
require_once "Block/header.php";
require_once "config/connect.php";
?>

    <h1 align="center">Client</h1>
    <div class="container">
        <table class="table" id="myTable2">
            <thead class="table-dark">
                <td onclick="sortTable(0)">Id</td>
                <td onclick="sortTable(0)">Name</td>
                <td onclick="sortTable(0)">Email</td>
                <td>Edit</td>
                <td>Delete</td>
            </thead>
            <?php
            $clients = mysqli_query($connect,"SELECT * FROM `clients`");
            $clients = mysqli_fetch_all($clients);
            foreach ($clients as $client){
                ?>
                <tbody>
                    <td><?= $client[0]?></td>
                    <td><?= $client[1]?></td>
                    <td><?= $client[2]?></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/editClient.php?id=<?= $client[0]?>"'><img src="Image/Edit.gif" alt=""></button></td>
                    <td><button type="submit" class="btn btn-outline-secondary" onclick='location.href="vendor/delete.php?id=<?= $client[0]?>"''><img src="Image/Delete.gif" alt=""></button></td>
                </tbody>
                <?php
            }
            ?>
        </table >
        <input type="hidden" id="name_order" value="asc">
        <input type="hidden" id="age_order" value="asc">
        <table class="table">
            <tr>
                <td>
                    <form action="vendor/addClient.php" method="post">
                        <h5>Add new client
                            <button type="button" class="btn btn-outline-secondary" onclick='location.href="vendor/addClient.php"'><img src="Image/Add.gif" alt=""></button></td>
                </h5>
                </form>
            </tr>
        </table>
    </div>

<?php
$connect->close();
require "Block/footer.php";
?>