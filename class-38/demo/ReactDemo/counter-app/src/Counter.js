import React from 'react';

const Counter = ({ counts, onIncrement }) => {
  return (
    <div>
      <ul>
        {counts.map((count, index) => (
          <li key={index}>Count: {count}</li>
        ))}
      </ul>
      <button onClick={onIncrement}>Increment</button>
    </div>
  );
};

export default Counter;
