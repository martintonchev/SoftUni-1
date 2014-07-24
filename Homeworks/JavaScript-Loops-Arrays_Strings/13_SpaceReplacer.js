function replaceSpaces() {
    var inputString = arguments[0];
    var replacedString = inputString.replace(/ /g,'');
    console.log(replacedString);
    return replacedString;
}
replaceSpaces("But you were living in another world tryin' to get your message through");
