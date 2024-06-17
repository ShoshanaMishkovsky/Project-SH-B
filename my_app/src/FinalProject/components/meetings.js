import React, { useState, useEffect } from 'react';

const Meetings = () => {
  const [meetings, setMeetings] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch('http://localhost:5211/api/Meetings')
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok ' + response.statusText);
        }
        return response.json();
      })
      .then(data => setMeetings(data))
      .catch(error => setError(error));
  }, []);

  if (error) {
    return <div>Error fetching meetings: {error.message}</div>;
  }

  return (
    <div>
      <h2>Meetings List</h2>
      <ul>
        {meetings.map(meeting => (
          <li key={meeting.id}>
            {meeting.details}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Meetings;
