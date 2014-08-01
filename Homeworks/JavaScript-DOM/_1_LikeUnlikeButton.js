function changeText() {
    var likeButton = document.getElementById('likeButton');
    var likeButtonValue = likeButton.textContent;
    if(likeButtonValue == 'Like') {
        likeButtonValue = 'Unlike';
    }
    else {
        likeButtonValue = 'Like';
    }
    likeButton.textContent = likeButtonValue;
}
var likeButton = document.getElementById('likeButton');
likeButton.addEventListener('click', changeText, false);
