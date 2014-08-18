<!DOCTYPE html>
<html>
    <head>
        <title>HTML tags counter</title>
    </head>
    <body>
        <form action="<?php $PHP_SELF ?>" method="get">
            <label for="tags">Enter HTML Tags: </label><br/>
            <input type="text" id="tags" name="tags">
            <input type="submit" value="Submit">
        </form>
        <div id="result">
            <?php
                session_start();
                $validTags = array('a', 'abbr', 'acronym', 'address', 'applet', 'area', 'b', 'base', 'basefont',
                    'bdo', 'bgsound', 'big', 'blockquote', 'blink', 'body', 'br', 'button', 'caption', 'center', 'cite', 'code',
                    'col', 'colgroup', 'dd', 'dfn', 'del', 'dir', 'dl', 'div', 'dt', 'embed', 'em', 'fieldset', 'font', 'form',
                    'frame', 'frameset', 'h1', 'h2', 'h3', 'h4', 'h5', 'h6', 'head', 'hr', 'html', 'iframe', 'img', 'input',
                    'ins', 'isindex', 'i', 'kbd', 'label', 'legend', 'li', 'link', 'marquee', 'menu', 'meta', 'noframe',
                    'noscript', 'optgroup', 'option', 'ol', 'p', 'pre', 'q', 's', 'samp', 'script', 'select', 'small', 'span', 'strike',
                    'strong', 'style', 'sub', 'sup', 'table', 'td', 'th', 'tr', 'tbody', 'textarea', 'tfoot', 'thead', 'title',
                    'tt', 'u', 'ul', 'var');
            $count = 1;
            if(isset($_GET['tags'])) {
                if($_GET['tags'] == '') {
                    if(isset($_SESSION['count'])) {
                        unset($_SESSION['count']);
                    }
                }
                if(in_array($_GET['tags'], $validTags)) {
                    echo "Valid html tag";
                    if(isset($_SESSION['count'])) {
                        $_SESSION['count']++;
                    }
                    else {
                        $_SESSION['count'] = 1;
                    }
                    echo "Score: " . $_SESSION['count'];
                }
                else {
                    echo "Not a valid html tag";
                }
            }
            ?>
        </div>
    </body>
</html>