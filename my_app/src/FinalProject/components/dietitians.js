import React, { useState, useEffect } from 'react';

const Dietitians = () => {
  const [dietitians, setDietitians] = useState([]);
  const [error, setError] = useState(null);

  useEffect(() => {
    fetch('http://localhost:5211/api/Dietitians')
      .then(response => {
        if (!response.ok) {
          throw new Error('Network response was not ok ' + response.statusText);
        }
        return response.json();
      })
      .then(data => setDietitians(data))
      .catch(error => setError(error));
  }, []);

  if (error) {
    return <div>Error fetching dietitians: {error.message}</div>;
  }

  return (
    <div>
      <h2>Dietitians List</h2>
      <ul>
        {dietitians.map(dietitian => (
          <li key={dietitian.id}>
            {dietitian.firstName} {dietitian.lastName}
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Dietitians;
