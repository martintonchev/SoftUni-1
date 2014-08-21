<!DOCTYPE html>
<html>
<head>
    <title>Rich people's problem</title>
</head>
<body>
    <form action="" method="post">
        <label>Enter cars: </label>
        <input type="text" name="cars"/>
        <input type="submit" value="Show Results">
    </form>
    <table border="1">
        <tr><th>Car</th><th>Color</th><th>Count</th></tr>
    <?php
    if(isset($_POST['cars'])) {
        $inputString = $_POST['cars'];
        $inputArray = explode(", ", $inputString);
    }
    if(isset($inputArray)) {
    for($i = 0; $i < count($inputArray); $i++) : ?>
        <?php
        $colorArray = array('red', 'green', 'yellow', 'blue', 'white', 'black');
        $randomColor = array_rand($colorArray, count($inputArray));
        $randomNumber = rand(0, 10);
        ?>
        <tr><td><?= $inputArray[$i] ?></td><td><?= $colorArray[$randomColor[$i]]?></td><td><?= $randomNumber?></td></tr>
    <?php endfor; } ?>
    </table>
</body>
</html>