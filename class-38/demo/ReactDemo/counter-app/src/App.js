import logo from './logo.svg';
import './App.css';

import React, { useState } from 'react';
import Counter from './Counter';

const App = () => {
  const [counts, setCounts] = useState([0]);

  const handleIncrement = () => {
    setCounts([...counts, counts[counts.length - 1] + 1]);
  };

  return (
    <div>
      <h1>React Counter App</h1>
      <Counter counts={counts} onIncrement={handleIncrement} />
    </div>
  );
};

export default App;


// const App = () => {
//   const [counts, setCount] = useState(0);

//   const handleIncrement = () => {
//     setCount([...counts, counts[counts.length] + 1]);
//   };

//   return (
//     <div>
//       <h1>React Counter App</h1>
//       <Counter counts={counts} onIncrement={handleIncrement} />
//       {/* {count % 2 === 0 ? <p>The count is even</p> : <p>The count is odd</p>} */}
//     </div>
//   );
// };

