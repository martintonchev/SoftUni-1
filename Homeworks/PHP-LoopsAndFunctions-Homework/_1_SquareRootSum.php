<!DOCTYPE html>
<html>
<head>
    <title>Square root sum</title>
</head>
<body>
    <table border="1">
        <tr><th>Number</th><th>Square</th></tr>
        <?php
        $sum = 0;
        for($i = 0; $i <= 100; $i+=2) :
            $sqrt = sqrt($i);
            $sum += $sqrt;
            ?>
            <tr>
                <td><?= $i ?></td>
                <td><?= round($square = sqrt($i), 2) ?></td>
            </tr>
        <?php endfor; ?>
        <tr><td>Sum: </td><td><?=round($sum, 2); ?></td></tr>
    </table>
</body>
</html>
