import axios from "axios";
import { useEffect, useState } from "react";

const API = "https://localhost:7205/api/Department";

function Departments() {
  const [departments, setDepartments] = useState([]);
  const [name, setName] = useState("");
  const [editId, setEditId] = useState(null);

  useEffect(() => {
    load();
  }, []);

  const load = async () => {
    const res = await axios.get(`${API}/GetAllDept`);
    setDepartments(res.data);
  };

  const save = async () => {
    if (!name.trim()) return;

    if (editId === null) {
      // ADD
      await axios.post(`${API}/SaveDept`, { departmentName: name });
    } else {
      // UPDATE
      await axios.put(`${API}/UpdateDept`, {
        departmentId: editId,
        departmentName: name
      });
    }

    setName("");
    setEditId(null);
    load();
  };

  const edit = (dept) => {
    setEditId(dept.departmentId);
    setName(dept.departmentName);
  };

  const del = async (id) => {
    await axios.delete(`${API}/DeleteDept/${id}`);
    load();
  };

  return (
    <div className="card">
      <h2>Departments</h2>

      <div className="form">
        <input
          placeholder="Department name"
          value={name}
          onChange={(e) => setName(e.target.value)}
        />
        <button onClick={save}>
          {editId ? "Update" : "Add"}
        </button>
      </div>

      <ul className="list">
        {departments.map((d) => (
          <li key={d.departmentId}>
            <span>{d.departmentName}</span>
            <div>
              <button onClick={() => edit(d)}>Edit</button>
              <button className="danger" onClick={() => del(d.departmentId)}>
                Delete
              </button>
            </div>
          </li>
        ))}
      </ul>
    </div>
  );
}

export default Departments;
