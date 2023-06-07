import Head from 'next/head'
import Link from 'next/link'
import { useState } from 'react'

const allProductNames = ['bag', 'banana', 'bathroom', 'boots', 'breakfast', 'bubblegum', 'chair', 'cthulhu', 'dog-duck', 'dragon', 'pen', 'pet-sweep', 'scissors', 'shark', 'sweep', 'tauntaun', 'unicorn', 'usb', 'water-can', 'wine-glass'];

export default function Home() {

    const [orders, setOrders] = useState([]);

    function itemAddHandler(itemInfo) {
        setOrders([...orders, itemInfo])
    }

    return (
        <div>
            <Head>
                <title>Bus Mall Store</title>
                <link rel="icon" href="/favicon.ico" />
            </Head>

            <header className="flex items-center justify-between w-full px-8 py-4 bg-indigo-700 text-gray-50">
                <h1 className="text-4xl">Bus Mall Store</h1>
                <nav className="space-x-2">
                    <Link href="/">
                        <a>Home</a>
                    </Link>
                    <Link href="/cart">
                        <a>Cart<span>({orders.length})</span></a>
                    </Link>
                </nav>
            </header>
            <main className="w-5/6 min-h-screen py-2 mx-auto">

                <div className="border border-purple-700 rounded-lg">
                    <header className="text-center bg-purple-400 text-gray-50 ">
                        <h2>Shop Our Catalog</h2>
                    </header>
                    <p>
                        Select an item from our catalog and indicate how many you would like to purchase.
                    </p>
                    <p>
                        Once you've made your selection, click the "Add to Cart" button
                    </p>
                    <p>
                        When you are ready to purchase, click the "Cart" link above to view your cart and check out
                    </p>
                    <AddItemForm onSubmit={itemAddHandler} />
                </div>

                {orders.map((order, i) => (
                    <p key={i}>
                        {order.item} {order.quantity}
                    </p>
                ))}
            </main>

            <footer>
                <p className="w-full py-4 text-center text-gray-600 bg-gray-200">©2021 Code Fellows</p>
            </footer>

        </div>
    )
}


function AddItemForm(props) {

    const [item, setItem] = useState(allProductNames[0]);
    const [quantity, setQuantity] = useState(1);

    function itemChangeHandler(event) {
        setItem(event.target.value);
    }

    function quantityChangeHandler(event) {
        setQuantity(parseInt(event.target.value));
    }

    function submitHandler(event) {
        event.preventDefault();
        props.onSubmit({
            item,
            quantity,
        })
    }

    return (
        <form id="catalog" onSubmit={submitHandler}>
            <fieldset>
                <legend>Catalog</legend>
                <label>
                    <span>Item</span>
                    <select name="items" onChange={itemChangeHandler} value={item}>
                        {allProductNames.map(name => (
                            <option key={name} value={name}>{name}</option>
                        ))}
                    </select>
                </label>
                <label>
                    <span>Quantity</span>
                    <input name="quantity" type="number" onChange={quantityChangeHandler} value={quantity} />
                </label>
                <input type="submit" value="Add To Cart" />
            </fieldset>
        </form>
    )
}
