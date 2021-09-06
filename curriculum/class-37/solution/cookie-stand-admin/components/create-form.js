import React from 'react'

export default function CreateForm({ onCreate }) {

    function submitHandler(event) {
        event.preventDefault();
        onCreate({
            location: event.target.location.value,
            minCustomers: parseInt(event.target.minCustomers.value) || 0,
            maxCustomers: parseInt(event.target.maxCustomers.value) || 0,
            avgCookies: parseFloat(event.target.averageCookies.value) || 0,
        })
    }
    return (
        <form onSubmit={submitHandler} className="w-3/4 p-4 mx-auto space-y-6 bg-green-300 rounded">
            <legend className="text-2xl">Create Cookie Stand</legend>
            <p className="flex gap-4">
                <label htmlFor="location">Location</label>
                <input id="location" name="location" type="text" className="flex-1" required />
            </p>
            <div className="flex items-stretch gap-8">
                <div className="flex flex-col flex-1">
                    <label htmlFor="min-customers">Minimum Customers per Hour</label>
                    <input id="min-customers" name="minCustomers" type="number" min="0" required />
                </div>
                <div className="flex flex-col flex-1">
                    <label htmlFor="max-customers">Maximum Customers per Hour</label>
                    <input id="max-customers" name="maxCustomers" type="number" min="0" required />
                </div>
                <div className="flex flex-col flex-1">
                    <label htmlFor="average-cookies">Average Cookies per Sale</label>
                    <input id="average-cookies" name="averageCookies" type="number" step="any" min="0" required />
                </div>
                <button className="flex-1 p-2 bg-green-500 rounded">CREATE</button>
            </div>
        </form>
    )
}
