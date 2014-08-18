<!DOCTYPE html>
<?php
mb_internal_encoding("UTF-8");
if(isset($_GET['amount']) && isset($_GET['currency']) && isset($_GET['compoundInterest'])) {
    $amount = $_GET['amount'];
    $currency = $_GET['currency'];
    $annualInterest = $_GET['compoundInterest'];
    $period = $_GET['period'];
}
?>
<html>
    <head>
        <title>Calculate interest</title>
    </head>
    <body>
        <form action="<?php $PHP_SELF ?>" method="get">
            <label for="amount">Enter Amount</label>
            <input type="text" name="amount" id="amount"><br/>
            <input type="radio" name="currency" id="us" value="us">
            <label for="us"><strong>USD</strong></label>
            <input type="radio" name="currency" id="euro" value="euro">
            <label for="euro"><strong>EURO</strong></label>
            <input type="radio" name="currency" id="bgn" value="bgn">
            <label for="bgn"><strong>BGN</strong></label><br/>
            <label for="comInterest">Compound Interes Amount</label>
            <input type="number" name="compoundInterest" id="comInterest"><br/>
            <select name="period">
                <option value="6">6 Months</option>
                <option value="12">1 Year</option>
                <option value="24">2 Years</option>
                <option value="60">5 Years</option>
            </select>
            <input type="submit" value="Calculate">
        </form>
        <?php
        if(isset($_GET['amount'])) {
            for($i = 0; $i < $period; $i++) {
                $amount *= (100 + $annualInterest / 12) / 100;
            }
            switch ($currency) {
                case 'us': $currency = "$";
                    break;
                case 'euro': $currency = '&#8364';
                    break;
                case 'bgn': $currency = 'lv';
                    break;
            }
            echo $currency . round($amount, 2);
        }
        ?>
    </body>
</html>