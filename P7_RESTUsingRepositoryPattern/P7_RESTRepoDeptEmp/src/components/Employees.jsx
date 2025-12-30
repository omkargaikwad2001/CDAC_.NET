import axios from "axios";
import { useEffect, useState } from "react";

const API = "https://localhost:7205/api/Employee";

function Employees() {
  const [emps, setEmps] = useState([]);
  const [emp, setEmp] = useState({
    employeeId: 0,
    name: "",
    salary: "",
    departmentId: ""
  });

  useEffect(() => {
    load();
  }, []);

  const load = async () => {
    const res = await axios.get(`${API}/GetAllEmp`);
    setEmps(res.data);
  };

  const save = async () => {
    if (!emp.name || !emp.salary || !emp.departmentId) return;

    if (emp.employeeId === 0) {
      // ADD
      await axios.post(`${API}/SaveEmp`, {
        name: emp.name,
        salary: emp.salary,
        departmentId: emp.departmentId
      });
    } else {
      // UPDATE
      await axios.put(`${API}/UpdateEmp`, emp);
    }

    setEmp({ employeeId: 0, name: "", salary: "", departmentId: "" });
    load();
  };

  const edit = (e) => {
    setEmp({
      employeeId: e.employeeId,
      name: e.name,
      salary: e.salary,
      departmentId: e.departmentId
    });
  };

  const del = async (id) => {
    await axios.delete(`${API}/DeleteEmp/${id}`);
    load();
  };

  return (
    <div className="card">
      <h2>Employees</h2>

      <div className="form">
        <input
          placeholder="Name"
          value={emp.name}
          onChange={(e) => setEmp({ ...emp, name: e.target.value })}
        />
        <input
          type="number"
          placeholder="Salary"
          value={emp.salary}
          onChange={(e) => setEmp({ ...emp, salary: e.target.value })}
        />
        <input
          type="number"
          placeholder="Dept ID"
          value={emp.departmentId}
          onChange={(e) => setEmp({ ...emp, departmentId: e.target.value })}
        />
        <button onClick={save}>
          {emp.employeeId === 0 ? "Add" : "Update"}
        </button>
      </div>

      <ul className="list">
        {emps.map((e) => (
          <li key={e.employeeId}>
            <span>{e.name} (₹{e.salary})</span>
            <div>
              <button onClick={() => edit(e)}>Edit</button>
              <button className="danger" onClick={() => del(e.employeeId)}>
                Delete
              </button>
            </div>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default Employees;
