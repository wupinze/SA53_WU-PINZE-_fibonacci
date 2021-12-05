import React, { useEffect, useState } from 'react';
import _axios from "axios"
import logo from './logo.svg';
import './App.css';

function App() {

  const [elements, setElements] = useState(20);
  const [fibonacci, setFibonacci] = useState('');
  const [sorted, setSorted] = useState('');

  useEffect(() => {
    _axios.post('/fibonacci', { 'elements': elements }, {
      headers: {
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*'
      }
    }).then(res => {
      setFibonacci(JSON.stringify(res.data[0]['Fibonacci']))
      setSorted(JSON.stringify(res.data[0]['Sorted']))
    })
  }, [elements]);

  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        <p>
          Edit <code>src/App.js</code> and save to reload.
        </p>
        <a
          className="App-link"
          href="https://reactjs.org"
          target="_blank"
          rel="noopener noreferrer"
        >
          Learn React
        </a>

        <p>
          <input type="number" value={elements} onChange={(e)=>{setElements(e.target.value)}} style={{"width" : "100px"}}/><br />
          Fibonacci: {fibonacci}<br />
          Sorted: {sorted}
        </p>

      </header>
    </div>
  );
}

export default App;
