import React, {useState, useEffect} from 'react';
import axios from 'axios';

const DataFetchingComponent = () => {
    const [techs, setTechs] = useState([]);

    useEffect(() => {
     // Fetch the data from school API using Axios
     axios.get('https://localhost:44373/api/Technologies')
     .then(responce => {
        setTechs(responce.data);
     })
     .catch(error => {
        console.log('Error when fetching the data:', error)
     });
    });

    return(
        <div>
            <h2>Technologies</h2>
            <ul>
                {techs.map(tech => (
                    <li key={tech.id}>{tech.name}</li>
                ))}
            </ul>
        </div>
    );
};

export default DataFetchingComponent;