import React from 'react';

const TodoList = ({todos})=>{
    return (
        <ul>
            {todos.map((todo, index) => (
                <li key={todo.id}>{todo.text}</li>
            ))}
        </ul>
    )
}
const App = () => {
    const todos = [
        {id: 1, text: 'Learn React'},
        {id: 2, text: 'Build a Todo App'},
        {id: 3, text: 'Master React Hooks'}
    ];
    return (
        <div>
            <h1>My Todo List</h1>
            <TodoList todos={todos} />
        </div>
    )
}   
export default App