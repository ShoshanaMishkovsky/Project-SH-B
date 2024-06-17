import React, { useState } from 'react';

const AddClient = () => {
  const [client, setClient] = useState({
    firstName: '',
    lastName: '',
    phone: '',
    kind: '',
    birthDate: ''
  });
  const [message, setMessage] = useState('');

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
      setClient({ firstName: '', lastName: '', phone: '', kind: '', birthDate: '' });
    })
    .catch(error => {
      setMessage('Error adding client: ' + error.message);
    });
  };

  return (
    <div className="add-client">
      <h2>Add New Client</h2>
      <form onSubmit={handleSubmit}>
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
          <input type="text" name="kind" value={client.kind} onChange={handleChange} required />
        </div>
        <div className="form-group">
          <label>Birth Date:</label>
          <input type="date" name="birthDate" value={client.birthDate} onChange={handleChange} required />
        </div>
        <button type="submit">Add Client</button>
      </form>
      {message && <p>{message}</p>}
    </div>
  );
};

export default AddClient;