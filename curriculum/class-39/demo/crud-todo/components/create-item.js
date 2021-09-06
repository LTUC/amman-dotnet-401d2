import { useState } from 'react'

export default function CreateItem({ onCreate }) {

    const [title, setTitle] = useState('');
    const [description, setDescription] = useState('');

    function handleSubmit(event) {
        event.preventDefault();
        onCreate({ title, description });
        setTitle('');
        setDescription('');
    }

    function handleTitleChange(event) {
        setTitle(event.target.value);
    }

    function handleDescriptionChange(event) {
        setDescription(event.target.value);
    }

    return (
        <form className="w-1/2 mx-auto my-2" onSubmit={handleSubmit}>
            <input className="border border-black" onChange={handleTitleChange} value={title} placeholder="title" />
            <input className="border border-black" onChange={handleDescriptionChange} value={description} placeholder="description" />
            <button className="px-4 py-2 mx-2 bg-gray-300 rounded" >Create Todo Item</button>
        </form>

    );
}


