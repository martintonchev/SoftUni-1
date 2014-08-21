<!DOCTYPE html>
<html>
    <head>
        <title>Annual expenses</title>
    </head>
    <body>
        <form action="" method="post">
            <label for="years">Enter number of years: </label>
            <input type="number" name="years" id="years"/>
            <input type="submit" value="Show costs"/>
        </form><br/>
        <table border="1">
            <tr>
                <th>Year</th>
                <th>January</th>
                <th>February</th>
                <th>March</th>
                <th>April</th>
                <th>May</th>
                <th>June</th>
                <th>July</th>
                <th>August</th>
                <th>September</th>
                <th>October</th>
                <th>November</th>
                <th>December</th>
                <th>Total:</th>
            </tr>
            <?php
            if(isset($_POST['years'])) {
                $currentYear = 2014;
                $inputYears = $_POST['years'];
                for($i = $currentYear; $i > $currentYear - $inputYears; $i--) : ?>
                    <tr>
                        <td><?= $i ?></td>
                        <?php
                        $sum = 0;
                            for($j = 0; $j < 12; $j++) :
                                $randExpenses = rand(0, 999);
                                $sum += $randExpenses?>
                                <td><?= $randExpenses ?></td>
                            <?php endfor; ?>
                        <td><?= $sum ?></td>
                    </tr>
                <?php endfor;
            }
            ?>
        </table>
    </body>
</html>