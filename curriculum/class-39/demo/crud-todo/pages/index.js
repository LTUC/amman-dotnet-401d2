import axios from 'axios'
import Head from 'next/head'
import useSwr from 'swr'
import CreateItem from '../components/create-item'
import Header from '../components/header'
import ItemsList from '../components/items-list'

export default function Home() {

    const API = '/api/items';

    const { data, error, mutate } = useSwr(API, axios.get);

    if (error) return <h2>This is awkward...</h2>
    if (!data) return <p>loading...</p>

    const items = data.data;

    async function handleDelete(item) {
        await axios.delete(`${API}/${item.id}`);
        mutate();
    }

    async function handleCreate(info) {
        await axios.post(API, { title: info.title, description: info.description, completed: false });
        mutate();
    }

    async function handleCompleteToggle(item) {
        item.completed = !item.completed;
        await axios.put(`${API}/${item.id}`, item);
        mutate();
    }

    return (
        <div>
            <Head>
                <title>Todo</title>
                <link rel="icon" href="/favicon.ico" />
            </Head>

            <main>
                <Header />
                <CreateItem onCreate={handleCreate} />
                <ItemsList
                    onCompleteToggle={handleCompleteToggle}
                    onDelete={handleDelete}
                    items={items}
                />
            </main>

        </div>
    )
}



