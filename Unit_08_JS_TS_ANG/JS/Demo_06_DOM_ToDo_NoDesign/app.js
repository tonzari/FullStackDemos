
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
    
    // We must add a function here. This function will be called each time a 'click' on the submit button is observed.
    // The 'click' even is captured as an object and can be passed in to the function.
    function(event) {
    
        // Call 'preventDefault()' to prevent the browser from refreshing (the default behaviour when a link is clicked)
        event.preventDefault(); 

        // If you want, send the event captured to the console to learn about its content
        console.log(event);
        
        // Create a new 'To Do' div element
        const newTodo = document.createElement('div');

        // create a new 'to do' p element
        const newTodoP = document.createElement('p');

        // Assign the new p elements text to the value captured from the input field
        newTodoP.innerText = todoInput.value;

        // Place the p element inside the new todo div element
        newTodo.appendChild(newTodoP);

        // finally, to actually display it on our web page...
        // ... place the new todo element in the to do container
        todoContainer.appendChild(newTodo);
    }
);

