
// Get a reference to the form
const form = document.getElementById("todo-form");

// Get the form's input. (Notice with querySelector, # is needed for IDs and . is needed for classes)
const todoInput = form.querySelector("#todo-input");

// Get the form's submit button
const todoSubmit = form.querySelector("#todo-submit");

// Get the To Do div container, where will add new To Do items
const todoContainer = document.getElementById("todo-container");

// Now we can access the value submitted to the form.



// Add a click event listener on the submit button
todoSubmit.addEventListener('click', 
    
    // This function is called everytime a click on the submit button is observed
    // It is handling MANY different tasks.
    // Q: How can we split up the tasks and organize our code?

    function(event) {
    
        // Call 'preventDefault()' to prevent the browser from refreshing (the default behaviour when a link is clicked)
        event.preventDefault();

        const newTodo = document.createElement('div');
        const newTodoP = document.createElement('h2');

        newTodo.classList.add("todo-item");

        // Add slight random rotation
        const degree = getRandomInt(-4,5);

        newTodo.classList.add("rotated");
        newTodo.style.transform = `rotate(${degree}deg)`;

        // Add random sticky note color
        const stickyNoteColors = ['yellow','pink', 'green', 'blue', 'orange', 'purple']; // see the CSS file

        const randColorIndex = getRandomInt(0,stickyNoteColors.length);
        newTodo.classList.add(`sticky-note-${stickyNoteColors[randColorIndex]}`);
        newTodo.classList.add("raised");

        newTodoP.innerText = todoInput.value;
        todoInput.value = "";

        newTodo.appendChild(newTodoP);
        todoContainer.appendChild(newTodo);

        // Animate the enterance of note
        setTimeout(() => {
            newTodo.classList.remove("raised");
        }, 500);

    }
);

// - - - - - - Helper functions - - - - - - - - -

function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);

    // The maximum is exclusive and the minimum is inclusive
    return Math.floor(Math.random() * (max - min) + min); 
}
  
  