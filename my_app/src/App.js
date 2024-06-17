
import './App.css';

import './css.css';


import React from 'react';
import { BrowserRouter as Router, Route, Routes } from 'react-router-dom';
import Dietitians from './FinalProject/components/dietitians';
import Meetings from './FinalProject/components/meetings';
import Clients from './FinalProject/components/clients';
import Queues from './FinalProject/components/queues';
import { Link } from'react-router-dom';
import AddClient from './FinalProject/components/addClient';

function App() {
  return (<>
   <Router>
      <div className="App">
        <h1>Diet App</h1>
        <div className="navbar">
          <Link to="/dietitians">Dietitians</Link>
          <Link to="/meetings">Meetings</Link>
          <Link to="/clients">Clients</Link>
          <Link to="/queues">Queues</Link>
        </div>
        <div className="content">
          <Routes>
            <Route path="/dietitians" element={<Dietitians />} />
            <Route path="/meetings" element={<Meetings />} />
            <Route path="/clients" element={<Clients />} />
            <Route path="/queues" element={<Queues />} />
          </Routes>
        </div>
      </div>
    </Router>
    </>
  );
}

export default App;
