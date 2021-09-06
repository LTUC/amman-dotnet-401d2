import { useState, useEffect } from 'react'
import axios from 'axios'
import useSWR from 'swr'
import { CookieStand, fetchWithToken, postWithToken } from '../services/data-fetcher'
import Head from 'next/head'
import CookieStandForm from './cookie-stand-form'
import CookieStandTable from './cookie-stand-table'
import CookieStandHeader from './cookie-stand-header'

export default function CookieStandAdmin({ tokens, onLogout, username }) {

    const url = 'https://cookie-stand-api.herokuapp.com/api/v1/cookie-stands/';

    const { data, error, mutate } = useSWR([url, tokens.access], fetchWithToken);

    const [cookieStands, setCookieStands] = useState([]);

    useEffect(() => {
        if (!data) return;
        setCookieStands(data);
    }, [data])

    if (error) return <h2>Ruh Roh</h2>
    if (!data) return <h2>Loading...</h2>

    async function createHandler(values) {

        const body = {
            id: -1, // will be overwritten once cache revalidates
            location: values.location,
            minimum_customers_per_hour: values.min,
            maximum_customers_per_hour: values.max,
            average_cookies_per_sale: values.avg,
        }

        const newStand = new CookieStand(body);

        newStand.location += '...';

        const updatedStands = [...cookieStands, newStand]

        mutate(updatedStands, false);

        await postWithToken(url, tokens.access, body);

        mutate();

    }

    async function deleteHandler(stand) {

        const updatedStands = cookieStands.filter(storedStand => storedStand.id !== stand.id);

        mutate(updatedStands, false);

        let config = {
            headers: {
                'Authorization': 'Bearer ' + tokens.access
            }
        }

        await axios.delete(url + stand.id + '/', config);

        mutate(async stands => {
            return stands.filter(candidate => candidate.id !== stand.id);
        });
    }

    return (
        <div>
            <Head>
                <title>Cookie Stand Admin</title>
                <link rel="icon" href="/favicon.ico" />
            </Head>

            <CookieStandHeader username={username} onLogout={onLogout} />

            <main className="w-5/6 mx-auto">
                <CookieStandForm onCreate={createHandler} />
                <CookieStandTable stands={cookieStands} onDelete={deleteHandler} />
            </main>
        </div>
    )
}
