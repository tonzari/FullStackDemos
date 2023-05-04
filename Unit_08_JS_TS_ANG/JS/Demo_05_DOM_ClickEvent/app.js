const createParagraphLink = document.getElementById("theSpecialButton");
const paragraphContainer = document.getElementById("contentWrapper");

console.log(createParagraphLink);

// simple click event and console log response
// createParagraphLink.addEventListener(  "click"  , // listening for a click...
    
//     // the response to the click (must be a function)
//     function()
//     {
//         console.log("click detected!");
//     }

// );


createParagraphLink.addEventListener('click', () => {
    const p = document.createElement('p');
    p.innerText = "A brand new paragraph created in javascript.";
    paragraphContainer.appendChild(p);
})