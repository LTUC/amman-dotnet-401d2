import useSWR from "swr"
import axios from 'axios'

const url = "https://cookie-stand-api.herokuapp.com/api/token/";

async function userFetcher(url, username, password) {

    console.log('userFetcher', url, username, password);

    const response = await axios.post(url, { username, password });

    return {
        data: response.data,
        error: null,
    }
}

export default function useUser(username, password) {
    const { data, mutate, error } = useSWR(url, (url) => userFetcher(url, username, password));

    const loading = !data && !error;
    const loggedOut = error && error.status === 403;

    return {
        loading,
        loggedOut,
        user: data,
        mutate
    };
}
