function countSubstringOccur(arg) {
    var keyword = arg[0];
    var text = arg[1];
    var text = text.toLowerCase();
    var regex = RegExp(keyword, 'g');
    var counter = text.match(regex);
    console.log(counter.length);
}
countSubstringOccur(["in", "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days."]);
