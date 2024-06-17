import React, { useState, useEffect } from 'react';

const Queues = () => {
  const [dietitians, setDietitians] = useState([]);
  const [queues, setQueues] = useState([]);
  const [selectedDietitianId, setSelectedDietitianId] = useState(null);
  const [selectedDate, setSelectedDate] = useState(null);
  const [clientId, setClientId] = useState('');

  useEffect(() => {
    fetch('http://localhost:5211/api/Dietitians')
      .then(response => response.json())
      .then(data => setDietitians(data))
      .catch(error => console.error('Error fetching dietitians:', error));
  }, []);
  const handleDietitianClick = (dietitianId) => {
    debugger
    setSelectedDietitianId(dietitianId);
    fetch(`http://localhost:5211/api/Queues/${dietitianId}`)
      .then(response => response.json())
      .then(data => setQueues(data))
      .catch(error => console.error('Error fetching queues:', error));
  };
  
  const handleDateClick = (date, hour) => {
    if (date && hour) {
      setSelectedDate({ date, hour });
    } else {
      console.error('Invalid date or hour');
    }
  };
  const handleAddMeeting = () => {
    if (!selectedDietitianId || !selectedDate || !clientId) {
      alert('Please select a dietitian, a date, and enter a client ID.');
      return;
    }

    const newMeeting = {
      DieticanId: selectedDietitianId,
      ClientId: parseInt(clientId),
      Status: 'invited',
      Date: selectedDate.date,
      Hour: selectedDate.hour
    };

    fetch('http://localhost:5211/api/Meetings', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(newMeeting)
    })
    .then(response => response.json())
    .then(data => {
      alert('Meeting added successfully!');
      setSelectedDietitianId(null);
      setSelectedDate(null);
      setClientId('');
    })
    .catch(error => {
      alert('Error adding meeting: ' + error.message);
    });
  };

  return (
    <div className="queues">
      <h2>Queues</h2>
      <div className="dietitians-list">
        <h3>Select a Dietitian</h3>
        <ul>
        {dietitians.map(dietitian => (
  <li key={dietitian.id}>
    <p>{dietitian.id}</p> {/* תוודאי שה-Id מוצג כאן כראוי */}
    <button onClick={() => handleDietitianClick(dietitian.id)}>
      {dietitian.firstName} {dietitian.lastName}
    </button>
  </li>
))}
        </ul>
      </div>
      {selectedDietitianId && (
        <div className="queues-list">
          <h3>Select a Date</h3>
          <ul>
            {queues.map(queue => (
              <li key={queue.code} onClick={() => handleDateClick(queue.date, queue.hour)}>
                {new Date(queue.date).toLocaleDateString()} at {queue.hour}
              </li>
            ))}
          </ul>
        </div>
      )}
      {selectedDate && (
        <div className="add-meeting">
          <h3>Add Meeting</h3>
          <div className="form-group">
            <label>Client ID:</label>
            <input
              type="text"
              value={clientId}
              onChange={(e) => setClientId(e.target.value)}
            />
          </div>
          <button onClick={handleAddMeeting}>Add Meeting</button>
        </div>
      )}
    </div>
  );
};

export default Queues;



