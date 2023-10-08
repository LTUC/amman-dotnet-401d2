
"use client"
import React, {useState} from 'react';
import useSWR, {mutate} from 'swr';

const fetcher = async (url) => {
    const responce = await fetch(url);

    const data = await responce.json();

    return data;
}

const PostForm = () => {
    const [techName, setTechName]= useState('');
    
    const {data, error} = useSWR('https://localhost:44373/api/Technologies', fetcher);

    const handleSubmit = async (e) => {

        e.preventDefault();
        // Send a post request to create new Tech

        await fetch('https://localhost:44373/api/Technologies', {
            method: 'POST',
            body: JSON.stringify({
                name: techName,
                id: 0
            }),
            headers: {
                'Content-type': 'application/json; charset=UTF-8'
            }
        });

        mutate('https://localhost:44373/api/Technologies');

    }
    return (
        <div>
             <form onSubmit={handleSubmit}>
                 <label>
                      New Technology
                      <input type='text' onChange={(e) => setTechName(e.target.value)}/>
                 </label>
     
                 <button type='submit'>Submit</button>
             </form>
     
             <h2>Technologies</h2>
             {error && <div>Error while loading the data</div>}
             
             {data && (
                <ul>
                    {data.map((tech) => (
                        <li key={tech.id}>{tech.name}</li>
                    ))}
                </ul>
             )}
        </div>
     )
};



export default PostForm;