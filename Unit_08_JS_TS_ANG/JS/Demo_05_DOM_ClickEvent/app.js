const createParagraphLink = document.getElementById("createParagraph");
const paragraphContainer = document.getElementById("contentWrapper");

createParagraphLink.addEventListener('click', () => {
    const p = document.createElement('p');
    p.innerText = "A brand new paragraph created in javascript.";
    paragraphContainer.appendChild(p);
})