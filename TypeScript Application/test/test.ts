interface ImageDetails {
    url: string;
    caption: string;
}

const images: ImageDetails[] = [
    { url: 'image1.jpg', caption: 'Caption 1' },
    { url: 'image2.jpg', caption: 'Caption 2' },
    { url: 'image3.jpg', caption: 'Caption 3' },
    { url: 'image4.jpg', caption: 'Caption 4' },
    { url: 'image5.jpg', caption: 'Caption 5' },
];

let currentIndex = 0;

function showImage(index: number): void {
    const imageContainer = document.getElementById('image-container') as HTMLImageElement;
    const captionContainer = document.getElementById('caption-container') as HTMLDivElement;
    const currentImage = images[index];

    imageContainer.src = currentImage.url;
    captionContainer.innerText = currentImage.caption;
}

function showNextImage(): void {
    currentIndex = (currentIndex + 1) % images.length;
    showImage(currentIndex);
    if(currentIndex == 5)
    {
        currentIndex = 0;
        currentIndex = (currentIndex + 1) % images.length;
        showImage(currentIndex);
    }
}

function showPreviousImage(): void {
    currentIndex = (currentIndex - 1 + images.length) % images.length;
    showImage(currentIndex);
}

document.addEventListener('DOMContentLoaded', () => {
    showImage(currentIndex);

    const nextButton = document.getElementById('next-button') as HTMLButtonElement;
    const prevButton = document.getElementById('prev-button') as HTMLButtonElement;

    nextButton.addEventListener('click', showNextImage);
    prevButton.addEventListener('click', showPreviousImage);
});