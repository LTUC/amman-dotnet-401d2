export default function CreateForm({ onCreate }) {

    function submitHandler(event) {
        event.preventDefault();
        onCreate({
            id: event.target.location.value,
            location: event.target.location.value,
            hourly_sales: [48, 42, 30, 24, 42, 24, 36, 42, 42, 48, 36, 42, 24, 36]
        });
        event.target.reset();
    }
    return (
        <form onSubmit={submitHandler} className="flex flex-col w-2/3 gap-2 p-4 mx-auto bg-green-300 border-green-500 rounded">

            <legend className="text-2xl text-center">Create Cookie Stand</legend>

            <div className="flex py-4">
                <label className="mr-2" htmlFor="location">Location</label>
                <input className="flex-auto" type="text" name="location" />
            </div>

            <div className="flex gap-2 text-center item-centereduce">

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 bg-green-200 rounded">
                    <label htmlFor="min-customers">Minimum Customers per Hour</label>
                    <input type="number" name="min-customers" />
                </fieldset>

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 bg-green-200 rounded">
                    <label htmlFor="max-customers">Maximum Customers per Hour</label>
                    <input type="number" name="max-customers" />
                </fieldset>

                <fieldset className="flex flex-col flex-1 min-w-0 p-2 bg-green-200 rounded">
                    <label htmlFor="avg-cookies">Average Cookies per Sale</label>
                    <input type="number" name="avg-cookies" step=".1" />
                </fieldset>
                <button type="submit" className="flex-1 min-w-0 bg-green-500 rounded">Create</button>
            </div>

        </form>
    )
}
