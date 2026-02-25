import React from 'react';

const Greeting = ({name})=>{
    return <p>Hello, {name}</p>
}

const App = () => {
    return (
        <div>
            <h1>Welcome to My App</h1>
            <Greeting name ="Anu"/>
        </div>
    )
}

export default App