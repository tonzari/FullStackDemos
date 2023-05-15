# Services: Todo Sticky Notes (Angular Version)

This demo is a basic To Do list app, with some CSS designs inspired by sticky notes. This app exists as a vanilla JavaScript version as well, so be sure to check out the JS version in the JS directory of the student repo. 

This demo was created to show how it might be rewritten as an Angular app.

## New features since JS version of Todo demo

1. Click on a sticky note to cross out the "to do" message.
2. Click on a crossed-out sticky note to discard it. (CSS animations added to demonstrate deletion)

## Services

Services in Angular allow you to provide code or logic to the rest of your application and components.

For example, you might have a few different components that all need to know about the same piece of data. You can provide each component with access to a service which provides that data or logic to those components.

In this demo, we have a Service that manages the list of "to do" items. The list of all "to do" items are stored in the service, and the service also provides logic to interact with that list, such as basic CRUD like operations below:

```typescript
  getTodos(): Todo[] {
    return this.todos;
  }

  addTodo(todo: Todo): void {
    this.todos.push(todo);
  }

  completeTodo(todo: Todo): void {
    if (todo.isComplete) {
      this.deleteTodo(todo);
    } else {
      todo.isComplete = true;
    }
  }

  deleteTodo(todo: Todo): void {
    const index = this.todos.indexOf(todo);
    this.todos.splice(index,1);
  }
```

Later, we'll see how we can use a Service to communicate with our own database or APIs using HTTP.
https://angular.io/guide/http




