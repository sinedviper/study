<?php
/*
echo "<b>hell</b>";
echo "<br>\"Hello\"</br>";
$j = "guchi";
 eto plohoy kod
# suk
/*bnhihuoi
$number = 0;
$n = 4;
$k = 3.6;
echo $n . $number.'<br>';
echo $n + floatval($k).'<br>';
echo "<input type=\"text\"><br>";
$lenght = strlen($j);
echo $lenght.'<br>';
echo trim("  dwefd   ").'<br>';
echo md5("wefwa").'<br>';

if ($length = 5){
    echo "privet".'<br>';
}

$nd = array(4,42,-4.3,3,4,3.5,-7,);
echo $nd[5].'<br>';
$list = ["name"=>"skubby","years"=>15,"city"=>"odessa"];
echo $list["name"].'<br>';
$mat = [
        [23,-6.4,43.2],
        [-1,0,23.45]
       ];
echo $mat[1][2];

for($i=0;$i<10;$i++){
echo $i.'<br>';
}
foreach($list as $item => $value){
    echo "Key: $item, Value: $value".'<br>';
}
foreach($nd as $value){
    echo "Value - $value".'<br>';
}

//пошла главная тема функции
function info(){
    echo "ya ya ya morgenshtern".'<br>';
}
info();
function kuli($gug){
    echo "$gug<br>";
}
kuli(45);
kuli("bucking");

function fu($s,$g){
    return $s / $g;
}
echo fu(4,5).'<br>';
function jorney(){
    static $hulio;
    $hulio++;
    kuli($hulio);
}
jorney();
jorney();
jorney();*/

/*echo date('j/n/o').'<br>';
echo time();
echo date('j/n/o',time()-100).'<br>';
echo date('j/n/o',strtotime("-2 day -3 month -5 hour")).'<br>';
$g = [4,5,6,5,6,5];
unset($g[1]);
$g = array_values($g);
sort($g);
print_r($g);
echo '<br>';
rsort($g);
print_r($g);
echo '<br>';
shuffle($g);
print_r($g);
echo '<br>';
echo in_array(4,$g);
echo '<br>';

$arr = array_slice($g,0,count($g));
var_dump($arr);
print_r($arr);
echo '<br>';

$arr_1 =[5,43,3];
$arr_2 = [34,65,1,3,4];
$arr_3 = array_merge($arr_1,$arr_2);
print_r($arr_3);
echo '<br>';

$f = 5;
echo gettype($f);
echo '<br>';
echo is_numeric($f);
echo '<br>';

$str = "Example";
echo strpos($str,"amp");
echo '<br>';
$words = "john, bob, alex";
$arr_words = explode(",",$words);
print_r($arr_words);


$file = fopen("text.txt","a");
fwrite($file,"\nExample text");
fclose($file);
$filename = "text.txt";
$file = fopen("text.txt","r");
$content = fread($file, filesize($filename));
fclose($file);
echo $content;

echo $_SERVER['HTTP_HOST'].' - '. $_SERVER['REQUEST_URI'];

$message = "Сообщение";
$to = "admin@itproger.com";
$from ="sinedviper@gmail.com";
$subject = "Грустно";

$subject = "=?utf-8?b8".base64_encode($subject)."?=";
$headers = "From: $from\r\nReplay-to: %from\r\nContent-type:text/plan; charset=urf-8\r\n";

mail($to,$subject,$message,$headers);




$user="alex";

setcookie("user",$user,time()+180);
print_r($_COOKIE);
echo $_COOKIE ['user'];

$_SESSION['user']=$user;
echo "да, это не твоя сессия";
require_once "Block/footer.php";
include_once"Block/footer.php";




<form method="POST" action="/order-lables-print">
                        <input type="hidden" name="product_id" value="<?php  ?>"/>
                        <input type="submit" value="Calculate"/>
                    </form>
<!--<div class="container">
<form action="check_get.php" method="get">
    <input type="text" name="username" placeholder="Введите имя" class="form-control"><br>
    <input type="email" name="email" placeholder="Введите почту" class="form-control"><br>
    <input type="password" name="password" placeholder="Введите пароль" class="form-control"><br>
    <textarea name="message" class="form-control" placeholder="Введите сообщение"></textarea><br>
    <input type="submit" value="Отправить" class="btn btn-success">
</form>
</div>-->




<select name="pay1">
        <option selected="selected">Type of pay</option>
        <option value="In advance">In advance</option>
        <option value="On credit">On credit</option>
        <option value="Consignent">Consignent</option>
    </select>



*/
?>