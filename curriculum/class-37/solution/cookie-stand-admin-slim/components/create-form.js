export default function CreateForm({ onCreate }) {

    function submitHandler(event) {
        event.preventDefault();
        onCreate({
            location: event.target.location.value,
            minCustomers: parseInt(event.target.minCustomers.value),
            maxCustomers: parseInt(event.target.maxCustomers.value),
            avgCookies: parseFloat(event.target.avgCookies.value),
        });
    }
    return (
        <form onSubmit={submitHandler} className="flex flex-col w-2/3 gap-2 p-4 mx-auto bg-green-300 border-green-500 rounded-lg">

            <legend className="text-2xl text-center">Create Cookie Stand</legend>

            <div className="flex py-4">
                <label className="mr-2" htmlFor="location">Location</label>
                <input className="flex-auto pl-2 placeholder-gray-50" type="text" name="location" />
            </div>

            <div className="flex gap-2 text-center item-centereduce">

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 ">
                    <label htmlFor="min-customers">Minimum Customers per Hour</label>
                    <input className="pl-2" type="number" name="minCustomers" />
                </fieldset>

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 ">
                    <label htmlFor="max-customers">Maximum Customers per Hour</label>
                    <input className="pl-2" type="number" name="maxCustomers" />
                </fieldset>

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 ">
                    <label htmlFor="avg-cookies">Average Cookies per Sale</label>
                    <input className="pl-2" type="number" name="avgCookies" step=".1" />
                </fieldset>
                <button type="submit" className="flex-1 min-w-0 bg-green-500">Create</button>
            </div>

        </form>
    )
}
