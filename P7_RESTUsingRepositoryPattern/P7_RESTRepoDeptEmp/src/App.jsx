import Departments from "./components/Departments";
import Employees from "./components/Employees";
import "./App.css";

function App() {
  return (
    <div className="app">
      <h1>Company Management</h1>

      <div className="grid">
        <Departments />
        <Employees />
      </div>
    </div>
  );
}

export default App;
