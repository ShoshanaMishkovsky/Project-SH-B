import React, { useState, useEffect } from 'react';

const Clients = () => {
  const [clients, setClients] = useState([]);
  const [client, setClient] = useState({
    id: '',
    firstName: '',
    lastName: '',
    phone: '',
    kind: '',
    birthDate: ''
  });
  const [message, setMessage] = useState('');

  useEffect(() => {
    fetch('http://localhost:5211/api/Clients')
      .then(response => response.json())
      .then(data => setClients(data))
      .catch(error => console.error('Error fetching clients:', error));
  }, []);

  const handleChange = (e) => {
    setClient({ ...client, [e.target.name]: e.target.value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();

    fetch('http://localhost:5211/api/Clients', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(client)
    })
    .then(response => response.json())
    .then(data => {
      setMessage('Client added successfully!');
      setClients([...clients, data]);
      setClient({ id: '', firstName: '', lastName: '', phone: '', kind: '', birthDate: '' });
    })
    .catch(error => {
      setMessage('Error adding client: ' + error.message);
    });
  };

  return (
    <div className="clients">
      <h2>Clients</h2>
      <ul>
        {clients.map(client => (
          <li key={client.id}>{client.firstName} {client.lastName}</li>
        ))}
      </ul>
      <div className="add-client">
        <h3>Add New Client</h3>
        <form onSubmit={handleSubmit}>
          <div className="form-group">
            <label>Id:</label>
            <input type="text" name="id" value={client.id} onChange={handleChange} required />
          </div>
          <div className="form-group">
            <label>First Name:</label>
            <input type="text" name="firstName" value={client.firstName} onChange={handleChange} required />
          </div>
          <div className="form-group">
            <label>Last Name:</label>
            <input type="text" name="lastName" value={client.lastName} onChange={handleChange} required />
          </div>
          <div className="form-group">
            <label>Phone:</label>
            <input type="text" name="phone" value={client.phone} onChange={handleChange} required />
          </div>
          <div className="form-group">
            <label>Kind:</label>
            <select name="kind" value={client.kind} onChange={handleChange} required>
              <option value="">Select</option>
              <option value="m">Male</option>
              <option value="f">Female</option>
            </select>
          </div>
          <div className="form-group">
            <label>Birth Date:</label>
            <input type="date" name="birthDate" value={client.birthDate} onChange={handleChange} required />
          </div>
          <button type="submit">Add Client</button>
        </form>
        {message && <p>{message}</p>}
      </div>
    </div>
  );
};

export default Clients;


