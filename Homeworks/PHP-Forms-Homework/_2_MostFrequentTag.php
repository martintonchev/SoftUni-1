<!DOCTYPE html>
<?php
if(isset($_GET['tags'])) {
    $inputString = $_GET['tags'];
    $tags = explode(', ', $inputString);
    $frequencies = array_count_values($tags);
    $maxFreq = array_search(max($frequencies), $frequencies);
    arsort($frequencies);
}
?>
<html>
    <head>
        <title>Most frequent tag</title>
    </head>
    <body>
        <form  action="<?php $PHP_SELF ?>" method="get">
            <label for="text">Enter tags:</label><br/>
            <input type="text" id="text" name="tags"/>
            <input type="submit"/>
        </form>
        <?php
        if(isset($frequencies)) {
            foreach ($frequencies as $key => $value) {
                echo "$key : $value times <br/>";
            }
            echo "Most frequent tag is: $maxFreq";
        }
        ?>
    </body>
</html>