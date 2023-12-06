var images = [
    { url: 'image1.jpg', caption: 'Caption 1' },
    { url: 'image2.jpg', caption: 'Caption 2' },
    { url: 'image3.jpg', caption: 'Caption 3' },
    { url: 'image4.jpg', caption: 'Caption 4' },
    { url: 'image5.jpg', caption: 'Caption 5' },
];
var currentIndex = 0;
function showImage(index) {
    var imageContainer = document.getElementById('image-container');
    var captionContainer = document.getElementById('caption-container');
    var currentImage = images[index];
    imageContainer.src = currentImage.url;
    captionContainer.innerText = currentImage.caption;
}
function showNextImage() {
    currentIndex = (currentIndex + 1) % images.length;
    showImage(currentIndex);
    if (currentIndex == 5) {
        currentIndex = 0;
        currentIndex = (currentIndex + 1) % images.length;
        showImage(currentIndex);
    }
}
function showPreviousImage() {
    currentIndex = (currentIndex - 1 + images.length) % images.length;
    showImage(currentIndex);
}
document.addEventListener('DOMContentLoaded', function () {
    showImage(currentIndex);
    var nextButton = document.getElementById('next-button');
    var prevButton = document.getElementById('prev-button');
    nextButton.addEventListener('click', showNextImage);
    prevButton.addEventListener('click', showPreviousImage);
});
