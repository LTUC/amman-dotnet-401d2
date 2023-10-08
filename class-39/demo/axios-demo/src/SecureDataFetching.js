import React, {useState, useEffect} from 'react';
import axios from 'axios';

const SecureDataFetching = () => {
    const [techs, setTechs] = useState([]);

    useEffect(() => {

    const token = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJodHRwOi8vc2NoZW1hcy54bWxzb2FwLm9yZy93cy8yMDA1LzA1L2lkZW50aXR5L2NsYWltcy9uYW1laWRlbnRpZmllciI6IjhhYjNiODZiLTU3ZWItNDFmNS1hNmJlLTZmODdjZGM0MTViOSIsImh0dHA6Ly9zY2hlbWFzLnhtbHNvYXAub3JnL3dzLzIwMDUvMDUvaWRlbnRpdHkvY2xhaW1zL25hbWUiOiJhcmFudGlzaTk2IiwiaHR0cDovL3NjaGVtYXMueG1sc29hcC5vcmcvd3MvMjAwNS8wNS9pZGVudGl0eS9jbGFpbXMvZW1haWxhZGRyZXNzIjoiZWxyYW50aXNpYW5hc0BnbWFpbC5jb20iLCJBc3BOZXQuSWRlbnRpdHkuU2VjdXJpdHlTdGFtcCI6Ik9NTkw0UFBWU1kzSUtOMkcyVkFLQU5JNVpKS0hQNkZGIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiQWRtaW4iLCJwZXJtaXNzaW9ucyI6WyJjcmVhdGUiLCJ1cGRhdGUiLCJkZWxldGUiXSwiZXhwIjoxNjk2NzUzNTAzfQ.vBeFYuNUrv7NdN4A7sO6M5qE-bU1glRhSQtP4YCEv2o";

    // Set the authorization header with the token

    const config = {
        headers:{
            Authorization: `Bearer ${token}`
        }
    }

     // Fetch the data from school API using Axios
      axios.get('https://localhost:44373/api/Technologies', config)
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
}

export default SecureDataFetching;