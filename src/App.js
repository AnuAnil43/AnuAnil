import './App.css';
import ClassComponent from './Components/Classcomponent';
import Greeting from './Components/Greeting';
import TodoList from './Components/TodoList';
import FunctionalComponent from './Components/Functionalcomponent';
import Passingdatabetweencomponents from './Components/Passingdatabetweencomponents';

function App() {
  return (
    <div className="App">
      <Greeting name="Anu" />
    {/*}  <TodoList />
      <ClassComponent/>  
      <FunctionalComponent />   */}
      <Passingdatabetweencomponents title="My Card" description="This is a card component." />
    </div>
  );
}

export default App;
