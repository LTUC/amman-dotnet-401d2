import { useState } from 'react'

export default function ItemsList({ items, onDelete, onCompleteToggle }) {

    const [showCompletedItems, setShowCompletedItems] = useState(true);

    function handleChange(event) {
        setShowCompletedItems(event.target.checked);
    }

    const filteredItems = items.filter(item => showCompletedItems || !item.completed);

    return (
        <div className="w-10/12 mx-auto">
            <label htmlFor="show-completed">show completed</label>
            <input id="show-completed" type="checkbox" checked={showCompletedItems} onChange={handleChange} />
            {filteredItems.map(item => {
                let className = "flex justify-between p-4 my-2 text-2xl bg-red-300 rounded";


                return (
                    <div className={className} key={item.id}>
                        <ItemTitle item={item} />
                        <div className="space-x-4">
                            <button onClick={() => onCompleteToggle(item)}>done</button>
                            <button onClick={() => onDelete(item)}>remove</button>
                        </div>
                    </div>
                )
            })}
        </div>
    )
}

function ItemTitle({ item }) {

    let className = "text-blue-800";

    if (item.completed) {
        className += " line-through";
    }

    return (
        <h2 className={className}>
            {item.title}
        </h2>
    );
}
