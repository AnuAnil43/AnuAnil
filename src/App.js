import './App.css';
import Greeting from './Components/Greeting';
import TodoList from './Components/TodoList';

function App() {
  return (
    <div className="App">
      <Greeting name="Anu" />
      <TodoList />
    </div>
  );
}

export default App;
